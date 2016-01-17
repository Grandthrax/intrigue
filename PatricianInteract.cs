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
    public partial class PatricianInteract : Form
    {
        Patricians family;
        Player player;

        
        public PatricianInteract(Patricians Family, Player the_player)
        {
            family = Family;
            InitializeComponent();
            PatricianNamelabel.Text = family.name.ToString();
            feelingLabel.Text = "";
            feelingLabel.AutoSize = true;
            player = the_player;

            PlayerPerception();
        }

        private void PlayerPerception()
        {
            int comparison_metric = 10 - player.observation;

            
            feelingLabel.Text = "You observe the patrician carefully and notice";

            if(comparison_metric < family.ego)
            {
                if (family.ego >= 9)
                {
                    feelingLabel.Text = feelingLabel.Text + " he thinks he is Jupiter himself the pompeous fat arse.";
                }
                else if (family.ego >= 6)
                {
                    feelingLabel.Text = feelingLabel.Text + " he strides around like he's a king.";
                }
                else if (family.ego >= 4)
                {
                    feelingLabel.Text = feelingLabel.Text + " he carries himself with a quiet dignity and confidence.";
                }
                else if (family.ego >= 1)
                {
                    feelingLabel.Text = feelingLabel.Text + " a humble man of Rome.";
                }
                else if (family.ego >= 0)
                {
                    feelingLabel.Text = feelingLabel.Text + " he scurries around like he is afraid the slaves will bark at him.";
                }
                
            }

            if (comparison_metric < family.temper)
            {
                if (family.temper >= 9)
                {
                    feelingLabel.Text = feelingLabel.Text + " a slave lies kicked to death in the corner. This man has temper problems to rival Mars himself.";
                }
                else if (family.temper >= 6)
                {
                    feelingLabel.Text = feelingLabel.Text + " his temple throbs and he flushes red in the face from time to time.";
                }
                else if (family.temper >= 4)
                {
                    feelingLabel.Text = feelingLabel.Text + " at most times he seems even tempered but you guess he is not one to cross.";
                }
                else if (family.temper >= 1)
                {
                    feelingLabel.Text = feelingLabel.Text + " this man heart is cool and calm. He gazes on all with a fair eye.";
                }
                else if (family.temper >= 0)
                {
                    feelingLabel.Text = feelingLabel.Text + " as meak and mild as a little kitten.";
                }
                feelingLabel.AutoSize = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int relationship_affect = (player.oratory - 5) + (family.ego - 5);

            if(relationship_affect < -1)
            {
                int react_badly = new Random().Next(0, 10);
                if(react_badly < family.temper)
                {
                    relationship_affect = relationship_affect * 3;
                    family.relationship[0] = family.relationship[0] + relationship_affect;
                    System.Windows.Forms.MessageBox.Show("The Patrician goes mad and throws you out for your impudence");
                    this.Close();
                    return;
                }
                if(Mechanics.ObservationRoll(player))
                {
                    System.Windows.Forms.MessageBox.Show("The Patrician frowns slightly after hearing your flatery");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You cannot tell what the patrician thinks of your flattery");
                }
                
            }
            else if (relationship_affect > 1)
            {
                if (Mechanics.ObservationRoll(player))
                {
                    System.Windows.Forms.MessageBox.Show("The Patrician smiles slightly after hearing your flatery");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You cannot tell what the patrician thinks of your flattery");
                }
            }
            else
            {
                if (Mechanics.ObservationRoll(player))
                {
                    System.Windows.Forms.MessageBox.Show("The Patrician doesn't seem to care");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You cannot tell what the patrician thinks of your flattery");
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

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Conversation_Box open = new Conversation_Box(family, player);
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

            Promise_Interaction open = new Promise_Interaction(family);
            open.ShowDialog();

          
            button5.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanRequest open = new LoanRequest();
            open.ShowDialog();
        }
    }
}
