using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace ILP
{
    public partial class LoginPage : Form
    {
        Point lastPoint; //Переменная для координат(чтобы можно было перемещать окно по экрану)
        ToolTip loginToolTip = new ToolTip(); //Подсказка для Логниа
        ToolTip passwordToolTip = new ToolTip(); //Подсказка для Пароля
        public LoginPage()
        {
            InitializeComponent();
            loginfield.Text = "Логин"; //Заполняет поле Логин соответствующим словом
            passwordfield.Text = "password"; //Заполняет поле Пароль соответствующим словом
            loginToolTip.SetToolTip(this.loginfield, "Логин"); //Добавляет подсказку для Логина
            passwordToolTip.SetToolTip(this.passwordfield, "Пароль"); //Добавляет подсказу для Пароля
        }

        private void playbutton_Click(object sender, EventArgs e) //Кнопка для начала проигрывания музыки на заднем фоне
        {
          
        }

        private void mutebutton_Click(object sender, EventArgs e) //Кнопка для прекращения проигрывания музыки на заднем фоне
        {
            
        }

        private void hidebutton_Click(object sender, EventArgs e) //Кнопка для сокрытия окна приложения
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = true;
        }

        private void closebutton_Click(object sender, EventArgs e) //Кнопка для закрытия приложения
        {
            this.Close();
        }

        private void signinbutton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Кнопка для перехода на страницу регистрации
        {
            SigninPage sp = new SigninPage();
            sp.Show();
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e) //Перемещение окна при движении комьпьютерной мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e) //Перемещение окна при зажатии левой кнопки компьютерной мыши 
        {                                                                 //И автозаполнение полей логин и пароль подсказками, если они пустые
            lastPoint = new Point(e.X, e.Y);
            if (loginfield.Text == "")
            {
                loginfield.Text = "Логин";
            }
            if (passwordfield.Text == "")
            {
                passwordfield.Text = "password";
            }
        }

        private void loginfield_MouseDown(object sender, MouseEventArgs e)  //Убирает подсказу в поле Логин и добавляет в поле Пароль
        {
            if (loginfield.Text == "Логин")
            {
                loginfield.Text = null;
            }
            if (passwordfield.Text == "")
            {
                passwordfield.Text = "password";
            }
        }

        private void passwordfield_MouseDown(object sender, MouseEventArgs e) //Убирает подсказку в поле Пароль и добавляет в поле Логин
        {
            if (loginfield.Text == "")
            {
                loginfield.Text = "Логин";
            }
            if (passwordfield.Text == "password")
            {
                passwordfield.Text = null;
            }
        }

        private void loginbutton_Click(object sender, EventArgs e) //Кнопка для входа в приложение
        {
            string login = loginfield.Text.Trim();
            string password = passwordfield.Text.Trim();

            password = RSA.GetHash(login + password);

            User authUser = null;
            using (ApplicationContext context = new ApplicationContext()) 
            {
                authUser = context.Users.Where(b => b.Login == login && b.Hash == password).FirstOrDefault();
            }
            //if (authUser.Login == "Логин") 
            if (authUser == null)
            {
                MessageBox.Show("Некорректные данные для входа");
            }
            else if (authUser != null) 
            {
                string username = login;
                MainCryptPage mcp = new MainCryptPage(username);
                mcp.Show();
            }
            else 
            {
                for (int i = 0; i < 2; i++)
                {
                }
            }
        }
    }
}
