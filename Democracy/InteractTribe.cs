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
            public InteractTribe()
            {
                InitializeComponent();
                lblpalatinasupport.Text = Tribe_Palatina_Proposal_Support.ToString();
                labelpalatinaoppose.Text = Tribe_Palatina_Proposal_Oppose.ToString();
                lbldistrictdescription.Text = Tribe_Palatina_Description.ToString();
            }

            //A description for display when clicking on the district. Possibly put in an observation check later.
            string Tribe_Palatina_Description = "In the South-West of the city, from the Palatium hill and beyond.These traditionalists consider themselves the original romans, everyone else is just new blood to them.";
            //Each district is loyal to one of the four houses, and more likely to be influenced by their favours.
            // public Tribe_Palatina_House_Loyalty Familynames
            public int Tribe_Palatina_Patrician_population = 50;
            public int Tribe_Palatina_Equite_population = 100;
            public int Tribe_Palatina_PlebisNobilis_population = 2000;
            public int Tribe_Palatina_Pleb_population = 10000;
            public int Tribe_Palatina_Proletarii_population = 5000;
            //The total population who can vote, for determining election outcomes.
            public int Tribe_Palatina_Proposal_Support = 50;
            public int Tribe_Palatina_Proposal_Oppose = 50;

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
                Tribe_Palatina_Proposal_Support += 5;
                lblwhatyoudid.Text = "You shook a few hands and kissed a few babies. People's views haven't changed that much, but it helps.";
                lblpalatinasupport.Text = Tribe_Palatina_Proposal_Support.ToString();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                Tribe_Palatina_Proposal_Support += 25;
                lblwhatyoudid.Text = "You splash your cash, and win some support.";
                lblpalatinasupport.Text = Tribe_Palatina_Proposal_Support.ToString();
            }
        }
    }
