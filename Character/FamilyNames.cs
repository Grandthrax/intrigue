using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public enum FamilyNames
    {
        Player, Cornelius, Marius
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
            family_id = (int)name - 1;
        }

    }

}
