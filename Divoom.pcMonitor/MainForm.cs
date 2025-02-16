using Divoom;
using Divoom.Models;
using LibreHardwareMonitor.Hardware;
using pcMonitor.Commands;
using pcMonitor.Utilities;
using System.ComponentModel;
using System.Net;
using Computer = LibreHardwareMonitor.Hardware.Computer;
using SensorType = LibreHardwareMonitor.Hardware.SensorType;

namespace pcMonitor
{
    public partial class MainForm : Form
    {
        private readonly Computer _computer;
        private readonly UpdateVisitor _updateVisitor;
        private readonly Node _root;
        private Device? _selectedDevice;
        private int? _selectedScreen;
        private bool _isMonitoring;

        private readonly DivoomPcMonitorUpdate _divoomPcMonitorUpdateCommand;

        public MainForm()
        {
            _divoomPcMonitorUpdateCommand = new DivoomPcMonitorUpdate();

            _computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsMotherboardEnabled = true,
                IsControllerEnabled = true,
                IsNetworkEnabled = true,
                IsStorageEnabled = true,
                IsPsuEnabled = true,
                IsBatteryEnabled = true
            };

            _computer.HardwareAdded += HardwareAdded;

            _updateVisitor = new UpdateVisitor();
            InitializeComponent();

            
            deviceContainer.Panel2Collapsed = true;
            SeedScreenList();
            RefreshDevices(this, EventArgs.Empty);

            sensor.Width = 250;
            value.Width = 100;
            min.Width = 100;
            max.Width = 100;
            treeView.RowHeight = 18;

            timer.Start();

            var computerName = Dns.GetHostName();

            var treeModel = new TreeModel();
            _root = new Node(computerName)
            {
                Image = EmbeddedResources.GetImage("computer.png")
            };

            treeModel.Nodes.Add(_root);

            treeView.Model = treeModel;

            backgroundUpdater.DoWork += BackgroundUpdater_DoWork;
        }

        private async void RefreshDevices(object sender, EventArgs e)
        {
            try
            {
                deviceContainer.Panel2Collapsed = true;
                deviceList.Items.Clear();
                var devices = await Service.FindDevices();
                foreach (var device in devices)
                {
                    var listItem = new ListViewItem([device.Name, device.IpAddress, device.MacAddress])
                    {
                        Tag = device
                    };
                    deviceList.Items.Add(listItem);
                }

                ResizeListColumns(deviceList);
            }
            catch
            {
                // Do Nothing
            }
        }

        private void SeedScreenList()
        {
            for (var i = 1; i <= 5; i++)
            {
                var listItem = new ListViewItem($"{i}")
                {
                    Tag = i - 1
                };
                screenList.Items.Add(listItem);
            }
            ResizeListColumns(screenList, 51);
        }

        private static void ResizeListColumns(ListView list, int size = -2)
        {
            // Default size is -2, which means auto size to fit the content
            foreach (ColumnHeader column in list.Columns)
                column.Width = size;
        }


        private async void OnDeviceSelected(object sender, EventArgs e)
        {
            try
            {
                if (deviceList.SelectedItems.Count <= 0)
                {
                    deviceContainer.Panel2Collapsed = true;
                    return;
                }

                if (deviceList.SelectedItems[0].Tag is DeviceInfo deviceInfo)
                {
                    _selectedDevice = new Device(deviceInfo);
                    deviceContainer.Panel2Collapsed = deviceInfo.Hardware != 400;
                    if (deviceInfo.Hardware != 400)
                    {
                        Application.DoEvents();
                        await _selectedDevice!.SetSubDial(625, 0);
                    }
                }
            }
            catch
            {
                // Do Nothing
            }
        }

        private async void OnScreenSelected(object sender, EventArgs e)
        {
            try
            {
                if (screenList.SelectedItems.Count <= 0) return;
                if (screenList.SelectedItems[0].Tag is int screenId)
                {
                    _selectedScreen = screenId;
                    Application.DoEvents();
                    await _selectedDevice!.SetSubDial(625, _selectedScreen.Value);
                }
            }
            catch 
            {
                // Do Nothing
            }
        }


        private HardwareNode? FindGpuNode()
        {
            foreach (var node in _root.Nodes)
            {
                if (node is not HardwareNode hardwareNode) continue;
                if (!hardwareNode.IsGpu) continue;
                return hardwareNode;
            }

            return null;
        }

        private HardwareNode? FindHardwareNode(HardwareType hardwareType)
        {
            foreach (var node in _root.Nodes)
            {
                if (node is not HardwareNode hardwareNode) continue;
                if (hardwareNode.Hardware.HardwareType != hardwareType) continue;
                return hardwareNode;
            }
            return null;
        }

        private void Tick(object sender, EventArgs e)
        {
            treeView.Invalidate();

            if (!backgroundUpdater.IsBusy)
                backgroundUpdater.RunWorkerAsync();

        }

        private void BackgroundUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            _computer.Accept(_updateVisitor);

            // Attempt to find the sensors if they are not set
            _divoomPcMonitorUpdateCommand.CpuLoadSensorNode ??= FindHardwareNode(HardwareType.Cpu)?.First(SensorType.Load);
            _divoomPcMonitorUpdateCommand.CpuTempSensorNode ??= FindHardwareNode(HardwareType.Cpu)?.First(SensorType.Temperature);
            _divoomPcMonitorUpdateCommand.GpuLoadSensorNode ??= FindGpuNode()?.First(SensorType.Load);
            _divoomPcMonitorUpdateCommand.GpuTempSensorNode ??= FindGpuNode()?.First(SensorType.Temperature);
            _divoomPcMonitorUpdateCommand.RamUseSensorNode ??= FindHardwareNode(HardwareType.Memory)?.First(SensorType.Load);
            _divoomPcMonitorUpdateCommand.HddTempSensorNode ??= FindHardwareNode(HardwareType.Storage)?.First(SensorType.Temperature);


            // Update the status bar
            toolStripStatusClock.Text = DateTime.Now.ToString("hh:mm:ss");

            toolStripCpuLoad.Text = _divoomPcMonitorUpdateCommand.CpuLoad;
            toolStripCpuTemp.Text = _divoomPcMonitorUpdateCommand.CpuTemp;
            toolStripGpuLoad.Text = _divoomPcMonitorUpdateCommand.GpuLoad;
            toolStripGpuTemp.Text = _divoomPcMonitorUpdateCommand.GpuTemp;
            toolStripRamUse.Text = _divoomPcMonitorUpdateCommand.RamUse;
            toolStripHddTemp.Text = _divoomPcMonitorUpdateCommand.HddTemp;


            // If a device is selected, send the update command
            if (_selectedDevice != null)
            {
                // TODO this command needs to be put in a background worker, if the
                // device is not reachable, the application will hang
                _divoomPcMonitorUpdateCommand.SendToDevice(_selectedDevice, _selectedScreen);
            }


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseApplication(this, EventArgs.Empty);
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            StopMonitoring();
            Application.Exit();
        }

        private void StopMonitoring()
        {
            _computer.Close();

            timer.Stop();
        }

        private void StartMonitoring()
        {
            toolStripText.Text = @"Starting Monitor ...";

            Application.DoEvents();

            _computer.Open();

            toolStripCpuLabel.Visible = true;
            toolStripCpuLoad.Visible = true;
            toolStripCpuTemp.Visible = true;
            toolStripGpuLabel.Visible = true;
            toolStripGpuLoad.Visible = true;
            toolStripGpuTemp.Visible = true;
            toolStripRamLabel.Visible = true;
            toolStripRamUse.Visible = true;
            toolStripHddLabel.Visible = true;
            toolStripHddTemp.Visible = true;

            Tick(this, EventArgs.Empty); // Initial update

            toolStripText.Text = "";
        }

        private void ToggleMonitoring(object sender, EventArgs e)
        {
            if (_isMonitoring)
                StopMonitoring();
            else
                StartMonitoring();

            _isMonitoring = !_isMonitoring;

            startPCMonitoringToolStripMenuItem.Text = _isMonitoring ? "Stop PC Monitoring" : "Start PC Monitoring";
        }

        private void InsertSorted(IList<Node> nodes, HardwareNode node)
        {
            var i = 0;
            while (i < nodes.Count && nodes[i] is HardwareNode && ((HardwareNode)nodes[i]).Hardware.HardwareType <= node.Hardware.HardwareType)
                i++;

            nodes.Insert(i, node);
        }

        private void SubHardwareAdded(IHardware hardware, Node node)
        {
            //if (hardware.Sensors.Length == 0 && hardware.SubHardware.Length == 0)
            //    return;

            var hardwareNode = new HardwareNode(hardware);
            InsertSorted(node.Nodes, hardwareNode);


            foreach (var subHardware in hardware.SubHardware)
                SubHardwareAdded(subHardware, hardwareNode);
        }

        private void HardwareAdded(IHardware hardware)
        {
            Console.WriteLine($"Hardware added {hardware.Name}");
            SubHardwareAdded(hardware, _root);
        }


        private void TreeViewClick(object sender, EventArgs e)
        {
            if (e is not MouseEventArgs { Button: MouseButtons.Right } m)
                return;

            var info = treeView.GetNodeControlInfoAt(new Point(m.X, m.Y));
            treeView.SelectedNode = info.Node;

            if (info.Node.Tag is SensorNode)
                sensorContextMenu.Show(treeView, new Point(m.X, m.Y));
        }

        private void OnSelectCpuLoadSensor(object sender, EventArgs e)
        {
            _divoomPcMonitorUpdateCommand.CpuLoadSensorNode = OnSelectSensor();
        }

        private void OnSelectCpuTempSensor(object sender, EventArgs e)
        {
            _divoomPcMonitorUpdateCommand.CpuTempSensorNode = OnSelectSensor();
        }

        private void OnSelectGpuLoadSensor(object sender, EventArgs e)
        {
            _divoomPcMonitorUpdateCommand.GpuLoadSensorNode = OnSelectSensor();
        }

        private void OnSelectGpuTempSensor(object sender, EventArgs e)
        {
            _divoomPcMonitorUpdateCommand.GpuTempSensorNode = OnSelectSensor();
        }

        private void OnSelectRamUseSensor(object sender, EventArgs e)
        {
            _divoomPcMonitorUpdateCommand.RamUseSensorNode = OnSelectSensor();
        }

        private void OnSelectHddTempSensor(object sender, EventArgs e)
        {
            _divoomPcMonitorUpdateCommand.HddTempSensorNode = OnSelectSensor();
        }

        private SensorNode? OnSelectSensor()
        {
            var selectedSensor = (SensorNode)treeView.SelectedNode.Tag;
            return selectedSensor ?? null;
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            var aboutForm = new AboutDialog();
            aboutForm.ShowDialog(this);
        }

        private void OnUpdateIntervalClick(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem menuItem in updateIntervalToolStripMenuItem.DropDownItems)
                menuItem.Checked = false;

            item.Checked = true;
            var text = item.Text;
            switch (text)
            {
                case "250ms":
                    timer.Interval = 250;
                    break;
                case "500ms":
                    timer.Interval = 500;
                    break;
                case "2s":
                    timer.Interval = 2000;
                    break;
                case "5s":
                    timer.Interval = 5000;
                    break;
                case "10s":
                    timer.Interval = 10000;
                    break;
                default:
                    timer.Interval = 1000;
                    break;
            }

        }
    }
}

