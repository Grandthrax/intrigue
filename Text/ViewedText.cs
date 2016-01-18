using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrigue.Text
{
    public static class ViewedText
    {


        //civil unrest
        public static string civilunrest_lowstreetsmart() {
            return "Something is afoot, there are murmerings in the street but when you seek for an answer, you find only furtive glances and vague warnings.";
        }
        public static string civilunrest_highstreetsmart(string family_name1, string family_name2)
        {
            return "You hear rumours that the " + family_name1 + " families thugs have attacked some the " + family_name2 + " families slaves. This could be civil war!";
        }

        //player relationships due to promises
        public static string relationship_deteriated(string name)
        {
            return "Something is afoot, there are murmerings in the street but when you seek for an answer, you find only furtive glances and vague warnings.";
        }

        //game over
        #region GAME OVER
        //assasinated
        public static string player_assasinated()
        {
            return "You have been assasinated!";
        }
        //adopted
        public static string player_adopted(string adopter)
        {
            return "The " + adopter + " family adopts you!";
        }
        //ellection lost
        public static string player_loseselection()
        {
            return "You lost the election";
        }
        //civil war breaks out
        public static string civil_war()
        {
            return "A civil war has broken out between two of the major families. You put your aims of high office aside while you fight for yourself";
        }

        #endregion

        #region Patrician Interaction
        //Basics
        public static string patrician_openingObservation()
        {
            return "You observe the patrician carefully and notice";
        }

        //patricians ego
        public static string patrician_ego(int ego)
        {
            if (ego >= 9)
            {
                return " he thinks he is Jupiter himself the pompeous fat arse.";
            }
            else if (ego >= 6)
            {
                return " he strides around like he's a king.";
            }
            else if (ego >= 4)
            {
                return " he carries himself with a quiet dignity and confidence.";
            }
            else if (ego >= 1)
            {
                return " a humble man of Rome.";
            }
            else if (ego >= 0)
            {
                return " he scurries around like he is afraid the slaves will bark at him.";
            }
            return "";
        }

        //temper
        public static string patrician_temper(int temper)
        {
            if (temper >= 9)
            {
                return " a slave lies kicked to death in the corner. This man has temper problems to rival Mars himself.";
            }
            else if (temper >= 6)
            {
                return " his temple throbs and he flushes red in the face from time to time.";
            }
            else if (temper >= 4)
            {
                return " at most times he seems even tempered but you guess he is not one to cross.";
            }
            else if (temper >= 1)
            {
                return " this man heart is cool and calm. He gazes on all with a fair eye.";
            }
            else if (temper >= 0)
            {
                return " as meak and mild as a little kitten.";
            }
            else return "";
        }

        //flattery
        public static string patrician_flatteryCannotTell()
        {
            return "You cannot tell what the patrician thinks of your flattery";
        }
        public static string patrician_flatteryThrowsOut()
        {
            return "The Patrician goes mad and throws you out for your impudence";
        }
        public static string patrician_flatteryFrows()
        {
            return "The Patrician frowns slightly after hearing your flatery";
        }
        public static string patrician_flatterySmiles()
        {
            return "The Patrician smiles slightly after hearing your flatery";
        }
        public static string patrician_flatteryDoesntCare()
        {
            return "The Patrician doesn't seem to care";
        }


        //Opinion of other familes
        public static string patrician_OpinionOpening()
        {
            return "You ask about the other families? Well OK. Here me out.";
        }
        public static string patrician_OpinionOf(string target_name, int opinion)
        {
            return " I think of the " + target_name + " family " + opinion + ".";
        }
        //Opinion of player
        public static string patrician_OpinionOfPlayer(int opinion)
        {
            return "I think of you " + opinion + ".";
        }
        #endregion

        #region New Character Descriptions
        public static string newCharacter_exSlave()
        {
            return "You have been freed by the...";
        }
        public static string newCharacter_gladiator()
        {
            return "After great fame as a gladiator...";
        }
        public static string newCharacter_exPatrician()
        {
            return "The last in the line of a long and noble line...";
        }
        public static string newCharacter_ex_Criminal()
        {
            return "You have spent your life working for the criminal....";
        }


        #endregion


    }
}
