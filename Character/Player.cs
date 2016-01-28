using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public enum OppositionNames
    {
        Cato, Curio, Lucius
    };

    public class Opposition
    {
        public string name;
        public OppositionNames name_en;


        public List<Actions> turns_actions;
        //variables
        public int wealth;
        Random everything_random;

        public Opposition(OppositionNames en)
        {

            name_en = en;
            name = en.ToString();
            wealth = 0;
        

        }
    }
    public class Player
    {
        public string name;

        

        public List<Actions> turns_actions;
        public List<Promises> promises;
        public List<Promises> old_promises;

        public int id = 0;

        //Attributes
        public int oratory;
        public int fighting;
        public int street_smarts;
        public int authority;
        public int observation;
        public int acumen;

        //variables
        public int wealth;
        public int debt;
            
        
        Random everything_random;

            public Player()
            {
                promises = new List<Promises>();
                old_promises = new List<Promises>();
                wealth = 0;
                debt = 0;
                turns_actions = new List<Actions>();
        
            }
    }
}
