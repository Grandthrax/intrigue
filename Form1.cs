﻿using Intrigue.Character;
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
    public partial class Form1 : Form
    {
        Random everythingRandom;

        private int turn_num;

        private TheCast the_cast;

        private List<string> character_names;

        public Form1()
        {
            
            InitializeComponent();
            FirstTurn();
            
        }

        private void FirstTurn()
        {

            the_cast = new TheCast();

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

            //create the tribes
            InitiateTribes();

            

            MainCharacter open = new MainCharacter(the_cast.the_player);
            open.ShowDialog();

            UpdatePage();

            

            
        }

        private void InitiateTribes()
        {
            //create the Palatina
            TribeName tribe_name_temp;
            tribe_name_temp = new TribeName(TribeNameEnum.Palatina);
            Tribes palatina;

            //A description for display when clicking on the district. Possibly put in an observation check later.
            string Tribe_Palatina_Description = "In the South-West of the city, from the Palatium hill and beyond.These traditionalists consider themselves the original romans, everyone else is just new blood to them.";
            //Each district is loyal to one of the four houses, and more likely to be influenced by their favours.
            // public Tribe_Palatina_House_Loyalty Familynames
             int Tribe_Palatina_Patrician_population = 10;
             int Tribe_Palatina_Equite_population = 100;
             int Tribe_Palatina_PlebisNobilis_population = 2000;
             int Tribe_Palatina_Pleb_population = 10000;
             int Tribe_Palatina_Proletarii_population = 5000;
            //The total population who can vote, for determining election outcomes.
             int Tribe_Palatina_Proposal_Support = 50;
             int Tribe_Palatina_Proposal_Oppose = 50;

            palatina = new Tribes(tribe_name_temp, everythingRandom);
            palatina.patrician_population = Tribe_Palatina_Patrician_population;
            palatina.equite_population = Tribe_Palatina_Equite_population;
            palatina.plebisnobilis_population = Tribe_Palatina_PlebisNobilis_population;
            palatina.pleb_population = Tribe_Palatina_Pleb_population;
            palatina.proletarii_population = Tribe_Palatina_Proletarii_population;
            palatina.proposal_support = Tribe_Palatina_Proposal_Support;
            palatina.proposal_oppose = Tribe_Palatina_Proposal_Oppose;
            palatina.description = Tribe_Palatina_Description;

            the_cast.the_tribes.Add(palatina);

            //create the Colinna
            tribe_name_temp = new TribeName(TribeNameEnum.Collina);
            Tribes Collina;

            //A description for display when clicking on the district. Possibly put in an observation check later.
            Tribe_Palatina_Description = "These are Collinas";
            //Each district is loyal to one of the four houses, and more likely to be influenced by their favours.
            // public Tribe_Palatina_House_Loyalty Familynames
            Tribe_Palatina_Patrician_population = 20;
            Tribe_Palatina_Equite_population = 100;
            Tribe_Palatina_PlebisNobilis_population = 2000;
            Tribe_Palatina_Pleb_population = 10000;
            Tribe_Palatina_Proletarii_population = 5000;
            //The total population who can vote, for determining election outcomes.
            Tribe_Palatina_Proposal_Support = 50;
            Tribe_Palatina_Proposal_Oppose = 50;

            Collina = new Tribes(tribe_name_temp, everythingRandom);
            Collina.patrician_population = Tribe_Palatina_Patrician_population;
            Collina.equite_population = Tribe_Palatina_Equite_population;
            Collina.plebisnobilis_population = Tribe_Palatina_PlebisNobilis_population;
            Collina.pleb_population = Tribe_Palatina_Pleb_population;
            Collina.proletarii_population = Tribe_Palatina_Proletarii_population;
            Collina.proposal_support = Tribe_Palatina_Proposal_Support;
            Collina.proposal_oppose = Tribe_Palatina_Proposal_Oppose;
            Collina.description = Tribe_Palatina_Description;

            the_cast.the_tribes.Add(Collina);

            //create the Suburra
            tribe_name_temp = new TribeName(TribeNameEnum.Suburra);
            Tribes Suburra;

            //A description for display when clicking on the district. Possibly put in an observation check later.
            Tribe_Palatina_Description = "These are Suburras.";
            //Each district is loyal to one of the four houses, and more likely to be influenced by their favours.
            // public Tribe_Palatina_House_Loyalty Familynames
            Tribe_Palatina_Patrician_population = 30;
            Tribe_Palatina_Equite_population = 100;
            Tribe_Palatina_PlebisNobilis_population = 2000;
            Tribe_Palatina_Pleb_population = 10000;
            Tribe_Palatina_Proletarii_population = 5000;
            //The total population who can vote, for determining election outcomes.
            Tribe_Palatina_Proposal_Support = 50;
            Tribe_Palatina_Proposal_Oppose = 50;

            Suburra = new Tribes(tribe_name_temp, everythingRandom);
            Suburra.patrician_population = Tribe_Palatina_Patrician_population;
            Suburra.equite_population = Tribe_Palatina_Equite_population;
            Suburra.plebisnobilis_population = Tribe_Palatina_PlebisNobilis_population;
            Suburra.pleb_population = Tribe_Palatina_Pleb_population;
            Suburra.proletarii_population = Tribe_Palatina_Proletarii_population;
            Suburra.proposal_support = Tribe_Palatina_Proposal_Support;
            Suburra.proposal_oppose = Tribe_Palatina_Proposal_Oppose;
            Suburra.description = Tribe_Palatina_Description;

            the_cast.the_tribes.Add(Suburra);


            //create the Esquilana
            tribe_name_temp = new TribeName(TribeNameEnum.Esquilana);
            Tribes Esquilana;

            //A description for display when clicking on the district. Possibly put in an observation check later.
            Tribe_Palatina_Description = "These are Esquilana.";
            //Each district is loyal to one of the four houses, and more likely to be influenced by their favours.
            // public Tribe_Palatina_House_Loyalty Familynames
            Tribe_Palatina_Patrician_population = 40;
            Tribe_Palatina_Equite_population = 100;
            Tribe_Palatina_PlebisNobilis_population = 2000;
            Tribe_Palatina_Pleb_population = 10000;
            Tribe_Palatina_Proletarii_population = 5000;
            //The total population who can vote, for determining election outcomes.
            Tribe_Palatina_Proposal_Support = 50;
            Tribe_Palatina_Proposal_Oppose = 50;

            Esquilana = new Tribes(tribe_name_temp, everythingRandom);
            Esquilana.patrician_population = Tribe_Palatina_Patrician_population;
            Esquilana.equite_population = Tribe_Palatina_Equite_population;
            Esquilana.plebisnobilis_population = Tribe_Palatina_PlebisNobilis_population;
            Esquilana.pleb_population = Tribe_Palatina_Pleb_population;
            Esquilana.proletarii_population = Tribe_Palatina_Proletarii_population;
            Esquilana.proposal_support = Tribe_Palatina_Proposal_Support;
            Esquilana.proposal_oppose = Tribe_Palatina_Proposal_Oppose;
            Esquilana.description = Tribe_Palatina_Description;

            the_cast.the_tribes.Add(Esquilana);
        }

        private void UpdatePage()
        {
            debtLabel.Text = the_cast.the_player.debt.ToString();
            moneyLabel.Text = the_cast.the_player.wealth.ToString();


            var list = new BindingList<Promises>(the_cast.the_player.promises);
            
            dataGridView1.DataSource = list;
            
            /*foreach (var prom in the_player.promises)
            {
                dataGridView1.Rows.Add(prom.promise_to, prom.type_of_promise, prom.turn_due.ToString());
            }*/
        }



        private void InitiatePatricians()
        {
            
            //create the cornelias
            Patricians Cornelia1 = new Patricians(new FamilyName(FamilyNames.Cornelius), everythingRandom);
            Corneliawealthlabel.Text = Cornelia1.wealth.ToString() + " million";
            the_cast.the_patricians.Add(Cornelia1);

            //create the Marius
            var Marius1 = new Patricians(new FamilyName(FamilyNames.Marius), everythingRandom);
            mariusWealthLabel.Text = Marius1.wealth.ToString() + " million";
            the_cast.the_patricians.Add(Marius1);

            //create the Julias
            var Julia = new Patricians(new FamilyName(FamilyNames.Julia), everythingRandom);
            pat3label.Text = Julia.wealth.ToString() + " million";
            the_cast.the_patricians.Add(Julia);

            //create the Atilias
            var Atilia = new Patricians(new FamilyName(FamilyNames.Atilia), everythingRandom);
            pat4label.Text = Atilia.wealth.ToString() + " million";
            the_cast.the_patricians.Add(Atilia);



            //now build relationship it is one less than real
            //the_cast.the_patricians.FindLast(x=>x.name.family_name_enum == FamilyNames.Cornelius).relationship[2] = the_cast.the_patricians.FindLast(x=>x.name.family_name_enum == FamilyNames.Marius).relationship[1];

            foreach (var pat in the_cast.the_patricians)
            {
                foreach (var pat2 in the_cast.the_patricians)
                {
                    if(pat != pat2)
                    {
                       
                        if(!the_cast.the_relationships.Any(x => x.Key.Any(pat,pat2)))
                        {
                            the_cast.the_relationships.Add(new PatricianPair(pat, pat2), new Relationships(everythingRandom.Next(-50, 50)));
                        }
                    }

                }
            }
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

            foreach (var rel in the_cast.the_relationships)
            {
                rel.Value.opinion += everythingRandom.Next(-5, 5);

                if (rel.Value.opinion < -25)
                {
                    if (Mechanics.StreetSmartCheck(the_cast.the_player))
                    {
                        MessageBox.Show(ViewedText.civilunrest_highstreetsmart(rel.Key.patrician1.name.family_name_string, rel.Key.patrician2.name.family_name_string));
                    }
                    else
                    {
                        MessageBox.Show(ViewedText.civilunrest_lowstreetsmart());
                    }

                }
                if (rel.Value.opinion < -30)
                {
                    EndGame(5);
                }
            }

            /*for (int i = 2; i < 3; i++)
            {
                the_cast.the_patricians[0].relationship[i] += everythingRandom.Next(-5, 5);

                if (the_cast.the_patricians[0].relationship[i] < -25)
                {
                    if (Mechanics.StreetSmartCheck(the_cast.the_player))
                    {
                        System.Windows.Forms.MessageBox.Show("You hear rumours that the " + the_cast.the_patricians[0].name + " families thugs have attacked some the " + character_names[i] + " families slaves. This could be civil war!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Something is afoot, there are murmerings in the street but when you seek for an answer, you find only furtive glances and vague warnings.");
                    }

                }
                if (the_cast.the_patricians[0].relationship[i] < -30)
                {
                    EndGame(5);
                }
            }*/


            


                //Check if you are assasisinated
            if (the_cast.the_patricians[0].relationship[0] < -49 | the_cast.the_patricians[1].relationship[0] < -49)
                {
                    EndGame(1);
                }

            if(turn_num > 5)
                    {
                if (the_cast.the_patricians[0].relationship[0] > 49)
                {
                    EndGame(2);
                }
                else if (the_cast.the_patricians[1].relationship[0] > 49)
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
            foreach(var prom in the_cast.the_player.promises)
            {
                

                if(prom.turn_due < turn_num)
                {
                    //effect relationship
                    int patrician_num = prom.promise_to.family_id;
                    the_cast.the_patricians[patrician_num].relationship[0] += prom.relationship_bonus * -2;
                    MessageBox.Show(ViewedText.relationship_deteriated(prom.promise_to.ToString()));

                    the_cast.the_player.old_promises.Add(prom);
                    temp.Add(prom);

                }
                else if(prom.turn_due == turn_num)
                {
                    //highlight row
                }

                
            }
            foreach(var t in temp)
            {
                the_cast.the_player.promises.Remove(t);
            }
        }

       

        private void EndGame(int situation)
        {
            switch(situation)
            {
                case 1:
                gameOverLabel.Text = ViewedText.player_assasinated();
                    break;
                case 2:
                    gameOverLabel.Text = ViewedText.player_adopted("Cornelia");
                    break;
                case 3:
                    gameOverLabel.Text = ViewedText.player_adopted("Marius"); ;
                    break;
                case 4:
                    gameOverLabel.Text = ViewedText.player_loseselection();
                    break;
                case 5:
                    gameOverLabel.Text = ViewedText.civil_war();
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
            PatricianInteract open = new PatricianInteract(the_cast.the_patricians[0], the_cast);
            open.ShowDialog();

            interactCorneliaButton.Enabled = false;
            
            UpdatePage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatricianInteract open = new PatricianInteract(the_cast.the_patricians[1], the_cast);
            open.ShowDialog();

            

            button3.Enabled = false;
            UpdatePage();
        }

        private void pat3button_Click(object sender, EventArgs e)
        {
            PatricianInteract open = new PatricianInteract(the_cast.the_patricians[2], the_cast);
            open.ShowDialog();



            pat3button.Enabled = false;
            UpdatePage();
        }

        private void pat4button_Click(object sender, EventArgs e)
        {
            PatricianInteract open = new PatricianInteract(the_cast.the_patricians[3], the_cast);
            open.ShowDialog();



            pat4button.Enabled = false;
            UpdatePage();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncanvass_Click(object sender, EventArgs e)
        {
                Democracy.Canvass frm = new Democracy.Canvass(the_cast);
                frm.ShowDialog();

            UpdatePage();
            
        }
    }
}
