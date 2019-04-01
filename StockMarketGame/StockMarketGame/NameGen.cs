using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class NameGen
    {
        private List<string> namePrefix1 = new List<string> { "The", "My", "I,", "Top", "Pro", "Best", "Super", "Ultra", "All", "Cyber", "Simply", "Free", "1st", "Meta", "Metro", "Urban",
                                                              "Head", "Hit", "Front", "Tehcno", "VIP", "Rush" };
        private List<string> namePrefix2 = new List<string>{"House", "Central", "Point", "Home", "Place", "Garden", "Site", "Spot", "Park", "Dome", "Bay", "Web", "Net", "Cave", "Base",
                                                            "Heaven", "Portal", "World", "Camp", "Network", "County", "Street", "City", "Alley", "Depot", "Valley" };
        private List<string> nameSuffix = new List<string>{ "Ltd.", "S.A.", "A.G.", "N.V.", "Ltee", "B.V.", "GmbH", "LLC", "S.I.A.", "Inc.", "Corp.", "Pte. Ltd."};

        private Random rand;

        public List<Company> generateCompanyNames()
        {
            List<Company> companyNames = new List<Company>();
            rand = new Random();
            for (int i = 0; i < 10; i++) { 
                string part1 = namePrefix1[rand.Next(0, namePrefix1.Count)];
                string part2 = namePrefix2[rand.Next(0, namePrefix2.Count)];
                string part3 = nameSuffix[rand.Next(0, nameSuffix.Count)];
                companyNames.Add(new Company(part1 + " " + part2 + " " + part3));
            }
            return companyNames;
        }
    }
}
