using Intrigue.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue
{
    public static class Mechanics
    {

        public static bool StreetSmartCheck(Player player)
        {
            return (player.street_smarts > new Random().Next(0, 10));
        }

        public static bool ObservationRoll(Player player)
        {
            return (player.observation > new Random().Next(0, 10));
        }
        public static List<string> EnumToList()
    {
        return Enum.GetValues(typeof(FamilyNames))
.Cast<FamilyNames>()
.Select(v => v.ToString())
.ToList();
    }
    }
}
