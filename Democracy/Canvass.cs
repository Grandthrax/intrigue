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
        public Canvass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            InteractTribe frm = new InteractTribe();
            frm.Show();

        }

    }
}

