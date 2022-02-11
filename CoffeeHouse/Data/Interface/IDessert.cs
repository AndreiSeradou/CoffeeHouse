using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Data.Interface
{
    internal interface IDessert
    {
        string Name { get; set; }
        int Count { get; set; }
        int PeriodCooking { get; set; }
    }
}
