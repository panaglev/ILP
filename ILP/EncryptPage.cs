using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ILP
{
    public partial class EncryptPage : Form
    {
        private string username;
        Point lastPoint;
        public EncryptPage(string username)
        {
            InitializeComponent();
            this.username = username;
            inputtextfield.Text = "Enter text to encrypt";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainCryptPage mcp = new MainCryptPage(username);
            this.Close();
            mcp.Show();
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

        private void encryptbutton_Click(object sender, EventArgs e) //Кнопка зашифровать
        {
            try
            {
                if (expfield.Text.Length == 0 || n_field.Text.Length == 0) 
                {
                    MessageBox.Show("Введите публичный ключ");
                }
                else if (inputtextfield.Text == "Enter text to encrypt") 
                {
                    MessageBox.Show("Введите текст");
                }
                else 
                {
                    double exp = Convert.ToDouble(expfield.Text);
                    double n = Convert.ToDouble(n_field.Text);
                    string text = inputtextfield.Text;
                    string result = RSA.Encrypt(text, exp, n); //Шифруем с помощью разработанного класса
                    outputtextfield.Text = result; //Помещаем результат операции шифрования в поле вывода
                    //Сохраняем операцию с результатом в историю
                    Request request = new Request(username, "encrypt", result);
                    ApplicationContext db_requests = new ApplicationContext();
                    db_requests.Requests.Add(request);
                    db_requests.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте еще раз");
            }
        }

        private void saveinfilebutton_Click(object sender, EventArgs e)
        {
            try
            {
                double exp = Convert.ToDouble(expfield.Text);
                double n = Convert.ToDouble(n_field.Text);
                string text = inputtextfield.Text;
                string result = RSA.Encrypt(text, exp, n);
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*" })
                {
                    if (sfd.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filename = sfd.FileName;
                    // сохраняем текст в файл
                    System.IO.File.WriteAllText(filename, result);
                    //Сохраняем операцию с результатом в историю
                    Request request = new Request(username, "encrypt", result);
                    ApplicationContext db_requests = new ApplicationContext();
                    db_requests.Requests.Add(request);
                    db_requests.SaveChanges();
                    MessageBox.Show("Файл сохранен");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте еще раз");
            }
        }

        private void EncryptPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            if (inputtextfield.Text == "")
            {
                inputtextfield.Text = "Enter text to encrypt";
            }
        }

        private void EncryptPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void expfield_MouseDown(object sender, MouseEventArgs e)
        {
            if (inputtextfield.Text == "")
            {
                inputtextfield.Text = "Enter text to encrypt";
            }
        }

        private void n_field_MouseDown(object sender, MouseEventArgs e)
        {
            if (inputtextfield.Text == "")
            {
                inputtextfield.Text = "Enter text to encrypt";
            }
        }

        private void inputtextfield_MouseDown(object sender, MouseEventArgs e)
        {
            if (inputtextfield.Text == "Enter text to encrypt")
            {
                inputtextfield.Text = null;
            }
        }
    }
}
