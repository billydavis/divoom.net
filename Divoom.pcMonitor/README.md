# Divoom.pcMonitor

Divoom.pcMonitor is a .NET 8 application designed to monitor the temperature sensors, 
fan speeds, voltages, load and clock speeds of your computer and send that data to your 
Divoom device.

This is my attempt to update of the [Divoom.pcMonitor](https://github.com/DivoomDevelop/DivoomPCMonitorTool) project 
by [Divoom Develop](https://github.com/DivoomDevelop). I felt that this would be a good demonstration of 
the Divoom.net api in action. The original project used libraries from the [Open Hardware Monitor](https://openhardwaremonitor.org/)
that seemed to be somewhat out of support. I have replaced the Open Hardware Monitor libraries with the
[LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) libraries. You'll will
notice that this project is a fusion of the original Divoom.pcMonitor and the LibreHardwareMonitor project.
However, it does not have as much fuctionality as the LibreHardwareMonitor project, but it does have all the 
functionality of the original Divoom.pcMonitor project.

This project will request that you run the application as an administrator. This is because without admin rights,
not all sensors will be available. The app will still run without admin rights, but you may not have access to all 
sensor data.


**Use at Your Own Risk**

This software is provided "as is", without warranty of any kind, express or implied, including but not 
limited to the warranties of merchantability, fitness for a particular purpose, and noninfringement. In 
no event shall the authors or copyright holders be liable for any claim, damages, or other liability, 
whether in an action of contract, tort, or otherwise, arising from, out of, or in connection with the 
software or the use or other dealings in the software.

## Features

- Monitor the temperature sensors, fan speeds, voltages, load and clock speeds of your computer
- Send sensor data to your Divoom device.


## Requirements

- .NET 8 SDK
- A compatible Divoom device

## Supported Devices
This has been tested on the Divoom Pixoo64 and Timesgate devices . It should work on any Divoom device that 
is supported by the Divoom.net api.


## Installation

1. Clone the repository:
2. Navigate to the project directory:
3. Build the project:
## Usage

1. Run the application:
2. Follow the on-screen instructions to connect to your Divoom device.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, please open an issue on GitHub.
