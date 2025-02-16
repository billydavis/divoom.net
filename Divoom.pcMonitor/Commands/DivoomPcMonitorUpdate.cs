using System.Text.Json;
using Divoom;
using Divoom.Models;
using pcMonitor.Utilities;

namespace pcMonitor.Commands;

public class DivoomPcMonitorUpdate
{
    public SensorNode? CpuLoadSensorNode { get; set; }

    public SensorNode? CpuTempSensorNode { get; set; }

    public SensorNode? GpuLoadSensorNode { get; set; }

    public SensorNode? GpuTempSensorNode { get; set; }
    
    public SensorNode? RamUseSensorNode { get; set; }

    public SensorNode? HddTempSensorNode { get; set; }


    
    public string CpuLoad => CpuLoadSensorNode?.Value ?? "n/a";

    public string CpuTemp => CpuTempSensorNode?.Value ?? "n/a";

    public string GpuLoad => GpuLoadSensorNode?.Value ?? "n/a";
    public string GpuTemp => GpuTempSensorNode?.Value ?? "n/a";

    public string RamUse => RamUseSensorNode?.Value ?? "n/a";

    public string HddTemp => HddTempSensorNode?.Value ?? "n/a";


    public bool SendToDevice(Device device, int? screen)
    {
        var command = new PcMonitorCommand
        {
            ScreenList = new List<PcMonitorScreenData>
            {
                new PcMonitorScreenData
                {
                    LcdId = screen,
                    DisplayData = new List<string>
                    {
                        CpuLoad,
                        GpuLoad,
                        CpuTemp,
                        GpuTemp,
                        RamUse,
                        HddTemp
                    }
                }
            }
        };
        
        var result = device.SendCommand<CommandResult>(JsonSerializer.Serialize(command)).Result;

        return result?.ErrorCode == 0;
    }

    public override string ToString()
    {
        return $"cpu: {CpuLoad}/{CpuTemp} gpu: {GpuLoad}/{GpuTemp} ram: {RamUse} hdd: {HddTemp}";
    }
}