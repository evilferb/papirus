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
using System.Configuration;

namespace Papirus
{
    public partial class FormLogin : Form
    {
        private SqlConnection sqlConnection = null;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                SqlCommand commandCurators = new SqlCommand("SELECT password FROM [curators] WHERE login=@login", sqlConnection);
                commandCurators.Parameters.Add("@login", login);

                SqlDataReader readerCurators = commandCurators.ExecuteReader();
                if (readerCurators.HasRows == false)
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
                while (readerCurators.Read())
                {
                    if (readerCurators["password"].ToString().Trim() == tbPassword.Text)
                    {
                        tbPassword.Text = null;
                        mainform f1 = new mainform();
                        f1.Owner = this;
                        f1.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        tbPassword.Text = null;
                    }
                }
                readerCurators.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlCommand commandModerators = new SqlCommand("SELECT password FROM [moderators] WHERE login=@login", sqlConnection);
                commandModerators.Parameters.Add("@login", login);

                SqlDataReader readerModerators = commandModerators.ExecuteReader();
                if (readerModerators.HasRows == false)
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
                while (readerModerators.Read())
                {
                    if (readerModerators["password"].ToString().Trim() == tbPassword.Text)
                    {
                        MessageBox.Show("Moder pashet");
                        /*tbPassword.Text = null;
                        mainform f1 = new mainform();
                        f1.Owner = this;
                        f1.Show();

                        this.Hide();*/
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        tbPassword.Text = null;
                    }
                }
                readerModerators.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlCommand command = new SqlCommand("SELECT password FROM [admins] WHERE login=@login", sqlConnection);
                command.Parameters.Add("@login", login);
                
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
                while (reader.Read())
                    {
                        if (reader["password"].ToString() == tbPassword.Text)
                        {
                            MessageBox.Show("grac");
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            tbPassword.Text = null;
                        }
                    }
                reader.Close();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PapirusCS"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            MessageBox.Show("Соединение работает");
        }

    }
}
