using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intrigue.Character
{
    public partial class MainCharacter : Form
    {
        Player player;
        public MainCharacter(Player Player)
        {
            InitializeComponent();
            player = Player;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch(radioGroup1.Text)
            {
                case "ExSlave":
                    player.acumen = 8;
                    player.fighting = 5;
                    player.oratory = 3;
                    player.authority = 3;
                    player.observation = 7;
                    player.street_smarts = 6;
                    player.debt = 1000;
                    break;
                case "Criminal":
                    player.acumen = 5;
                    player.fighting = 8;
                    player.oratory = 5;
                    player.authority = 7;
                    player.observation = 8;
                    player.street_smarts = 10;
                    player.wealth = 500;
                    break;
                case "ExPatrician":
                    player.acumen = 6;
                    player.fighting = 7;
                    player.oratory = 7;
                    player.authority = 7;
                    player.observation = 3;
                    player.street_smarts = 2;
                    player.debt = 1000;
                    break;
                case "FreedGladiator":
                    player.acumen = 5;
                    player.fighting = 10;
                    player.oratory = 6;
                    player.authority = 4;
                    player.observation = 7;
                    player.street_smarts = 5;
                    break;

            }
            this.Close();

        }
    }
}
