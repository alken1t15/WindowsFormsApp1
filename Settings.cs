using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Settings : Form
    {
        bool isEntered = true;
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
            isEntered = false;
            MessageBox.Show("Сброс выполнен успешно!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isEntered)
            {
                FormHome formHome = new FormHome(isExists);
                formHome.Show();
                this.Close();
            }
            else
            {
                string message = "Вы уверены, что хотите выйти? Главный экран откроется через 3 секунды!";
                string caption = "Warning!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    // Closes the parent form.
                    Thread.Sleep(3000);
                    FormHome formHome = new FormHome(isExists);
                    formHome.Show();
                    this.Close();
                }
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (isEntered)
            {
                FormTest formTest = new FormTest();
                formTest.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные текущего пользователя были удалены или статистика была сброшена! Вас перекинет на главный экран для повторного входа.");
                Thread.Sleep(1500);
                FormHome formHome = new FormHome(isExists);
                formHome.Show();
                this.Close();
            }
            
        }
    }
}
