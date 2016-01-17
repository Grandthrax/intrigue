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
    public partial class Conversation_Box : Form
    {
        Patricians family;
        Player player;
        public Conversation_Box(Patricians Family, Player the_player)
        {
            InitializeComponent();
            family = Family;
            player = the_player;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list_of_families = Mechanics.EnumToList();
            for(int i = 1; i < list_of_families.Count; i ++)
            {
                if(i != family.id)
                {
                    discussionTextBox.Text = "I think of the " + list_of_families[i] + " family " + family.relationship[i].ToString();
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            discussionTextBox.Text = "I think of you " + family.relationship[0].ToString();
        }
    }
}
