using Npgsql;
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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Program.connection.Open();
        }

        //работа кнопки входа для зарегестрированного пользователя
        private void buttonVoiti_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPas.Text;

            var cmd = new NpgsqlCommand($"Select * From users Where userlogin = '{login}' AND userpas = '{password}'", Program.connection);
            
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Program.userSurame = reader["usersurname"];
                    Program.userName = reader["username"];
                    Program.userPatronymic = reader["userpatronymic"];
                    Program.userID = reader["userid"];
                    Program.userRole = reader["userroleid"];
                }
                MessageBox.Show("Добро пожаловать");
                this.Hide();
                Menu form = new Menu();
                Program.connection.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            cmd.Cancel();
            reader.Close();
        }
       
        //кнопка входа в программу для незарегистрированного пользователя
        private void buttonGost_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать");
            this.Hide();
            Menu form = new Menu();
            Program.connection.Close();
            form.Show();
        }
    }
}
