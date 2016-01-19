using Intrigue.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intrigue
{
    public partial class LoanRequest : Form
    {
        Patricians family;
        TheCast the_cast;
        TheState the_state;

        public LoanRequest(Patricians fam, TheCast cast, TheState state)
        {
            family = fam;
            the_cast = cast;
            the_state = state;

            InitializeComponent();

            moneyRadioGroup.SelectedIndex = 0;
            promiseRadioGroup.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //money
            int money = (int)moneyRadioGroup.Properties.Items[moneyRadioGroup.SelectedIndex].Value;
            the_cast.the_player.wealth += money;
            the_cast.the_player.debt += money;

            var promise = new Promises();
           
            //promise
            switch (promiseRadioGroup.SelectedIndex)
            {
                case 0:
                    promise.type_of_promise = Promise.Assasinate;
                    promise.turn_due = the_state.turn_number + 5;
                    break;
                case 1:
                    promise.type_of_promise = Promise.Insult;
                    promise.turn_due = the_state.turn_number + 5;
                    break;
                case 2:
                    promise.type_of_promise = Promise.RepayDouble;
                    promise.turn_due = the_state.turn_number + 14;
                    promise.amount_owed = money * 2;
                    break;
                case 3:
                    promise.type_of_promise = Promise.RepayTriple;
                    promise.turn_due = the_state.turn_number + 14;
                    promise.amount_owed = money * 3;
                    break;
                default:
                    return;
            }

            promise.promise_to = family.name;
            promise.promise_vs = family.name;
            promise.relationship_bonus = 10;


            the_cast.the_player.promises.Add(promise);

            //make a loan request
            //add promise

            //add money

        }
    }
}
