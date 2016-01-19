using Intrigue.Character;
using Intrigue.Text;
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
    public partial class PatricianInteract : Form
    {
        Patricians family;
        TheCast cast;
        TheState the_state;

        
        public PatricianInteract(Patricians Family, TheCast the_cast, TheState state)
        {
            family = Family;
            InitializeComponent();
            PatricianNamelabel.Text = family.name.family_name_string;
            feelingLabel.Text = "";
            feelingLabel.AutoSize = true;
            cast = the_cast;
            the_state = state;

            this.Text = family.name.family_name_string + "'s Estate";

            PlayerPerception();
        }

        private void PlayerPerception()
        {
            int comparison_metric = 10 - cast.the_player.observation;

            
            feelingLabel.Text = ViewedText.patrician_openingObservation();

            if(comparison_metric < family.ego)
            {

                feelingLabel.Text += ViewedText.patrician_ego(family.ego);
            }

            if (comparison_metric < family.temper)
            {
                feelingLabel.Text += ViewedText.patrician_temper(family.temper);
 
            }

            feelingLabel.AutoSize = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int relationship_affect = (cast.the_player.oratory - 5) + (family.ego - 5);

            if(relationship_affect < -1)
            {
                int react_badly = new Random().Next(0, 10);
                if(react_badly < family.temper)
                {
                    relationship_affect = relationship_affect * 3;
                    family.relationship[0] = family.relationship[0] + relationship_affect;
                    MessageBox.Show(ViewedText.patrician_flatteryThrowsOut());
                    this.Close();
                    return;
                }
                if(Mechanics.ObservationRoll(cast.the_player))
                {
                    MessageBox.Show(ViewedText.patrician_flatteryFrows());
                }
                else
                {
                    MessageBox.Show(ViewedText.patrician_flatteryCannotTell());
                }
                
            }
            else if (relationship_affect > 1)
            {
                if (Mechanics.ObservationRoll(cast.the_player))
                {
                    MessageBox.Show(ViewedText.patrician_flatterySmiles());
                }
                else
                {
                    MessageBox.Show(ViewedText.patrician_flatteryCannotTell());
                }
            }
            else
            {
                if (Mechanics.ObservationRoll(cast.the_player))
                {
                    MessageBox.Show(ViewedText.patrician_flatteryDoesntCare());
                }
                else
                {
                    MessageBox.Show(ViewedText.patrician_flatteryCannotTell());
                }
            }

            
            family.relationship[0] = family.relationship[0] + relationship_affect;

            button1.Enabled = false;
        }

        

        private void feelingLabel_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoanRequest open = new LoanRequest(family, cast, the_state);
            open.ShowDialog();

            askForLoanButton.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Conversation_Box open = new Conversation_Box(family, cast);
            open.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*var prom = new Promises();
            prom.promise_to = family.name;
            prom.relationship_bonus = 10;
            prom.turn_due = 3;
            prom.type_of_promise = Promise.Insult;
            player.promises.Add(prom);*/

            Promise_Interaction open = new Promise_Interaction(family, cast, the_state);
            open.ShowDialog();

          
            button5.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
