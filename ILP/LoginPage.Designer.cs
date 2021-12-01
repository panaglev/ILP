
namespace ILP
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.playbutton = new System.Windows.Forms.Label();
            this.mutebutton = new System.Windows.Forms.Label();
            this.hidebutton = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Label();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.passwordfield = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.signinbutton = new System.Windows.Forms.LinkLabel();
            this.version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.playbutton.Image = ((System.Drawing.Image)(resources.GetObject("playbutton.Image")));
            this.playbutton.Location = new System.Drawing.Point(12, -2);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(34, 33);
            this.playbutton.TabIndex = 9;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // mutebutton
            // 
            this.mutebutton.BackColor = System.Drawing.Color.Transparent;
            this.mutebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.mutebutton.Image = ((System.Drawing.Image)(resources.GetObject("mutebutton.Image")));
            this.mutebutton.Location = new System.Drawing.Point(52, -2);
            this.mutebutton.Name = "mutebutton";
            this.mutebutton.Size = new System.Drawing.Size(34, 33);
            this.mutebutton.TabIndex = 10;
            this.mutebutton.Click += new System.EventHandler(this.mutebutton_Click);
            // 
            // hidebutton
            // 
            this.hidebutton.BackColor = System.Drawing.Color.Transparent;
            this.hidebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidebutton.ForeColor = System.Drawing.Color.Black;
            this.hidebutton.Image = ((System.Drawing.Image)(resources.GetObject("hidebutton.Image")));
            this.hidebutton.Location = new System.Drawing.Point(314, -2);
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.Size = new System.Drawing.Size(34, 33);
            this.hidebutton.TabIndex = 12;
            this.hidebutton.Click += new System.EventHandler(this.hidebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.Color.Black;
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.Location = new System.Drawing.Point(354, -2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(34, 33);
            this.closebutton.TabIndex = 13;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // loginfield
            // 
            this.loginfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.loginfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginfield.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.loginfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.loginfield.Location = new System.Drawing.Point(58, 215);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(290, 59);
            this.loginfield.TabIndex = 14;
            this.loginfield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginfield_MouseDown);
            // 
            // passwordfield
            // 
            this.passwordfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.passwordfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordfield.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.passwordfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.passwordfield.Location = new System.Drawing.Point(58, 303);
            this.passwordfield.Name = "passwordfield";
            this.passwordfield.PasswordChar = '*';
            this.passwordfield.Size = new System.Drawing.Size(290, 59);
            this.passwordfield.TabIndex = 15;
            this.passwordfield.UseSystemPasswordChar = true;
            this.passwordfield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordfield_MouseDown);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(57)))), ((int)(((byte)(104)))));
            this.loginbutton.Location = new System.Drawing.Point(104, 427);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(200, 60);
            this.loginbutton.TabIndex = 16;
            this.loginbutton.Text = "Войти";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // signinbutton
            // 
            this.signinbutton.BackColor = System.Drawing.Color.Transparent;
            this.signinbutton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.LinkColor = System.Drawing.Color.White;
            this.signinbutton.Location = new System.Drawing.Point(62, 490);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(298, 43);
            this.signinbutton.TabIndex = 17;
            this.signinbutton.TabStop = true;
            this.signinbutton.Text = "Зарегистрироваться";
            this.signinbutton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signinbutton_LinkClicked);
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(17)))), ((int)(((byte)(47)))));
            this.version.Location = new System.Drawing.Point(166, 571);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(82, 20);
            this.version.TabIndex = 18;
            this.version.Text = "Alpha 1.0";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.version);
            this.Controls.Add(this.signinbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordfield);
            this.Controls.Add(this.loginfield);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.hidebutton);
            this.Controls.Add(this.mutebutton);
            this.Controls.Add(this.playbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playbutton;
        private System.Windows.Forms.Label mutebutton;
        private System.Windows.Forms.Label hidebutton;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.TextBox passwordfield;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.LinkLabel signinbutton;
        private System.Windows.Forms.Label version;
    }
}