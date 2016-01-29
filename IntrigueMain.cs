using DevExpress.XtraCharts;
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
    public partial class IntrigueMain : Form
    {
        private TheState the_state;
        private TheCast the_cast;
        private Random everything_random;

        private Tribes selected_user;

        public IntrigueMain()
        {
            InitializeComponent();

            palatinePanel.MouseClick += palatinePanel_MouseClick;
            palatinePanel.BackgroundImage = null;

            palatinePanel.MouseEnter += palatinePanel_MouseEnter;


            FirstTurn();
        }

        void palatinePanel_MouseEnter(object sender, EventArgs e)
        {
          //  System.Windows.Forms.MessageBox.Show("hello dad");
        }

        void palatinePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(palatinePanel.BackgroundImage != null)
            {
                palatinePanel.BackgroundImage = null;
                selected_user = null;
            }
            else
            {
                palatinePanel.BackgroundImage = Properties.Resources.romemap_palatina;
                selected_user = the_cast.the_tribes.Last(x => x.name.tribe_name_enum == TribeNameEnum.Palatina);
            }
            
            UpdatePage();
            
        }

        private void FirstTurn()
        {
            everything_random = new Random();

            selected_user = null;

            ActionPanel.Visible = false;
            the_cast = new TheCast();
            the_state = new TheState();
                       
            //creating the opposition
            the_cast.the_opposition.Add(new Opposition(OppositionNames.Cato));
            the_cast.the_opposition.Add(new Opposition(OppositionNames.Curio));
            the_cast.the_opposition.Add(new Opposition(OppositionNames.Lucius));

            //creating the tribes
            the_cast.the_tribes.Add(new Tribes(new TribeName(TribeNameEnum.Collina)));
            the_cast.the_tribes.Add(new Tribes(new TribeName(TribeNameEnum.Esquilana)));
            the_cast.the_tribes.Add(new Tribes(new TribeName(TribeNameEnum.Palatina)));
            the_cast.the_tribes.Add(new Tribes(new TribeName(TribeNameEnum.Suburra)));

            foreach(var tribe in the_cast.the_tribes)
            {
                foreach(var op in the_cast.the_opposition)
                {
                    tribe.relationships.Add(op.name_en, everything_random.Next(0,100));
                }
            }

            UpdatePage();
            
        }

        private void UpdatePage()
        {
            foreach (Series ser in chartControl1.Series)
            {
                ser.Points.Clear();
                
            }


            //do the tribes
            foreach(var trib in the_cast.the_tribes)
            {
                var the_score = trib.relationships.Sum(x => x.Value);
               // the_score += trib.relation_with_player;

                chartControl1.Series["Player"].Points.Add(new SeriesPoint(trib.name.tribe_name_string, trib.relation_with_player));

                foreach(var opp in trib.relationships)
                {
                    chartControl1.Series[opp.Key.ToString()].Points.Add(new SeriesPoint(trib.name.tribe_name_string, opp.Value));
                }
                
            }

          /*  for(int opp_num = 1; opp_num <= the_cast.the_opposition.Count; opp_num++)
            {
                chartControl1.Series[the_cast.the_opposition[opp_num-1].name].Points.Add(new SeriesPoint(0, the_cast.the_tribes.Last(x => x.name.tribe_name_enum == TribeNameEnum.Palatina).relationships[the_cast.the_opposition[opp_num -1].name_en]));
                chartControl1.Series[the_cast.the_opposition[opp_num-1].name].Points.Add(new SeriesPoint(1, the_cast.the_tribes.Last(x => x.name.tribe_name_enum == TribeNameEnum.Collina).relationships[the_cast.the_opposition[opp_num - 1].name_en]));
                chartControl1.Series[the_cast.the_opposition[opp_num-1].name].Points.Add(new SeriesPoint(2, the_cast.the_tribes.Last(x => x.name.tribe_name_enum == TribeNameEnum.Esquilana).relationships[the_cast.the_opposition[opp_num - 1].name_en]));
                chartControl1.Series[the_cast.the_opposition[opp_num-1].name].Points.Add(new SeriesPoint(3, the_cast.the_tribes.Last(x => x.name.tribe_name_enum == TribeNameEnum.Suburra).relationships[the_cast.the_opposition[opp_num - 1].name_en]));
                
            }*/
            

            turnLabel1.Text = "Turn " + the_state.turn_number.ToString();
            moneyLabel.Text = Mechanics.FormatSesterces(the_cast.the_player.wealth);

            if(selected_user != null)
            {
                ActionPanel.Visible = true;
                actionNameLabel.Text = selected_user.name.tribe_name_string;
            }
            else
            {
                ActionPanel.Visible = false;
            }

            //get turn action
            if(the_cast.the_player.turns_actions.Exists(x => x.turn_number == the_state.turn_number))
            {
                var t =the_cast.the_player.turns_actions.Last();
                TurnAction.Text = t.action_name.ToString() + " " + t.tribe.tribe_name_string;
            }
            else
            {
                TurnAction.Text = "you have not yet chosen an action";
            }
            
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            FirstTurn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTurn();
        }

        private void NewTurn()
        {
            //player actions
            var action = the_cast.the_player.turns_actions.Last(x => x.turn_number == the_state.turn_number);
            if(action != null)
            {
                var tribe = the_cast.the_tribes.Last(x => x.name == action.tribe);
                if(action.action_name == ActionNameEnum.Bribe)
                {
                    tribe.relation_with_player += 10;   
                }
                else if (action.action_name == ActionNameEnum.Orate)
                {
                    tribe.relation_with_player += 5;
                }
                else if(action.action_name == ActionNameEnum.Thugs)
                {
                    tribe.relation_with_player += 20;
                }
            }


            //opponents actions

            ActionPanel.Visible = false;

            the_state.turn_number++;
            selected_user = null;
            UpdatePage();
        }

        private void thugsButton_Click(object sender, EventArgs e)
        {
            Actions ac = new Actions();
            ac.action_name = ActionNameEnum.Thugs;
            ac.turn_number = the_state.turn_number;
            ac.tribe = selected_user.name;
            the_cast.the_player.turns_actions.Add(ac);

            UpdatePage();
        }

        private void bribeButton_Click(object sender, EventArgs e)
        {
            Actions ac = new Actions();
            ac.action_name = ActionNameEnum.Bribe;
            ac.turn_number = the_state.turn_number;
            ac.tribe = selected_user.name;
            the_cast.the_player.turns_actions.Add(ac);

            UpdatePage();
        }

        private void orateButton_Click(object sender, EventArgs e)
        {
            Actions ac = new Actions();
            ac.action_name = ActionNameEnum.Orate;
            ac.turn_number = the_state.turn_number;
            ac.tribe = selected_user.name;
            the_cast.the_player.turns_actions.Add(ac);

            UpdatePage();
        }

    }
}
