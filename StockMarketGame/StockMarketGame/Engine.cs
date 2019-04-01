using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StockMarketGame
{
    public class Engine
    {
        NameGen nameGen;
        List<Company> companies;
        private Random rand;

        public Engine()
        {
            nameGen = new NameGen();
            companies = nameGen.generateCompanyNames();
            
            foreach (Company c in companies)
            {
                c.price = setInitialPrice();
                c.available = setInitialAvailable();
            }
        }

        public double setInitialPrice()
        {
            rand = new Random();
            return Math.Round(rand.NextDouble(), 2);
        }

        public int setInitialAvailable()
        {
            rand = new Random();
            return rand.Next(0, 1000);
        }
    }
}
