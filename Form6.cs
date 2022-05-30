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
    public partial class FormTestTurizm : Form
    {
        int count;
        public FormTestTurizm()
        {
            InitializeComponent();
        }

        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            FormTestFinalTurizm form   = new FormTestFinalTurizm(count);
            form.Show();
            this.Close();
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
            if (radioButtonTrue2.Checked)
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
            if (radioButtonTrue3.Checked)
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
            if (radioButtonTrue4.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
    }
}
