using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    interface IDevice
    {
        void Device();
    }

    class Device : IDevice
    {
        string Name;

        string Type;

        string Price;
        void IDevice.Device()
        {
            this.name = Name;
            this.type = Type;
            this.price = Price;
        }
         public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string type
        {
            get { return Type; }
            set { Type = value; }
        }

        public string price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}
