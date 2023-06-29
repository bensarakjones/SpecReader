using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using OpenHardwareMonitor.Hardware;
using System.Reflection.Emit;
using System.Threading;

namespace speccy2
{
    public partial class Form1 : Form
    {
        private Computer computer;
        private Thread temperatureThread;


        public Form1()
        {
            InitializeComponent();
            InitializeOpenHardwareMonitor();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Specreader, Please ensure it is run as administrator for accurate temperature readings.");
            UpdateTemperatureLabels(computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.CPU));
            UpdateGPUTemperatureLabels(computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.GpuNvidia || h.HardwareType == HardwareType.GpuAti));
            InitializeTemperatureThread();



            // Retrieve the processor details
            ManagementObjectSearcher processorSearcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject processor in processorSearcher.Get())
            {
                cpulabel.Text = string.Format("Processor Name: {0}\nProcessor Manufacturer: {1}\nProcessor Architecture: {2}\nProcessor Clock Speed: {3} MHz", processor["Name"], processor["Manufacturer"], processor["Architecture"], processor["MaxClockSpeed"]);

            }

            // Retrieve the operating system details
            ManagementObjectSearcher osSearcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject os in osSearcher.Get())
            {
                oslabel.Text = string.Format("Operating System Name: {0}\nOperating System Version: {1}\nOperating System Architecture: {2}", os["Caption"], os["Version"], os["OSArchitecture"]);
            }

            // Retrieve the GPU details
            ManagementObjectSearcher gpuSearcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject gpu in gpuSearcher.Get())
            {
                string gpuName = gpu["Name"].ToString();
                string gpuManufacturer = gpu["AdapterCompatibility"].ToString();
                long gpuMemoryBytes = Convert.ToInt64(gpu["AdapterRAM"]);
                double gpuMemoryGB = Math.Round(Convert.ToDouble(gpuMemoryBytes) / (1024 * 1024 * 1024), 2);

                gpulabel.Text = $"GPU Name: {gpuName}\nGPU Manufacturer: {gpuManufacturer}\nGPU Memory: {gpuMemoryGB * 2} GB";
            }

            // Retrieve the motherboard details
            ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
            foreach (ManagementObject motherboard in motherboardSearcher.Get())
            {
                mobolabel.Text = string.Format("Motherboard Manufacturer: {0}\nMotherboard Model: {1}\nMotherboard Serial Number: {2}", motherboard["Manufacturer"], motherboard["Product"], motherboard["SerialNumber"]);
            }

            // Retrieve the storage details
            ManagementObjectSearcher diskSearcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            foreach (ManagementObject disk in diskSearcher.Get())
            {
                storagelabel.Text = string.Format("Drive Name: {0}\nDrive Model: {1}\nDrive Capacity: {2} GB", disk["Caption"], disk["Model"], Math.Round(Convert.ToDouble(disk["Size"]) / (1024 * 1024 * 1024), 2));
            }

            // Retrieve the RAM details
            ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            long totalRam = 0;
            int ramModuleCount = 0;
            StringBuilder ramDetails = new StringBuilder();

            foreach (ManagementObject ram in ramSearcher.Get())
            {
                long ramSize = Convert.ToInt64(ram["Capacity"]);
                double ramSizeGB = Math.Round(Convert.ToDouble(ramSize) / (1024 * 1024 * 1024), 2);
                string ramPartNumber = ram["PartNumber"].ToString();
                string ramClockSpeed = ram["ConfiguredClockSpeed"].ToString();

                totalRam += ramSize;
                ramModuleCount++;

                ramDetails.AppendLine($"RAM Module {ramModuleCount}: {ramSizeGB} GB ({ramPartNumber}), Clock Speed: {ramClockSpeed} MHz");
            }

            double totalRamGB = Math.Round(Convert.ToDouble(totalRam) / (1024 * 1024 * 1024), 2);

            ramlabel.Text = $"Total RAM: {totalRamGB} GB\nRAM Modules: {ramModuleCount}\n\n{ramDetails.ToString()}";

            // Retrieve the audio device details
            ManagementObjectSearcher audioSearcher = new ManagementObjectSearcher("select * from Win32_SoundDevice");
            foreach (ManagementObject audioDevice in audioSearcher.Get())
            {
                string audioName = audioDevice["Name"].ToString();
                string audioManufacturer = audioDevice["Manufacturer"].ToString();
                string audioStatus = audioDevice["Status"].ToString();

                audiolabel.Text = $"Audio Device Name: {audioName}\nAudio Device Manufacturer: {audioManufacturer}\nAudio Device Status: {audioStatus}";
            }
        }

        private void InitializeOpenHardwareMonitor()
        {
            computer = new Computer();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;
            computer.MainboardEnabled = true;
            computer.HDDEnabled = true;
            computer.Open();

            // Add event handler to update temperature when it changes
            computer.HardwareAdded += UpdateTemperatureLabels;
            computer.HardwareRemoved += UpdateTemperatureLabels;
        }


        private void InitializeTemperatureThread()
        {
            temperatureThread = new Thread(UpdateTemperatureThread);
            temperatureThread.IsBackground = true;
            temperatureThread.Start();
        }

        private void UpdateTemperatureThread()
        {
            while (true)
            {
                
                    UpdateTemperatureLabels(computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.CPU));
                    UpdateGPUTemperatureLabels(computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.GpuNvidia || h.HardwareType == HardwareType.GpuAti));
                
                Thread.Sleep(1000); // Update every second
            }
        }
        private void UpdateTemperatureLabels(IHardware hardware)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => UpdateTemperatureLabels(hardware)));
                return;
            }

            hardware.Update();

            if (hardware.HardwareType == HardwareType.CPU)
            {
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        cputemp.Text = $"CPU Temperature: {sensor.Value}°C";
                        cputemp.ForeColor = (sensor.Value > 75) ? Color.Red : Color.Green;
                        break;
                    }
                }
            }
        }

        private void UpdateGPUTemperatureLabels(IHardware hardware)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => UpdateGPUTemperatureLabels(hardware)));
                return;
            }

            if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
            {
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        gputemp.Text = $"GPU Temperature: {sensor.Value}°C";
                        gputemp.ForeColor = (sensor.Value > 75) ? Color.Red : Color.Green;
                        break;
                    }
                }
            }
        }



    }
}
