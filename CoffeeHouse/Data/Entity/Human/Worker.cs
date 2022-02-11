using CoffeeHouse.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Data.Entity.Human
{
    internal class Worker : IHuman
    {
        public string Name { get; set; }
        public int PeriodCooking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
