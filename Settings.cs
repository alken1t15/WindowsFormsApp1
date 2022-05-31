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
    public partial class Settings : Form
    {
        bool isExists = true;
        Serves serves = new Serves();
        string queryString;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=master;" +
                "Integrated Security=True;";
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            queryString = "DROP TABLE [dbo].[Students];";
            serves.CreateCommand(queryString, connectionString);
            queryString = "CREATE TABLE [dbo].[Students] (" +
                                                           "[Id] BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY," +
                                                           "[Name] nvarchar(50) NOT NULL," +
                                                           "[Surname] nvarchar(50) NOT NULL," +
                                                           "[TestType] nvarchar(50) NULL," +
                                                           "[Results] nvarchar(50) NULL," +
                                                           ");";
            serves.CreateCommand(queryString, connectionString);
            isExists = true;
            MessageBox.Show("Сброс выполнен успешно!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queryString = "DELETE FROM Students WHERE Name = '" + FormHome.name + "';";
            serves.CreateCommand(queryString, connectionString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(isExists);
            formHome.Show();
            this.Close();
        }
    }
}
