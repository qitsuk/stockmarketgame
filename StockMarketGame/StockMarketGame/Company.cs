using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Company
    {
        public string name { get; set; }
        public double price { get; set; }
        public int available { get; set; }
        public char size { get; set; }

        public Company(string name)
        {
            this.name = name;
        }
    }
}
