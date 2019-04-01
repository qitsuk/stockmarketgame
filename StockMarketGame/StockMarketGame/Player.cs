using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Player
    {
        public double balance { get; set; }
        public List<Company> portfolio { get; set; }

        public Player()
        {
            balance = 5000;
        }
    }
}
