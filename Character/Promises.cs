using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Character
{
    public class Promises
    {
        public FamilyNames promise_to;
        public FamilyNames promise_vs;
        public Promise type_of_promise;
        public int turn_due;
        public int relationship_bonus;

        public string promise_for
        {
            get
            {
                return promise_to.ToString();
            }
        }
        public string promise_against
        {
            get
            {
                return promise_vs.ToString();
            }
        }
        public string type_promise
        {
            get
            {
                return type_of_promise.ToString();
            }
        }
        public string due
        {
            get
            {
                return turn_due.ToString();
            }
        }
    }
}
