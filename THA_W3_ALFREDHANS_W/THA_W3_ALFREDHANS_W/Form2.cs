using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_ALFREDHANS_W
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Form1")
                {
                    form.Hide();
                }
                if (form.Name == "Form2")
                {
                    form.Hide();
                }
            }
        }

        private void true2_check_CheckedChanged(object sender, EventArgs e)
        {
            if (true2_check.Checked == true && agree_check.Checked == true)
            {
                magic_btn.Enabled = true;
            }
        }

        private void agree_check_CheckedChanged(object sender, EventArgs e)
        {
            if (true2_check.Checked == true && agree_check.Checked == true)
            {
                magic_btn.Enabled = true;
            }
        }

        public void changeLabel(string name, string artist)
        {
            output_lbl.Text = "Hi, my name is " + name + " and my favorite artist is " + artist;
        }
        private void magic_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (orange_radio.Checked)
            { form1.BackColor = Color.Orange; }
            else if (cyan_radio.Checked)
            { form1.BackColor = Color.Cyan; }
            else if (pink_radio.Checked)
            { form1.BackColor = Color.Pink; }
            else if (green_radio.Checked)
            { form1.BackColor = Color.Green; }
            else if (purp_radio.Checked)
            { form1.BackColor = Color.Purple; }

            if (blue_radio.Checked)
            { form1.ForeColor = Color.Blue; }
            else if (red_radio.Checked)
            { form1.ForeColor = Color.Red; }
            else if (white_radio.Checked)
            { form1.ForeColor = Color.Orange; }
            form1.Show();
        }
    }
}
