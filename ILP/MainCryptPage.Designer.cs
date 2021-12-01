
namespace ILP
{
    partial class MainCryptPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCryptPage));
            this.label1 = new System.Windows.Forms.Label();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.decryptbutton = new System.Windows.Forms.Button();
            this.historybutton = new System.Windows.Forms.LinkLabel();
            this.hidebutton = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Label();
            this.helpbutton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите:";
            // 
            // encryptbutton
            // 
            this.encryptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.encryptbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.encryptbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.encryptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptbutton.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.encryptbutton.Location = new System.Drawing.Point(113, 244);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(250, 60);
            this.encryptbutton.TabIndex = 16;
            this.encryptbutton.Text = "Зашифровать";
            this.encryptbutton.UseVisualStyleBackColor = false;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // decryptbutton
            // 
            this.decryptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.decryptbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.decryptbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decryptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptbutton.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.decryptbutton.Location = new System.Drawing.Point(451, 244);
            this.decryptbutton.Name = "decryptbutton";
            this.decryptbutton.Size = new System.Drawing.Size(250, 60);
            this.decryptbutton.TabIndex = 17;
            this.decryptbutton.Text = "Расшифровать";
            this.decryptbutton.UseVisualStyleBackColor = false;
            this.decryptbutton.Click += new System.EventHandler(this.decryptbutton_Click);
            // 
            // historybutton
            // 
            this.historybutton.BackColor = System.Drawing.Color.Transparent;
            this.historybutton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybutton.LinkColor = System.Drawing.Color.White;
            this.historybutton.Location = new System.Drawing.Point(338, 316);
            this.historybutton.Name = "historybutton";
            this.historybutton.Size = new System.Drawing.Size(143, 43);
            this.historybutton.TabIndex = 18;
            this.historybutton.TabStop = true;
            this.historybutton.Text = "История";
            this.historybutton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.historybutton_LinkClicked);
            // 
            // hidebutton
            // 
            this.hidebutton.BackColor = System.Drawing.Color.Transparent;
            this.hidebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidebutton.ForeColor = System.Drawing.Color.Black;
            this.hidebutton.Image = ((System.Drawing.Image)(resources.GetObject("hidebutton.Image")));
            this.hidebutton.Location = new System.Drawing.Point(715, -2);
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.Size = new System.Drawing.Size(34, 33);
            this.hidebutton.TabIndex = 19;
            this.hidebutton.Click += new System.EventHandler(this.hidebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.Color.Black;
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.Location = new System.Drawing.Point(755, -2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(34, 33);
            this.closebutton.TabIndex = 20;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.Color.Transparent;
            this.helpbutton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbutton.LinkColor = System.Drawing.Color.White;
            this.helpbutton.Location = new System.Drawing.Point(671, 408);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(143, 43);
            this.helpbutton.TabIndex = 21;
            this.helpbutton.TabStop = true;
            this.helpbutton.Text = "Помощь";
            this.helpbutton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpbutton_LinkClicked);
            // 
            // MainCryptPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.hidebutton);
            this.Controls.Add(this.historybutton);
            this.Controls.Add(this.decryptbutton);
            this.Controls.Add(this.encryptbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainCryptPage";
            this.Text = "MainCryptPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainCryptPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCryptPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryptbutton;
        private System.Windows.Forms.Button decryptbutton;
        private System.Windows.Forms.LinkLabel historybutton;
        private System.Windows.Forms.Label hidebutton;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.LinkLabel helpbutton;
    }
}