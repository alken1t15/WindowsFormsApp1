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
        bool isExists = true;
        Serves serves = new Serves();
        string queryString;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=master;" +
                "Integrated Security=True;";
        public static string name, surname;
        public FormHome(bool _isExists)
        {
            InitializeComponent();
            isExists = _isExists;


        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != String.Empty && textBox_Surname.Text != String.Empty)
            {
                name = textBox_Name.Text;
                surname = textBox_Surname.Text;
                label4.Visible = false;
                queryString = "INSERT INTO Students (Name, Surname) VALUES ('" +
                        textBox_Name.Text + "', '" +
                        textBox_Surname.Text + "');";
                serves.CreateCommand(queryString, connectionString);
                FormTest form = new FormTest();
                form.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            FormStatictic form = new FormStatictic();
            form.Show();
            this.Hide();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            buttonTest.Enabled = true;
        }

        private void textBox_Surname_TextChanged(object sender, EventArgs e)
        {
            buttonTest.Enabled = true;
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            queryString = "DROP TABLE [dbo].[Students];";
            serves.CreateCommand(queryString, connectionString);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isExists)
                {
                    queryString = "CREATE TABLE [dbo].[Students] (" +
                                                               "[Id] BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY," +
                                                               "[Name] nvarchar(50) NOT NULL," +
                                                               "[Surname] nvarchar(50) NOT NULL," +
                                                               "[TestType] nvarchar(50) NULL," +
                                                               "[Results] nvarchar(50) NULL," +
                                                               ");";
                    serves.CreateCommand(queryString, connectionString);
                    isExists = true;

                }
                else
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Таблица уже создана!");
            }
            
        }
    }
}
