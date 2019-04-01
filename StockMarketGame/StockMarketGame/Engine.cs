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
        public List<Company> companies;
        private Random rand;
        public Player player;

        public Engine()
        {
            nameGen = new NameGen();
            companies = nameGen.generateCompanyNames();
            rand = new Random();
            
            foreach (Company c in companies)
            {
                c.size = setCompanySize();
                c.available = setInitialAvailable(c.size);
                c.price = setInitialPrice(c.size);
            }

            player = new Player();
        }

        public double setInitialPrice(char size)
        {
            double result = 0;
            switch (size)
            {
                case 'S':
                    result = Math.Round(rand.NextDouble(), 2) *2;
                    break;
                case 'M':
                    result = Math.Round(rand.NextDouble(), 2) * 3;
                    break;
                case 'L':
                    result = Math.Round(rand.NextDouble(), 2) * 4;
                    break;
                default:
                    break;

            }
            return result;
        }

        public int setInitialAvailable(char size)
        {
            int result = 0;
            switch (size)
            {
                case 'S':
                    result = rand.Next(0, 500);
                    break;
                case 'M':
                    result = rand.Next(250, 750);
                    break;
                case 'L':
                    result = rand.Next(500, 2500);
                    break;
                default:
                    break;
            }
            return result;
        }

        public char setCompanySize()
        {
            char result = 'n';
            int random = rand.Next(0, 33);
            if (random <= 11)
            {
                result = 'S';
            }
            else if (random > 11 && random <= 22)
            {
                result = 'M';
            }
            else if (random > 22)
            {
                result = 'L';
            }
            return result;
        }
    }
}
