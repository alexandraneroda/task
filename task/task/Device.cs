using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public interface IDevice
    {
        string Name { get; set;  }

        string Type { get; set; }

        double Price { get; set; }

    }

    public class Device : IDevice
    {
        private string name = string.Empty;

        public Device(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public Types Type { get; set; } = Types.None;

        public double Price { get; set; }

        public enum Types
        {
            None = 0,
            Printer = 1,
            Camera = 2,
            PLC = 3,
        }
    }

    public class Camera : Device
    {
        public Camera(string name) : base(name)
        {
            Type = Types.Camera;
        }
    }
}