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
    public partial class FormTestIt : Form
    {
        public int count;
        public FormTestIt()
        {
            InitializeComponent();
        }

        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            FormTestEnd formTestEnd = new FormTestEnd(count);
            formTestEnd.Show();
            this.Hide();
        }

        private void checkBoxTrue1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrue1.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void checkBoxTrue2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrue2.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void checkBoxTrue3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrue3.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void checkBoxTrue4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrue4.Checked)
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
