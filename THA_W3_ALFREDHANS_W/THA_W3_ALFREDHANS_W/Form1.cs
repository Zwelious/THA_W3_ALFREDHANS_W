using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_ALFREDHANS_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            submit_btn.Enabled = false;
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

        private void true_check_CheckedChanged(object sender, EventArgs e)
        {
            bool form2Opened = false;

            foreach (Form form in Application.OpenForms)
            {
                if(form.Name == "Form2")
                {
                    form2Opened = true;
                    form.Hide();
                }
            }
            if (true_check.Checked == true && form2Opened == true)
            {
                submit_btn.Enabled = true;
            }
            else
            {
                submit_btn.Enabled = false;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || artist_text.Text == " ")
            {
                MessageBox.Show("Enter correct input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2 form2 = new Form2();
                form2.changeLabel(name_text.Text, artist_text.Text);
                form2.Show();
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

    }
}
