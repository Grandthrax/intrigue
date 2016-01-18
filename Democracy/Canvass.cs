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
    public partial class Canvass : Form
    {
        private TheCast the_cast;

        public Canvass(TheCast cast)
        {
            the_cast = cast;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            InteractTribe frm = new InteractTribe(the_cast);
            frm.ShowDialog();

        }

    }
}

