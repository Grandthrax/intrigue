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
        Patricians this_family;
        TheCast the_cast;
        public Promise_Interaction(Patricians family, TheCast cast)
        {
            this_family = family;
            the_cast = cast;

            InitializeComponent();

            var mm = Mechanics.EnumToList();
            for(int i = 1; i < mm.Count; i++)
            {
                if (i != this_family.name.family_id)
                {
                    radioGroup2.Properties.Items.Add(new RadioGroupItem(i, mm[i]));
                }
            }



            radioGroup2.Properties.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var new_promise = new Promises();
            new_promise.promise_to = this_family.name;
            new_promise.promise_vs = the_cast.the_patricians.FindLast(x => x.name.family_name_string == radioGroup2.Properties.Items[radioGroup2.SelectedIndex].Description).name;
            new_promise.relationship_bonus = 5;
            new_promise.turn_due = 5;
            new_promise.type_of_promise = Promise.Insult;
            the_cast.the_player.promises.Add(new_promise);

            MessageBox.Show("You promise to insult, " + new_promise.promise_vs.family_name_string);
        }
    }
}
