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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FormTest form = new FormTest();
            form.Show();
            this.Hide();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            FormStatictic form = new FormStatictic();
            form.Show();
            this.Hide();
        }
    }
}
