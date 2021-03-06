﻿using Intrigue.Character;
using Intrigue.Text;
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
        TheCast the_cast;
        public Conversation_Box(Patricians Family, TheCast cast)
        {
            InitializeComponent();
            family = Family;
            the_cast = cast;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* var list_of_families = Mechanics.EnumToList();
             for(int i = 1; i < list_of_families.Count; i ++)
             {
                 if(i != family.name.family_id)
                 {
                     discussionTextBox.Text = "I think of the " + list_of_families[i] + " family " + family.relationship[i].ToString();
                 }
             }*/
            string dicussion = ViewedText.patrician_OpinionOpening();
            foreach(var rel in the_cast.the_relationships.Where(x => x.Key.Contains(family)))
            {

                dicussion += ViewedText.patrician_OpinionOf(rel.Key.GetOther(family).name.family_name_string, rel.Value.opinion);
            }
            discussionTextBox.Text = dicussion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            discussionTextBox.Text = ViewedText.patrician_OpinionOfPlayer(family.relationship[0]);
        }
    }
}
