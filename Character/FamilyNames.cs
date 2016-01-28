using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public enum FamilyNames
    {
        Player, Cornelius, Marius,  Julia, Atilia
    };
    public enum Promise
    {
        Insult, Assasinate, RepayDouble, RepayTriple
    };

    public class FamilyName
    {
        public FamilyNames family_name_enum;
        public string family_name_string;
        public int family_id;

        public FamilyName(FamilyNames name)
        {
            family_name_enum = name;
            family_name_string = name.ToString();
            family_id = (int)name;
        }

    }

    public class TheCast
    {
        public Dictionary<PatricianPair, Relationships> the_relationships;

        public List<Patricians> the_patricians;
        public List<Tribes> the_tribes;

        public List<Opposition> the_opposition;

        public Player the_player;

        public TheCast()
        {
            the_relationships = new Dictionary<PatricianPair, Relationships>();
            the_patricians = new List<Patricians>();
            the_player = new Player();
            the_tribes = new List<Tribes>();
            the_opposition = new List<Opposition>();
        }
    }

}
