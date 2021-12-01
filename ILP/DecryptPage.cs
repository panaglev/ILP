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
    public partial class DecryptPage : Form
    {
        Point lastPoint;
        private string username;
        public DecryptPage(string username)
        {
            InitializeComponent();
            this.username = username;
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

        private void browsetofilebutton_Click(object sender, EventArgs e) //Кнопка для открытия файла для расшифровки
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathfield.Text = ofd.FileName;
                }
            }
        }

        private void finallybutton_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(dfield.Text);
                double n = Convert.ToDouble(n_field.Text);
                string text = "";
                //4 случая 0 0; 0 1; 1 0; 1 1
                if (pathfield.Text == null && (inputtextfield.Text == "Enter text to decrypt" || inputtextfield.Text == ""))
                {
                    MessageBox.Show("Enter path to file or text to decrypt");
                }
                else if (pathfield.Text == null && (inputtextfield.Text != "Enter text to decrypt" || inputtextfield.Text != ""))
                {
                    text = inputtextfield.Text;
                    outputtextfield.Text = RSA.Decrypt(text, d, n);
                }
                else if (pathfield.Text != null && (inputtextfield.Text == "Enter text to decrypt" || inputtextfield.Text == ""))
                {
                    using (StreamReader sr = new StreamReader(pathfield.Text))
                    {
                        text = sr.ReadToEnd();
                    }
                    string result = RSA.Decrypt(text, d, n);
                    outputtextfield.Text = result;
                    //Add to database
                    Request request = new Request(username, "decrypt", result);
                    ApplicationContext db_requests = new ApplicationContext();
                    db_requests.Requests.Add(request);
                    db_requests.SaveChanges();
                }
                else
                {
                    text = inputtextfield.Text;
                    string result = RSA.Decrypt(text, d, n);
                    outputtextfield.Text = result;
                    //Add to database
                    Request request = new Request(username, "decrypt", result);
                    ApplicationContext db_requests = new ApplicationContext();
                    db_requests.Requests.Add(request);
                    db_requests.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, попробуйте еще раз");
            }
        }

        private void DecryptPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DecryptPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
