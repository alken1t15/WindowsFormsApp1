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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            FormStatictic form = new FormStatictic();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTestIt formTestIt = new FormTestIt();
            formTestIt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormTestTurizm formTest = new FormTestTurizm();
            formTest.Show();
            this.Hide();
        }
    }
}
