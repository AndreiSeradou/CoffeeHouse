using CoffeeHouse.Data.Interface;
using System;

namespace CoffeeHouse.Data.Entity.Human
{
    internal class Client : IHuman
    {
        public Client()
        {
            Random random = new Random();
            selectionChoose = random.Next(1, 2);
        }
        public string Name { get; set; }
        public IDish Choose { get; set; }
        public int selectionChoose { get; set; }

        public int GetRate()
        {
            return 1;
        }

    }
}
