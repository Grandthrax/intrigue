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

namespace Intrigue.Democracy
{
    public partial class InteractTribe : Form
    {
        private TheCast the_cast;
        private Tribes this_tribe;

        public InteractTribe(TheCast cast, Tribes tribe)
        {
            InitializeComponent();

            this_tribe = tribe;
            the_cast = cast;

            label3.Text = this_tribe.name.tribe_name_string;

            lblpalatinasupport.Text = this_tribe.proposal_support.ToString();
            labelpalatinaoppose.Text = this_tribe.proposal_oppose.ToString();
            lbldistrictdescription.Text = this_tribe.description.ToString();
        }

            private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this_tribe.proposal_support += 5;
            lblwhatyoudid.Text = "You shook a few hands and kissed a few babies. People's views haven't changed that much, but it helps.";
            lblpalatinasupport.Text = this_tribe.proposal_support.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            the_cast.the_player.wealth -= 50;

            this_tribe.proposal_support += 25;
            lblwhatyoudid.Text = "You splash your cash, and win some support.";
            lblpalatinasupport.Text = this_tribe.proposal_support.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
