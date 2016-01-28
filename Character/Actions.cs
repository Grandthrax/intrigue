using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intrigue.Character
{
    public class Relationships
    {
        public int opinion;

        public Relationships(int op = 0)
        {
            opinion = op;
        }
    }

    public enum ActionNameEnum
    {
        Thugs, Bribe, Orate
    };


    public class Actions
    {


        public int turn_number;
        public TribeName tribe;
        public ActionNameEnum action_name;
    }
}
