using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task
{
    

    public class Device : IDevice
    {
        private string name = string.Empty;
        static int nextId;
     

        public int deviceId { get; private set; }
        public Device(string name)
        {
            this.name = name;
            this.deviceId = deviceId; //автоопределение id
            deviceId = Interlocked.Increment(ref nextId);
        }
        public string Name { get { return name; } }

        public Types Type { get; set; } = Types.None;

        public double Price { get; set; }

        public int Number { get { return deviceId; } }
       
    }

    public class Camera : Device
    {
        public Camera(string name) : base(name)
        {
            Type = Types.Camera;
        }
    }
}