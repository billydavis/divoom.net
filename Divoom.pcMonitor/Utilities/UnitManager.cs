namespace pcMonitor.Utilities;

public enum TemperatureUnit
{
    Celsius = 0,
    Fahrenheit = 1
}

public class UnitManager
{
    public TemperatureUnit TemperatureUnit { get; set; } = TemperatureUnit.Celsius;

    public bool ShowDecimal { get; set; }

    public static float? CelsiusToFahrenheit(float? valueInCelsius)
    {
        return valueInCelsius * 1.8f + 32;
    }
}