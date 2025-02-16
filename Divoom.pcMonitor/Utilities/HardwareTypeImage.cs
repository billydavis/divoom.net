using LibreHardwareMonitor.Hardware;

namespace pcMonitor.Utilities;

public class HardwareTypeImage
{
    private readonly IDictionary<HardwareType, Image> _images = new Dictionary<HardwareType, Image>();

    private HardwareTypeImage() { }

    public static HardwareTypeImage Instance { get; } = new HardwareTypeImage();

    public Image GetImage(HardwareType hardwareType)
    {
        if (_images.TryGetValue(hardwareType, out Image image))
            return image;


        switch (hardwareType)
        {
            case HardwareType.Cpu:
                image = EmbeddedResources.GetImage("cpu.png");
                break;
            case HardwareType.GpuNvidia:
                image = EmbeddedResources.GetImage("nvidia.png");
                break;
            case HardwareType.GpuAmd:
                image = EmbeddedResources.GetImage("amd.png");
                break;
            case HardwareType.GpuIntel:
                image = EmbeddedResources.GetImage("intel.png");
                break;
            case HardwareType.Storage:
                image = EmbeddedResources.GetImage("hdd.png");
                break;
            case HardwareType.Motherboard:
                image = EmbeddedResources.GetImage("mainboard.png");
                break;
            case HardwareType.SuperIO:
            case HardwareType.EmbeddedController:
                image = EmbeddedResources.GetImage("chip.png");
                break;
            case HardwareType.Memory:
                image = EmbeddedResources.GetImage("ram.png");
                break;
            case HardwareType.Network:
                image = EmbeddedResources.GetImage("nic.png");
                break;
            case HardwareType.Cooler:
                image = EmbeddedResources.GetImage("fan.png");
                break;
            case HardwareType.Psu:
                image = EmbeddedResources.GetImage("power-supply.png");
                break;
            case HardwareType.Battery:
                image = EmbeddedResources.GetImage("battery.png");
                break;
            default:
                image = new Bitmap(1, 1);
                break;
        }
        _images.Add(hardwareType, image);
        return image;
    }
}