using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormTestEnd : Form
    {
        Serves serves = new Serves();
        string testType;
        string queryString;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=master;" +
                "Integrated Security=True;";
        public FormTestEnd(int count, string _testType)
        {
            InitializeComponent();
            label1.Text = count.ToString() + "/4";
            testType = _testType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryString = "UPDATE Students SET TestType = '" + testType + "' WHERE Name = '" + WindowsFormsApp1.FormHome.name + "';";
            serves.CreateCommand(queryString, connectionString);
            queryString = "UPDATE Students SET Results = '" + label1.Text + "' WHERE Name = '" + WindowsFormsApp1.FormHome.name + "';";
            serves.CreateCommand(queryString, connectionString);
            FormTest formTest = new FormTest();
            formTest.Show();
            this.Hide();
        }

        private void FormTestEnd_Load(object sender, EventArgs e)
        {

        }
    }
}
