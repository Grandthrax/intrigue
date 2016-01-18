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
            //go visit the palatina tribe
            Tribes temp = the_cast.the_tribes.FindLast(x => x.name.tribe_name_enum == TribeNameEnum.Palatina);

            InteractTribe frm = new InteractTribe(the_cast, temp);
            frm.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // go visit the Collina tribe
            Tribes temp = the_cast.the_tribes.FindLast(x => x.name.tribe_name_enum == TribeNameEnum.Collina);

            InteractTribe frm = new InteractTribe(the_cast, temp);
            frm.ShowDialog();
        }
    }
}

