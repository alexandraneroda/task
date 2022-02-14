using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public interface IDevice
    {
        int Number { get; } 
        string Name { get; }

        Types Type { get; set; }

        double Price { get; set; }

    }
}
