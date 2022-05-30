using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTestDesign : Form
    {
        int count;
        string testType = "Design_1.1";
        public FormTestDesign()
        {
            InitializeComponent();
        }

        private void radioButtonTrue1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrue1.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void radioButtonTrue2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrue1.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void radioButtonTrue3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrue1.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void radioButtonTrue4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrue1.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            FormFinalTestDisign formFinalTestDisign = new FormFinalTestDisign(count, testType);
            formFinalTestDisign.Show();
            this.Close();
        }

        private void FormTestDesign_Load(object sender, EventArgs e)
        {

        }
    }
}
