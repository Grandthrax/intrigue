using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public enum TribeNameEnum
    {
        Palatina, Collina, Suburra, Esquilana, 
    };

    public class TribeName
    {
        public TribeNameEnum tribe_name_enum;
        public string tribe_name_string;
        public int tribe_id;

        public TribeName(TribeNameEnum name)
        {
            tribe_name_enum = name;
            tribe_name_string = name.ToString();
            tribe_id = (int)name;
        }
    }


    public class Tribes
    {

        //A description for display when clicking on the district. Possibly put in an observation check later.
        public string description;
        //Each district is loyal to one of the four houses, and more likely to be influenced by their favours.
        // public Tribe_Palatina_House_Loyalty Familynames
        public int patrician_population;
        public int equite_population;
        public int plebisnobilis_population;
        public int pleb_population;
        public int proletarii_population;

        //The total population who can vote, for determining election outcomes.
        public int proposal_support;
        public int proposal_oppose;


        public TribeName name;
        private Random everything_random;
        public Dictionary<OppositionNames,int> relationships;
        public int relation_with_player;


        public Tribes(TribeName Name)
        {

            name = Name;
            everything_random = new Random();
            relation_with_player = 0;
            relationships = new Dictionary<OppositionNames, int>();
        }


    }
}
