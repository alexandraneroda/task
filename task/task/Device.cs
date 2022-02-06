using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    interface IDevice
    {
        string Name { get; set; }

        string Type { get; set; }

        string Price { get; set; }
        void AddDevice();
    }

    class Device : IDevice
    {
       

        public void AddDevice()
        {
           
        }
        
    }
}
