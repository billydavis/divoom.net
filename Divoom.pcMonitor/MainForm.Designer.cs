namespace pcMonitor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            nodeImage = new Aga.Controls.Tree.NodeControls.NodeIcon();
            sensor = new Aga.Controls.Tree.TreeColumn();
            nodeCheckBox = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            nodeTextBoxText = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeTextBoxValue = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            value = new Aga.Controls.Tree.TreeColumn();
            nodeTextBoxMin = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            min = new Aga.Controls.Tree.TreeColumn();
            nodeTextBoxMax = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            max = new Aga.Controls.Tree.TreeColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            refreshDevicesToolStripMenuItem = new ToolStripMenuItem();
            startPCMonitoringToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            oPtionsToolStripMenuItem = new ToolStripMenuItem();
            temperatureUnitToolStripMenuItem = new ToolStripMenuItem();
            celciusToolStripMenuItem = new ToolStripMenuItem();
            farenheightToolStripMenuItem = new ToolStripMenuItem();
            updateIntervalToolStripMenuItem = new ToolStripMenuItem();
            msToolStripMenuItem = new ToolStripMenuItem();
            msToolStripMenuItem1 = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem1 = new ToolStripMenuItem();
            sToolStripMenuItem2 = new ToolStripMenuItem();
            sToolStripMenuItem3 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            deviceContainer = new SplitContainer();
            deviceList = new ListView();
            name = new ColumnHeader();
            ipAddress = new ColumnHeader();
            macAddress = new ColumnHeader();
            screenList = new ListView();
            screen = new ColumnHeader();
            treeView = new Aga.Controls.Tree.TreeViewAdv();
            statusStrip1 = new StatusStrip();
            toolStripText = new ToolStripStatusLabel();
            toolStripCpuLabel = new ToolStripStatusLabel();
            toolStripCpuLoad = new ToolStripStatusLabel();
            toolStripCpuTemp = new ToolStripStatusLabel();
            toolStripGpuLabel = new ToolStripStatusLabel();
            toolStripGpuLoad = new ToolStripStatusLabel();
            toolStripGpuTemp = new ToolStripStatusLabel();
            toolStripRamLabel = new ToolStripStatusLabel();
            toolStripRamUse = new ToolStripStatusLabel();
            toolStripHddLabel = new ToolStripStatusLabel();
            toolStripHddTemp = new ToolStripStatusLabel();
            toolStripStatusClock = new ToolStripStatusLabel();
            panel2 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            sensorContextMenu = new ContextMenuStrip(components);
            cPULoadSensorToolStripMenuItem = new ToolStripMenuItem();
            cPUTempSensorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            gPULoadSensorToolStripMenuItem = new ToolStripMenuItem();
            gPUTempSensorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            rAMUseSensorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            hDDSensorToolStripMenuItem = new ToolStripMenuItem();
            backgroundUpdater = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deviceContainer).BeginInit();
            deviceContainer.Panel1.SuspendLayout();
            deviceContainer.Panel2.SuspendLayout();
            deviceContainer.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel2.SuspendLayout();
            sensorContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // nodeImage
            // 
            nodeImage.DataPropertyName = "Image";
            nodeImage.LeftMargin = 1;
            nodeImage.ParentColumn = sensor;
            nodeImage.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Fit;
            // 
            // sensor
            // 
            sensor.Header = "Sensor";
            sensor.SortOrder = SortOrder.None;
            sensor.TooltipText = null;
            // 
            // nodeCheckBox
            // 
            nodeCheckBox.DataPropertyName = "Plot";
            nodeCheckBox.EditEnabled = true;
            nodeCheckBox.LeftMargin = 3;
            nodeCheckBox.ParentColumn = null;
            // 
            // nodeTextBoxText
            // 
            nodeTextBoxText.DataPropertyName = "Text";
            nodeTextBoxText.EditEnabled = true;
            nodeTextBoxText.IncrementalSearchEnabled = true;
            nodeTextBoxText.LeftMargin = 3;
            nodeTextBoxText.ParentColumn = sensor;
            nodeTextBoxText.Trimming = StringTrimming.EllipsisCharacter;
            // 
            // nodeTextBoxValue
            // 
            nodeTextBoxValue.DataPropertyName = "Value";
            nodeTextBoxValue.IncrementalSearchEnabled = true;
            nodeTextBoxValue.LeftMargin = 3;
            nodeTextBoxValue.ParentColumn = value;
            nodeTextBoxValue.Trimming = StringTrimming.EllipsisCharacter;
            // 
            // value
            // 
            value.Header = "Value";
            value.SortOrder = SortOrder.None;
            value.TooltipText = null;
            value.Width = 100;
            // 
            // nodeTextBoxMin
            // 
            nodeTextBoxMin.DataPropertyName = "Min";
            nodeTextBoxMin.IncrementalSearchEnabled = true;
            nodeTextBoxMin.LeftMargin = 3;
            nodeTextBoxMin.ParentColumn = min;
            nodeTextBoxMin.Trimming = StringTrimming.EllipsisCharacter;
            // 
            // min
            // 
            min.Header = "Min";
            min.SortOrder = SortOrder.None;
            min.TooltipText = null;
            min.Width = 100;
            // 
            // nodeTextBoxMax
            // 
            nodeTextBoxMax.DataPropertyName = "Max";
            nodeTextBoxMax.IncrementalSearchEnabled = true;
            nodeTextBoxMax.LeftMargin = 3;
            nodeTextBoxMax.ParentColumn = max;
            nodeTextBoxMax.Trimming = StringTrimming.EllipsisCharacter;
            // 
            // max
            // 
            max.Header = "Max";
            max.SortOrder = SortOrder.None;
            max.TooltipText = null;
            max.Width = 100;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, oPtionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(836, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshDevicesToolStripMenuItem, startPCMonitoringToolStripMenuItem, toolStripSeparator1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // refreshDevicesToolStripMenuItem
            // 
            refreshDevicesToolStripMenuItem.Name = "refreshDevicesToolStripMenuItem";
            refreshDevicesToolStripMenuItem.Size = new Size(179, 22);
            refreshDevicesToolStripMenuItem.Text = "Refresh Devices";
            refreshDevicesToolStripMenuItem.Click += RefreshDevices;
            // 
            // startPCMonitoringToolStripMenuItem
            // 
            startPCMonitoringToolStripMenuItem.Name = "startPCMonitoringToolStripMenuItem";
            startPCMonitoringToolStripMenuItem.Size = new Size(179, 22);
            startPCMonitoringToolStripMenuItem.Text = "Start PC Monitoring";
            startPCMonitoringToolStripMenuItem.Click += ToggleMonitoring;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(179, 22);
            closeToolStripMenuItem.Text = "Exit";
            closeToolStripMenuItem.Click += CloseApplication;
            // 
            // oPtionsToolStripMenuItem
            // 
            oPtionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temperatureUnitToolStripMenuItem, updateIntervalToolStripMenuItem });
            oPtionsToolStripMenuItem.Name = "oPtionsToolStripMenuItem";
            oPtionsToolStripMenuItem.Size = new Size(61, 20);
            oPtionsToolStripMenuItem.Text = "Options";
            // 
            // temperatureUnitToolStripMenuItem
            // 
            temperatureUnitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { celciusToolStripMenuItem, farenheightToolStripMenuItem });
            temperatureUnitToolStripMenuItem.Name = "temperatureUnitToolStripMenuItem";
            temperatureUnitToolStripMenuItem.Size = new Size(166, 22);
            temperatureUnitToolStripMenuItem.Text = "Temperature Unit";
            // 
            // celciusToolStripMenuItem
            // 
            celciusToolStripMenuItem.Checked = true;
            celciusToolStripMenuItem.CheckState = CheckState.Checked;
            celciusToolStripMenuItem.Name = "celciusToolStripMenuItem";
            celciusToolStripMenuItem.Size = new Size(130, 22);
            celciusToolStripMenuItem.Text = "Celsius";
            // 
            // farenheightToolStripMenuItem
            // 
            farenheightToolStripMenuItem.Name = "farenheightToolStripMenuItem";
            farenheightToolStripMenuItem.Size = new Size(130, 22);
            farenheightToolStripMenuItem.Text = "Fahrenheit";
            // 
            // updateIntervalToolStripMenuItem
            // 
            updateIntervalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { msToolStripMenuItem, msToolStripMenuItem1, sToolStripMenuItem, sToolStripMenuItem1, sToolStripMenuItem2, sToolStripMenuItem3 });
            updateIntervalToolStripMenuItem.Name = "updateIntervalToolStripMenuItem";
            updateIntervalToolStripMenuItem.Size = new Size(166, 22);
            updateIntervalToolStripMenuItem.Text = "Update Interval";
            // 
            // msToolStripMenuItem
            // 
            msToolStripMenuItem.Name = "msToolStripMenuItem";
            msToolStripMenuItem.Size = new Size(108, 22);
            msToolStripMenuItem.Text = "250ms";
            msToolStripMenuItem.Click += OnUpdateIntervalClick;
            // 
            // msToolStripMenuItem1
            // 
            msToolStripMenuItem1.Name = "msToolStripMenuItem1";
            msToolStripMenuItem1.Size = new Size(108, 22);
            msToolStripMenuItem1.Text = "500ms";
            msToolStripMenuItem1.Click += OnUpdateIntervalClick;
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Checked = true;
            sToolStripMenuItem.CheckState = CheckState.Checked;
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(108, 22);
            sToolStripMenuItem.Text = "1s";
            sToolStripMenuItem.Click += OnUpdateIntervalClick;
            // 
            // sToolStripMenuItem1
            // 
            sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            sToolStripMenuItem1.Size = new Size(108, 22);
            sToolStripMenuItem1.Text = "2s";
            sToolStripMenuItem1.Click += OnUpdateIntervalClick;
            // 
            // sToolStripMenuItem2
            // 
            sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            sToolStripMenuItem2.Size = new Size(108, 22);
            sToolStripMenuItem2.Text = "5s";
            sToolStripMenuItem2.Click += OnUpdateIntervalClick;
            // 
            // sToolStripMenuItem3
            // 
            sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            sToolStripMenuItem3.Size = new Size(108, 22);
            sToolStripMenuItem3.Text = "10s";
            sToolStripMenuItem3.Click += OnUpdateIntervalClick;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += OnAboutClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(treeView);
            splitContainer1.Size = new Size(830, 422);
            splitContainer1.SplitterDistance = 326;
            splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(deviceContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 422);
            panel1.TabIndex = 0;
            // 
            // deviceContainer
            // 
            deviceContainer.Dock = DockStyle.Fill;
            deviceContainer.FixedPanel = FixedPanel.Panel2;
            deviceContainer.Location = new Point(0, 0);
            deviceContainer.Name = "deviceContainer";
            // 
            // deviceContainer.Panel1
            // 
            deviceContainer.Panel1.Controls.Add(deviceList);
            // 
            // deviceContainer.Panel2
            // 
            deviceContainer.Panel2.Controls.Add(screenList);
            deviceContainer.Size = new Size(326, 422);
            deviceContainer.SplitterDistance = 263;
            deviceContainer.TabIndex = 1;
            // 
            // deviceList
            // 
            deviceList.Columns.AddRange(new ColumnHeader[] { name, ipAddress, macAddress });
            deviceList.Dock = DockStyle.Fill;
            deviceList.FullRowSelect = true;
            deviceList.Location = new Point(0, 0);
            deviceList.MultiSelect = false;
            deviceList.Name = "deviceList";
            deviceList.Size = new Size(263, 422);
            deviceList.TabIndex = 0;
            deviceList.UseCompatibleStateImageBehavior = false;
            deviceList.View = View.Details;
            deviceList.SelectedIndexChanged += OnDeviceSelected;
            // 
            // name
            // 
            name.Text = "Device";
            // 
            // ipAddress
            // 
            ipAddress.Text = "Address";
            // 
            // macAddress
            // 
            macAddress.Text = "Mac Address";
            // 
            // screenList
            // 
            screenList.Columns.AddRange(new ColumnHeader[] { screen });
            screenList.Dock = DockStyle.Fill;
            screenList.FullRowSelect = true;
            screenList.Location = new Point(0, 0);
            screenList.MultiSelect = false;
            screenList.Name = "screenList";
            screenList.Size = new Size(59, 422);
            screenList.TabIndex = 0;
            screenList.UseCompatibleStateImageBehavior = false;
            screenList.View = View.Details;
            screenList.SelectedIndexChanged += OnScreenSelected;
            // 
            // screen
            // 
            screen.Text = "LCD";
            // 
            // treeView
            // 
            treeView.AsyncExpanding = true;
            treeView.BackColor = SystemColors.Window;
            treeView.Columns.Add(sensor);
            treeView.Columns.Add(value);
            treeView.Columns.Add(min);
            treeView.Columns.Add(max);
            treeView.DefaultToolTipProvider = null;
            treeView.Dock = DockStyle.Fill;
            treeView.DragDropMarkColor = Color.Black;
            treeView.FullRowSelect = true;
            treeView.GridLineStyle = Aga.Controls.Tree.GridLineStyle.Horizontal;
            treeView.LineColor = SystemColors.ControlDark;
            treeView.Location = new Point(0, 0);
            treeView.Model = null;
            treeView.Name = "treeView";
            treeView.NodeControls.Add(nodeImage);
            treeView.NodeControls.Add(nodeCheckBox);
            treeView.NodeControls.Add(nodeTextBoxText);
            treeView.NodeControls.Add(nodeTextBoxValue);
            treeView.NodeControls.Add(nodeTextBoxMin);
            treeView.NodeControls.Add(nodeTextBoxMax);
            treeView.RowHeight = 18;
            treeView.SelectedNode = null;
            treeView.Size = new Size(500, 422);
            treeView.TabIndex = 0;
            treeView.UseColumns = true;
            treeView.Click += TreeViewClick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripText, toolStripCpuLabel, toolStripCpuLoad, toolStripCpuTemp, toolStripGpuLabel, toolStripGpuLoad, toolStripGpuTemp, toolStripRamLabel, toolStripRamUse, toolStripHddLabel, toolStripHddTemp, toolStripStatusClock });
            statusStrip1.Location = new Point(0, 458);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(836, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripText
            // 
            toolStripText.Name = "toolStripText";
            toolStripText.Size = new Size(775, 17);
            toolStripText.Spring = true;
            toolStripText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripCpuLabel
            // 
            toolStripCpuLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripCpuLabel.Name = "toolStripCpuLabel";
            toolStripCpuLabel.Size = new Size(30, 17);
            toolStripCpuLabel.Text = "CPU";
            toolStripCpuLabel.Visible = false;
            // 
            // toolStripCpuLoad
            // 
            toolStripCpuLoad.Name = "toolStripCpuLoad";
            toolStripCpuLoad.Size = new Size(30, 17);
            toolStripCpuLoad.Text = "load";
            toolStripCpuLoad.Visible = false;
            // 
            // toolStripCpuTemp
            // 
            toolStripCpuTemp.Name = "toolStripCpuTemp";
            toolStripCpuTemp.Size = new Size(35, 17);
            toolStripCpuTemp.Text = "temp";
            toolStripCpuTemp.Visible = false;
            // 
            // toolStripGpuLabel
            // 
            toolStripGpuLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripGpuLabel.Margin = new Padding(8, 3, 0, 2);
            toolStripGpuLabel.Name = "toolStripGpuLabel";
            toolStripGpuLabel.Size = new Size(32, 17);
            toolStripGpuLabel.Text = "GPU";
            toolStripGpuLabel.Visible = false;
            // 
            // toolStripGpuLoad
            // 
            toolStripGpuLoad.Name = "toolStripGpuLoad";
            toolStripGpuLoad.Size = new Size(30, 17);
            toolStripGpuLoad.Text = "load";
            toolStripGpuLoad.Visible = false;
            // 
            // toolStripGpuTemp
            // 
            toolStripGpuTemp.Name = "toolStripGpuTemp";
            toolStripGpuTemp.Size = new Size(35, 17);
            toolStripGpuTemp.Text = "temp";
            toolStripGpuTemp.Visible = false;
            // 
            // toolStripRamLabel
            // 
            toolStripRamLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripRamLabel.Margin = new Padding(8, 3, 0, 2);
            toolStripRamLabel.Name = "toolStripRamLabel";
            toolStripRamLabel.Size = new Size(34, 17);
            toolStripRamLabel.Text = "RAM";
            toolStripRamLabel.Visible = false;
            // 
            // toolStripRamUse
            // 
            toolStripRamUse.Name = "toolStripRamUse";
            toolStripRamUse.Size = new Size(25, 17);
            toolStripRamUse.Text = "use";
            toolStripRamUse.Visible = false;
            // 
            // toolStripHddLabel
            // 
            toolStripHddLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripHddLabel.Margin = new Padding(8, 3, 0, 2);
            toolStripHddLabel.Name = "toolStripHddLabel";
            toolStripHddLabel.Size = new Size(34, 17);
            toolStripHddLabel.Text = "HDD";
            toolStripHddLabel.Visible = false;
            // 
            // toolStripHddTemp
            // 
            toolStripHddTemp.Name = "toolStripHddTemp";
            toolStripHddTemp.Size = new Size(35, 17);
            toolStripHddTemp.Text = "temp";
            toolStripHddTemp.Visible = false;
            // 
            // toolStripStatusClock
            // 
            toolStripStatusClock.Margin = new Padding(8, 3, 0, 2);
            toolStripStatusClock.Name = "toolStripStatusClock";
            toolStripStatusClock.Padding = new Padding(4, 0, 0, 0);
            toolStripStatusClock.Size = new Size(38, 17);
            toolStripStatusClock.Text = "00:00";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(splitContainer1);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(3);
            panel2.Size = new Size(836, 428);
            panel2.TabIndex = 3;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += Tick;
            // 
            // sensorContextMenu
            // 
            sensorContextMenu.Items.AddRange(new ToolStripItem[] { cPULoadSensorToolStripMenuItem, cPUTempSensorToolStripMenuItem, toolStripSeparator2, gPULoadSensorToolStripMenuItem, gPUTempSensorToolStripMenuItem, toolStripSeparator3, rAMUseSensorToolStripMenuItem, toolStripSeparator4, hDDSensorToolStripMenuItem });
            sensorContextMenu.Name = "sensorContextMenu";
            sensorContextMenu.Size = new Size(169, 154);
            sensorContextMenu.Text = "Set Monitor";
            // 
            // cPULoadSensorToolStripMenuItem
            // 
            cPULoadSensorToolStripMenuItem.Name = "cPULoadSensorToolStripMenuItem";
            cPULoadSensorToolStripMenuItem.Size = new Size(168, 22);
            cPULoadSensorToolStripMenuItem.Text = "CPU Load Sensor";
            cPULoadSensorToolStripMenuItem.Click += OnSelectCpuLoadSensor;
            // 
            // cPUTempSensorToolStripMenuItem
            // 
            cPUTempSensorToolStripMenuItem.Name = "cPUTempSensorToolStripMenuItem";
            cPUTempSensorToolStripMenuItem.Size = new Size(168, 22);
            cPUTempSensorToolStripMenuItem.Text = "CPU Temp Sensor";
            cPUTempSensorToolStripMenuItem.Click += OnSelectCpuTempSensor;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(165, 6);
            // 
            // gPULoadSensorToolStripMenuItem
            // 
            gPULoadSensorToolStripMenuItem.Name = "gPULoadSensorToolStripMenuItem";
            gPULoadSensorToolStripMenuItem.Size = new Size(168, 22);
            gPULoadSensorToolStripMenuItem.Text = "GPU Load Sensor";
            gPULoadSensorToolStripMenuItem.Click += OnSelectGpuLoadSensor;
            // 
            // gPUTempSensorToolStripMenuItem
            // 
            gPUTempSensorToolStripMenuItem.Name = "gPUTempSensorToolStripMenuItem";
            gPUTempSensorToolStripMenuItem.Size = new Size(168, 22);
            gPUTempSensorToolStripMenuItem.Text = "GPU Temp Sensor";
            gPUTempSensorToolStripMenuItem.Click += OnSelectGpuTempSensor;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(165, 6);
            // 
            // rAMUseSensorToolStripMenuItem
            // 
            rAMUseSensorToolStripMenuItem.Name = "rAMUseSensorToolStripMenuItem";
            rAMUseSensorToolStripMenuItem.Size = new Size(168, 22);
            rAMUseSensorToolStripMenuItem.Text = "RAM Use Sensor";
            rAMUseSensorToolStripMenuItem.Click += OnSelectRamUseSensor;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(165, 6);
            // 
            // hDDSensorToolStripMenuItem
            // 
            hDDSensorToolStripMenuItem.Name = "hDDSensorToolStripMenuItem";
            hDDSensorToolStripMenuItem.Size = new Size(168, 22);
            hDDSensorToolStripMenuItem.Text = "HDD Sensor";
            hDDSensorToolStripMenuItem.Click += OnSelectHddTempSensor;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 480);
            Controls.Add(panel2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Divoom PC Monitor";
            FormClosed += MainForm_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            deviceContainer.Panel1.ResumeLayout(false);
            deviceContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)deviceContainer).EndInit();
            deviceContainer.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            sensorContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem refreshDevicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private ListView deviceList;
        private SplitContainer deviceContainer;
        private ListView screenList;
        private ColumnHeader name;
        private ColumnHeader ipAddress;
        private ColumnHeader macAddress;
        private StatusStrip statusStrip1;
        private Panel panel2;
        private ColumnHeader screen;
        private System.Windows.Forms.Timer timer;
        private Aga.Controls.Tree.TreeViewAdv treeView;
        private Aga.Controls.Tree.TreeColumn sensor;
        private Aga.Controls.Tree.TreeColumn value;
        private Aga.Controls.Tree.TreeColumn min;
        private Aga.Controls.Tree.TreeColumn max;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeImage;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxText;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxValue;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMin;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBoxMax;
        private Aga.Controls.Tree.NodeControls.NodeCheckBox nodeCheckBox;
        private ToolStripMenuItem startPCMonitoringToolStripMenuItem;
        private ToolStripStatusLabel toolStripText;
        private ToolStripStatusLabel toolStripStatusClock;
        private ContextMenuStrip sensorContextMenu;
        private ToolStripMenuItem cPULoadSensorToolStripMenuItem;
        private ToolStripMenuItem cPUTempSensorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem gPULoadSensorToolStripMenuItem;
        private ToolStripMenuItem gPUTempSensorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem rAMUseSensorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem hDDSensorToolStripMenuItem;
        private ToolStripStatusLabel toolStripCpuLabel;
        private ToolStripStatusLabel toolStripCpuLoad;
        private ToolStripStatusLabel toolStripCpuTemp;
        private ToolStripStatusLabel toolStripGpuLabel;
        private ToolStripStatusLabel toolStripGpuLoad;
        private ToolStripStatusLabel toolStripGpuTemp;
        private ToolStripStatusLabel toolStripRamLabel;
        private ToolStripStatusLabel toolStripRamUse;
        private ToolStripStatusLabel toolStripHddLabel;
        private ToolStripStatusLabel toolStripHddTemp;
        private ToolStripMenuItem oPtionsToolStripMenuItem;
        private ToolStripMenuItem temperatureUnitToolStripMenuItem;
        private ToolStripMenuItem celciusToolStripMenuItem;
        private ToolStripMenuItem farenheightToolStripMenuItem;
        private ToolStripMenuItem updateIntervalToolStripMenuItem;
        private ToolStripMenuItem msToolStripMenuItem;
        private ToolStripMenuItem msToolStripMenuItem1;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem1;
        private ToolStripMenuItem sToolStripMenuItem2;
        private ToolStripMenuItem sToolStripMenuItem3;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundUpdater;
    }
}
