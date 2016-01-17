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
    public partial class Form1 : Form
    {
        Random everythingRandom;

        private int turn_num;
        
        private List<Patricians> the_patricians;
        
        private Player the_player;

        private List<string> character_names;

        public Form1()
        {
            
            InitializeComponent();
            FirstTurn();
            
        }

        private void FirstTurn()
        {

            the_patricians = new List<Patricians>();
            character_names = new List<string>();

            button2.Enabled = true;
            button3.Enabled = true;
            interactCorneliaButton.Enabled = true;

            everythingRandom = new Random();
            turn_num = 0;
            turnsLeftLabel.Text = "Turn " + turn_num.ToString();
            gameOverLabel.Text = "";


            

            //create the families
            InitiatePatricians();

            the_player = new Player();

            MainCharacter open = new MainCharacter(the_player);
            open.ShowDialog();

            UpdatePage();

            

            
        }

        private void UpdatePage()
        {
            debtLabel.Text = the_player.debt.ToString();
            moneyLabel.Text = the_player.wealth.ToString();


            var list = new BindingList<Promises>(the_player.promises);
            
            dataGridView1.DataSource = list;
            
            /*foreach (var prom in the_player.promises)
            {
                dataGridView1.Rows.Add(prom.promise_to, prom.type_of_promise, prom.turn_due.ToString());
            }*/
        }



        private void InitiatePatricians()
        {
            var character_names = Mechanics.EnumToList();


            Patricians Cornelia1 = new Patricians(new FamilyName(FamilyNames.Cornelius), everythingRandom, 1);
            //create the cornelias
            Corneliawealthlabel.Text = Cornelia1.wealth.ToString() + " million";

            //create the Marius
            var Marius1 = new Patricians(new FamilyName(FamilyNames.Marius), everythingRandom, 2);
            mariusWealthLabel.Text = Marius1.wealth.ToString() + " million";

            the_patricians.Add(Cornelia1);
            the_patricians.Add(Marius1);

            //now build relationship it is one less than real
            the_patricians[0].relationship[2] = the_patricians[1].relationship[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewTurn();
            
        }

        private void NewTurn()
        {
            interactCorneliaButton.Enabled = true;
            button3.Enabled = true;

            


            turn_num++;
            CheckPromises();
            turnsLeftLabel.Text = "Turn " + turn_num.ToString();

            //Check out the relationships between the houses
            for (int i = 2; i < 3; i++)
            {
                the_patricians[0].relationship[i] += everythingRandom.Next(-5, 5);

                if (the_patricians[0].relationship[i] < -25)
                {
                    if (Mechanics.StreetSmartCheck(the_player))
                    {
                        System.Windows.Forms.MessageBox.Show("You hear rumours that the " + the_patricians[0].name + " families thugs have attacked some the " + character_names[i] + " families slaves. This could be civil war!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Something is afoot, there are murmerings in the street but when you seek for an answer, you find only furtive glances and vague warnings.");
                    }

                }
                if (the_patricians[0].relationship[i] < -30)
                {
                    EndGame(5);
                }
            }


            


                //Check if you are assasisinated
            if (the_patricians[0].relationship[0] < -49 | the_patricians[1].relationship[0] < -49)
                {
                    EndGame(1);
                }

            if(turn_num > 5)
            {
                if (the_patricians[0].relationship[0] > 49)
                {
                    EndGame(2);
                }
                else if (the_patricians[1].relationship[0] > 49)
                {
                    EndGame(3);
                }
                else
                {
                    EndGame(4);
                }


            }
            UpdatePage();
        }

        private void CheckPromises()
        {

            var temp = new List<Promises>();
            foreach(var prom in the_player.promises)
            {
                

                if(prom.turn_due < turn_num)
                {
                    //effect relationship
                    int patrician_num = prom.promise_to.family_id;
                    the_patricians[patrician_num].relationship[0] += prom.relationship_bonus * -2;
                    System.Windows.Forms.MessageBox.Show("Your relationship with " + prom.promise_to.ToString() + " has deteriated");

                    the_player.old_promises.Add(prom);
                    temp.Add(prom);

                }
                else if(prom.turn_due == turn_num)
                {
                    //highlight row
                }

                
            }
            foreach(var t in temp)
            {
                the_player.promises.Remove(t);
            }
        }

       

        private void EndGame(int situation)
        {
            switch(situation)
            {
                case 1:
                gameOverLabel.Text = "You have been assasinated!";
                    break;
                case 2:
                    gameOverLabel.Text = "You lost the election but the Cornelia family adopts you!";
                    break;
                case 3:
                    gameOverLabel.Text = "You lost the election but the Marius Family adopts you!";
                    break;
                case 4:
                    gameOverLabel.Text = "You lost the election";
                    break;
                case 5:
                    gameOverLabel.Text = "A civil war has broken out between two of the major families. You put your aims of high office aside while you fight for yourself";
                    break;
            }

            button2.Enabled = false;
            button3.Enabled = false;
            interactCorneliaButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstTurn();
        }

        private void interactCorneliaButton_Click(object sender, EventArgs e)
        {
            PatricianInteract open = new PatricianInteract(the_patricians[0], the_player);
            open.ShowDialog();

            interactCorneliaButton.Enabled = false;

            the_patricians[1].relationship[the_patricians[0].id] = the_patricians[0].relationship[the_patricians[1].id];
            UpdatePage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatricianInteract open = new PatricianInteract(the_patricians[1], the_player);
            open.ShowDialog();

            

            button3.Enabled = false;
            UpdatePage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
