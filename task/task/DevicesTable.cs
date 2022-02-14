using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class DevicesTable
    {
        public List<IDevice> Devices { get; set; } = new List<IDevice>();
        string[] ArrStr;// объявляем массив
        int size = 2;
        public DevicesTable()
        {
<<<<<<< Updated upstream
            Devices.Add(new Device("Panasonic") { Type = Device.Types.Camera, Price = 10 });
            Devices.Add(new Device("Sooner") { Type = Device.Types.Printer, Price = 20 });
            Devices.Add(new Device("Dream") { Type = Device.Types.Camera, Price = 310 });
=======
            //Devices.Add(new Device("Panasonic") { Type = Types.Camera, Price = 10 });
           // Devices.Add(new Device("Sooner") { Type = Types.Printer, Price = 20 });
            //Devices.Add(new Device("Dream") { Type = Types.Camera, Price = 310 });
>>>>>>> Stashed changes
        }
        
        public void Add(IDevice device)
        {
            Devices.Add(device);
        }

        public void Remove(IDevice device)
        {
            Devices.Remove(device);
        }

        public void Remove(int index)
        {
            Devices.RemoveAt(index);
        }
    }
}
