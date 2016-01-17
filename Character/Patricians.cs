using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public class Patricians
    {
        public int id;

        public int ego;
        public int sychophancy;
        public int temper;
        public int jelousy;

        public FamilyNames name;
        public int fear;
        public List<int> relationship;
        public int wealth;
        Random everything_random;

        public Patricians(FamilyNames Name, Random randomness, int Id)
        {
            id = Id;
            fear = 0;
            everything_random = randomness;

            relationship = new List<int>();

            relationship.Add(0);

            for (int i = 1; i < 100; i++ )
            {
                relationship.Add(everything_random.Next(-20, 20));
            }
            relationship[id] = 0;

                
            wealth = everything_random.Next(10, 1000);
            name = Name;

            ego = everything_random.Next(0, 10);
            sychophancy = everything_random.Next(0, 10);
            temper = everything_random.Next(0, 10);
            jelousy = everything_random.Next(0, 10);
        }
    }

    
}
