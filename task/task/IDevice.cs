using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public interface IDevice
    {

        int Number { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        double Price { get; set; }


    }
}
