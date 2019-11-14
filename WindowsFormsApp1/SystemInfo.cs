using OpenHardwareMonitor.Hardware;
using System;

namespace ArduinoInterface
{
    class SystemInfo
    {
        public SystemInfo()
        {

        }
        
        UpdateVisitor updateVisitor = new UpdateVisitor();
        Computer computer = new Computer();

        public string GetCoreTemp()
        {
            string error = "error - No data found";
            string s = "";
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            Console.WriteLine(computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "\r");
                            //fix new line

                            s += (computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "°C      ");
                            //return s;
                        }

                    }
                }
            }
            computer.Close();
            if (s.Length == 0)
            {
                Console.WriteLine(error);
                return error;
            }
            return s;
        }

        public string GetCoreLoad()
        {
            string cpuLoad = "";
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            Console.WriteLine(computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "\r");
                            //fix new line

                            cpuLoad += (computer.Hardware[i].Sensors[j].Name + ": " + computer.Hardware[i].Sensors[j].Value.ToString() + "%       ");
                            //return s;
                        }

                    }
                }
            }
            computer.Close();
            return cpuLoad;
        }
    }
}
