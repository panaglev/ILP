using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILP
{
    public partial class MainCryptPage : Form
    {
        Point lastPoint;
        private string username;
        public MainCryptPage(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void decryptbutton_Click(object sender, EventArgs e) //Кнопка Расшифровать 
        {
            DecryptPage dp = new DecryptPage(username);
            this.Close();
            dp.Show();
        }

        private void encryptbutton_Click(object sender, EventArgs e) //Кнопка Зашифровать
        {
            EncryptPage ep = new EncryptPage(username);
            this.Close();
            ep.Show();
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

        private void MainCryptPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainCryptPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void historybutton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Надпись история
        {
            ApplicationContext db_requests = new ApplicationContext(); 
            List<Request> requests = db_requests.Requests.ToList(); //Парс всех значений из дб 
            string result = " ";
            foreach (Request request in requests) //Проход по всех спаршеным значениям
            {
                if (request.Username == username) //Если имя пользователя текущего пользователя
                {
                    result += "Operation: " + request.Operation + " Result: " + request.Result + "\n"; //Добавляем результат на вывод
                }
                else 
                {
                    continue;
                }
            }
            MessageBox.Show(result); //Выводм историю в виде окна
        }

        private void helpbutton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("1. Для того чтобы зашифровать текст нажмите кнопку Зашифровать, в качестве публичного и приватного ключа можете использовать e = 5 d = 173 n = 323" + "\n" +
                "2. Для того чтобы расшифровать текст введите шифротекст или откройте файл с ним и введите приватный ключ" + "\n" +
                "3. Чтобы посмотреть историю действий нажмите \"История\"");
        }
    }
}
