using LibreHardwareMonitor.Hardware;

namespace pcMonitor.Utilities;

public class HardwareNode : Node
{
    private readonly UnitManager _unitManager;
    private readonly List<TypeNode> _typeNodes = new List<TypeNode>();

    public IHardware Hardware { get; }

    public HardwareNode(IHardware hardware, UnitManager unitManager)
    {
        _unitManager = unitManager;
        Hardware = hardware;
        Image = HardwareTypeImage.Instance.GetImage(hardware.HardwareType);

        foreach(var sensorType in Enum.GetValues(typeof(SensorType)))
            _typeNodes.Add(new TypeNode((SensorType)sensorType, hardware.Identifier));

        foreach (ISensor sensor in hardware.Sensors)
            SensorAdded(sensor);

        hardware.SensorAdded += SensorAdded;
        hardware.SensorRemoved += SensorRemoved;
    }

    public bool IsGpu => Hardware.HardwareType is HardwareType.GpuNvidia or HardwareType.GpuAmd or HardwareType.GpuIntel;

    public override string Text
    {
        get => Hardware.Name;
        set => Hardware.Name = value;
    }

    private void InsertSorted(Node node, ISensor sensor)
    {
        int i = 0;
        while (i < node.Nodes.Count && ((SensorNode)node.Nodes[i]).Sensor.Index < sensor.Index)
            i++;
        
        SensorNode sensorNode = new SensorNode(sensor, _unitManager);
        // sensorNode.PlotSelectionChanged += SensorPlotSelectionChanged;
        node.Nodes.Insert(i, sensorNode);
    }

    public SensorNode? First(SensorType type)
    {
        var typeNode = _typeNodes.FirstOrDefault(n => n.SensorType == type);
        var first = typeNode?.Nodes.FirstOrDefault();

        // Console.WriteLine($@"{Text} - First: {first?.Text} - {(first != null ? "FOUND" : "Not Found")}");
        return (SensorNode?)first;
    }

    public SensorNode? FindSensorNode(string searchText, SensorType type)
    {
        foreach (var sensor in Hardware.Sensors)
        {
            if (sensor.SensorType != type) continue;
            if (!sensor.Name.Equals(searchText)) continue;

            // Console.WriteLine($@"{Text} - FindSensorNode: {sensor.Name} - FOUND");
            return new SensorNode(sensor, _unitManager);
        }

        // Console.WriteLine($@"{Text} - FindSensorNode: {searchText} - Not Found");
        return null;

    }

    private void UpdateNode(TypeNode node)
    {
        if (node.Nodes.Count > 0)
        {
            if (!Nodes.Contains(node))
            {
                int i = 0;
                while (i < Nodes.Count && ((TypeNode)Nodes[i]).SensorType < node.SensorType)
                    i++;

                Nodes.Insert(i, node);
            }
        }
        else
        {
            if (Nodes.Contains(node))
                Nodes.Remove(node);
        }
    }

    private void SensorAdded(ISensor sensor)
    {
        foreach (TypeNode typeNode in _typeNodes)
        {
            if (typeNode.SensorType == sensor.SensorType)
            {
                InsertSorted(typeNode, sensor);
                UpdateNode(typeNode);
            }
        }
    }

    private void SensorRemoved(ISensor sensor)
    {
        foreach (TypeNode typeNode in _typeNodes)
        {
            if (typeNode.SensorType == sensor.SensorType)
            {
                SensorNode sensorNode = null;
                foreach (Node node in typeNode.Nodes)
                {
                    if (node is SensorNode n && n.Sensor == sensor)
                        sensorNode = n;
                }
                if (sensorNode != null)
                {
                    typeNode.Nodes.Remove(sensorNode);
                    UpdateNode(typeNode);
                }
            }
        }
    }
}