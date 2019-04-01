using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Company
    {
        string name;
        double price { get; set; }
        int available { get; set; }

        public Company(string name)
        {
            this.name = name;
        }
    }
}
