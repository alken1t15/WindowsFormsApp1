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
    public partial class FormStatictic : Form
    {
        bool isExists = true;
        Serves serves = new Serves();
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=master;" +
                "Integrated Security=True;";
        public FormStatictic()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTest form = new FormTest();
            form.Show();
            this.Hide();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome(isExists); 
            form.Show();
            this.Hide();
        }

        private void FormStatictic_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Add("Name", "Имя");
            this.dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dataGridView1.Columns.Add("Surname", "Фамилия");
            this.dataGridView1.Columns["Surname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dataGridView1.Columns.Add("TestType", "Тип теста");
            this.dataGridView1.Columns["TestType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dataGridView1.Columns.Add("Results", "Результаты");
            this.dataGridView1.Columns["Results"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            serves.SelectDataBase(connectionString, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
    }
}
