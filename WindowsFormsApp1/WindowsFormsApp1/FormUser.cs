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
        //объявление переменных
        string result = "";
        string str = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
        private int count = 0;
        Random random = new Random();
        //метод формирования символов в капче
        private void SetStringCaptcha()
        {
            result = "";
            char[] chars = str.ToCharArray();
            for(int i = 1; i <= 4; i++)
            {
                result += chars[random.Next(0, chars.Length)];
            }
        }
        //метод заполнения капчи
        private void SetCaptcha() 
        { 
            SetStringCaptcha();

            Bitmap bitmap = new Bitmap(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(Color.White);
            for(int i = 0; i < result.Length; i++) 
            {
                g.DrawString(Convert.ToString(result[i]),
                    new Font("Comic Sans MS", 18),
                    Brushes.Black,
                    new PointF(random.Next(i*40,(i+1)*40), random.Next(20))
                    );
            }

            Color[] colors = { Color.Coral, Color.Gray, Color.Aqua, Color.Pink};

            for(int i = 0; i < pictureBoxCaptcha.Width; i++) 
            { 
                for(int j = 0; j < pictureBoxCaptcha.Height; j++) 
                { 
                    if(random.Next(100) < 20)
                    {
                        bitmap.SetPixel(i, j, colors[random.Next(colors.Length)]);
                    }
                }
            }
            pictureBoxCaptcha.Image = bitmap;
        }
        //запрос на проверку входа по данным
        private bool CheckLogin(string login, string password)
        {
            var cmd = new NpgsqlCommand($"Select * From users Where userlogin = @login AND userpas = @password", Program.connection);
            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("password", password);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            bool result;
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
                result = true;
            }
            else
            {
                result = false;
            }
            reader.Close();
            return result;
        }
        //старт работы таймера
        private void StartTimer()
        {
            timerCaptcha.Start();
            buttonVoiti.Enabled = false;
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
            count++;
            if (textBoxCaptcha.Text == this.result)
            {
                if (CheckLogin(login, password))
                {
                    MessageBox.Show("Добро пожаловать");
                    this.Hide();
                    Menu form = new Menu();
                    Program.connection.Close();
                    form.Show();
                }
                else
                {
                    if(this.Height == 560)
                    {
                        MessageBox.Show("Неверный пароль или логин");
                        SetCaptcha();
                        textBoxCaptcha.Clear();
                        StartTimer();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль или логин");
                        if(count >= 1)
                        {
                            this.Height = 560;
                            SetCaptcha();
                            textBoxCaptcha.Clear();
                            StartTimer();
                        }
                    }
                }
            }
            else if (textBoxCaptcha.Text != this.result)
            {
                MessageBox.Show("Неверная капча");
                SetCaptcha();
                textBoxCaptcha.Clear();
                StartTimer();
            }
        }

        private void timerCaptcha_Tick(object sender, EventArgs e)
        {
            timerCaptcha.Stop();
            buttonVoiti.Enabled = true;
        }
        //кнопка обновления капчи
        private void buttonCaptchaRefref_Click(object sender, EventArgs e)
        {
            SetCaptcha();
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
