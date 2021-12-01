using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;
using System.Linq;

namespace ILP
{
    public partial class SigninPage : Form
    {
        Point lastPoint;
        ApplicationContext db_users;
        public SigninPage()
        {
            InitializeComponent();
            loginfield.Text = "Логин";
            passwordfield.Text = "password";
            passwordfield_cpy.Text = "password";
            db_users = new ApplicationContext();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
        }

        private void mutebutton_Click(object sender, EventArgs e)
        {
        }

        private void hidebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = true;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SigninPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            if (loginfield.Text == null || loginfield.Text == "")
            {
                loginfield.Text = "Логин";
            }
            if (passwordfield.Text == null || passwordfield.Text == "")
            {
                passwordfield.Text = "password";
            }
            if (passwordfield_cpy.Text == null || passwordfield_cpy.Text == "")
            {
                passwordfield_cpy.Text = "password";
            }
        }

        private void SigninPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loginfield_MouseDown(object sender, MouseEventArgs e)
        {
            if (loginfield.Text == "Логин")
            {
                loginfield.Text = null;
            }
            if (passwordfield.Text == "")
            {
                passwordfield.Text = "password";
            }
            if (passwordfield_cpy.Text == "")
            {
                passwordfield_cpy.Text = "password";
            }
        }
        private void passwordfield_MouseDown(object sender, MouseEventArgs e)
        {
            if (loginfield.Text == "")
            {
                loginfield.Text = "Логин";
            }
            if (passwordfield.Text == "password")
            {
                passwordfield.Text = null;
            }
            if (passwordfield_cpy.Text == "")
            {
                passwordfield_cpy.Text = "password";
            }
        }

        private void passwordfield_cpy_MouseDown(object sender, MouseEventArgs e)
        {
            if (loginfield.Text == "Логин" || loginfield.Text == "")
            {
                loginfield.Text = "Логин";
            }
            if (passwordfield.Text == "password" || passwordfield.Text == "")
            {
                passwordfield.Text = "password";
            }
            if (passwordfield_cpy.Text == "password")
            {
                passwordfield_cpy.Text = null;
            }
        }
        private void signinbutton_Click(object sender, EventArgs e) //Кнопка для регистрации
        {

            bool flag2 = false;
            string login = loginfield.Text.Trim();
            string password = passwordfield.Text.Trim();
            string password_cpy = passwordfield_cpy.Text.Trim();
            //Проверка на существование такого пользователя
            List<Request> requests = db_users.Requests.ToList();
            foreach (Request request in requests)
            {
                if (request.Username == login)
                {
                    flag2 = true;
                }
            }
            if (flag2) //При существовании
            {
                for (int i = 0; i < 2; i++)
                {
                }
                MessageBox.Show("Данное имя пользователя уже занято");
            }
            else if (login == "Логин")
            {
                MessageBox.Show("Введите имя пользователя");
            }
            else if (password == "password") 
            {
                MessageBox.Show("Введите корректный пароль");
            }
            //Проверка на совпадение паролей в полях пароль и повторение пароля
            else if (password != password_cpy) //При несовпадении
            {
                MessageBox.Show("Пароли не совпадают");
                for (int i = 0; i < 2; i++)
                {
                }
            }
            else //При совпадении
            {
                password = RSA.GetHash(login + password);
                //Сохранение пользователя в базу данных(регистрация)
                User user = new User(login, password);
                db_users.Users.Add(user);
                db_users.SaveChanges();
                this.Close();
            }
        }
    }
}
