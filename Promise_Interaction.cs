using DevExpress.XtraEditors.Controls;
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
    public partial class Promise_Interaction : Form
    {
        public Promise_Interaction()
        {
            InitializeComponent();

            var mm = Mechanics.EnumToList();
            for(int i = 1; i < mm.Count; i++)
            {
                radioGroup2.Properties.Items.Add(new RadioGroupItem(i, mm[i]));
            }
            radioGroup2.Properties.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
