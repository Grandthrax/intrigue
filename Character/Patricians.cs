using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public class PatricianPair
    {
        public Patricians patrician1;
        public Patricians patrician2;

        public PatricianPair(Patricians p1, Patricians p2)
        {
            patrician1 = p1;
            patrician2 = p2;
        }

        public bool Any(Patricians p1, Patricians p2)
        {
            if ((p1 == patrician1 | p1 == patrician2) & (p2 == patrician1 | p2 == patrician2))
            {
                return true;
            }
            else
                return false;
        }

        public bool Contains(Patricians p1)
        {
            if (p1 == patrician2 | p1 == patrician1)
            {
                return true;
            }
            else
                return false;
        }

        public Patricians GetOther(Patricians p1)
        {
            if (p1 == patrician2)
            {
                return patrician1;
            }
            if (p1 == patrician1)
            {
                return patrician2;
            }

            else
                throw new Exception("That patrician isn't in list");
        }

    }

    public class Patricians
    {

        public int ego;
        public int sychophancy;
        public int temper;
        public int jelousy;

        public FamilyName name;
        public int fear;
        public List<int> relationship;
        public int wealth;
        Random everything_random;

        public Patricians(FamilyName Name, Random randomness)
        {
          
            fear = 0;
            everything_random = randomness;

            relationship = new List<int>();

            relationship.Add(0);

         /*   for (int i = 1; i < 100; i++ )
            {
                relationship.Add(everything_random.Next(-20, 20));
            }
            relationship[name.family_id] = 0;
            */
                
            wealth = everything_random.Next(10, 1000);
            name = Name;

            ego = everything_random.Next(0, 10);
            sychophancy = everything_random.Next(0, 10);
            temper = everything_random.Next(0, 10);
            jelousy = everything_random.Next(0, 10);
        }
    }

    
}
