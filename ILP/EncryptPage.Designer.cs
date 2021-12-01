
namespace ILP
{
    partial class EncryptPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptPage));
            this.closebutton = new System.Windows.Forms.Label();
            this.hidebutton = new System.Windows.Forms.Label();
            this.saveinfilebutton = new System.Windows.Forms.Button();
            this.outputtextfield = new System.Windows.Forms.TextBox();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.inputtextfield = new System.Windows.Forms.TextBox();
            this.n_field = new System.Windows.Forms.TextBox();
            this.expfield = new System.Windows.Forms.TextBox();
            this.nfield = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.closebutton.TabIndex = 22;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
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
            this.hidebutton.TabIndex = 21;
            this.hidebutton.Click += new System.EventHandler(this.hidebutton_Click);
            // 
            // saveinfilebutton
            // 
            this.saveinfilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.saveinfilebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveinfilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveinfilebutton.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.saveinfilebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.saveinfilebutton.Location = new System.Drawing.Point(403, 233);
            this.saveinfilebutton.Name = "saveinfilebutton";
            this.saveinfilebutton.Size = new System.Drawing.Size(250, 60);
            this.saveinfilebutton.TabIndex = 30;
            this.saveinfilebutton.Text = "Сохранить в ...";
            this.saveinfilebutton.UseVisualStyleBackColor = false;
            this.saveinfilebutton.Click += new System.EventHandler(this.saveinfilebutton_Click);
            // 
            // outputtextfield
            // 
            this.outputtextfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.outputtextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputtextfield.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.outputtextfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.outputtextfield.Location = new System.Drawing.Point(147, 299);
            this.outputtextfield.Multiline = true;
            this.outputtextfield.Name = "outputtextfield";
            this.outputtextfield.Size = new System.Drawing.Size(506, 90);
            this.outputtextfield.TabIndex = 29;
            // 
            // encryptbutton
            // 
            this.encryptbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.encryptbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.encryptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptbutton.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.encryptbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(95)))));
            this.encryptbutton.Location = new System.Drawing.Point(147, 233);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(250, 60);
            this.encryptbutton.TabIndex = 28;
            this.encryptbutton.Text = "Зашифровать";
            this.encryptbutton.UseVisualStyleBackColor = false;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // inputtextfield
            // 
            this.inputtextfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.inputtextfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputtextfield.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtextfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.inputtextfield.Location = new System.Drawing.Point(147, 137);
            this.inputtextfield.Multiline = true;
            this.inputtextfield.Name = "inputtextfield";
            this.inputtextfield.Size = new System.Drawing.Size(506, 90);
            this.inputtextfield.TabIndex = 27;
            this.inputtextfield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputtextfield_MouseDown);
            // 
            // n_field
            // 
            this.n_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.n_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_field.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.n_field.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.n_field.Location = new System.Drawing.Point(507, 62);
            this.n_field.Multiline = true;
            this.n_field.Name = "n_field";
            this.n_field.Size = new System.Drawing.Size(146, 62);
            this.n_field.TabIndex = 26;
            this.n_field.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n_field_MouseDown);
            // 
            // expfield
            // 
            this.expfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.expfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expfield.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.expfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.expfield.Location = new System.Drawing.Point(236, 62);
            this.expfield.Multiline = true;
            this.expfield.Name = "expfield";
            this.expfield.Size = new System.Drawing.Size(146, 62);
            this.expfield.TabIndex = 25;
            this.expfield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.expfield_MouseDown);
            // 
            // nfield
            // 
            this.nfield.BackColor = System.Drawing.Color.Transparent;
            this.nfield.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.nfield.Location = new System.Drawing.Point(434, 67);
            this.nfield.Name = "nfield";
            this.nfield.Size = new System.Drawing.Size(67, 50);
            this.nfield.TabIndex = 24;
            this.nfield.Text = "n = ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 50);
            this.label1.TabIndex = 23;
            this.label1.Text = "e = ";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.Location = new System.Drawing.Point(2, -4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(34, 33);
            this.backbutton.TabIndex = 31;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // EncryptPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.saveinfilebutton);
            this.Controls.Add(this.outputtextfield);
            this.Controls.Add(this.encryptbutton);
            this.Controls.Add(this.inputtextfield);
            this.Controls.Add(this.n_field);
            this.Controls.Add(this.expfield);
            this.Controls.Add(this.nfield);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.hidebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncryptPage";
            this.Text = "EncryptPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EncryptPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EncryptPage_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.Label hidebutton;
        private System.Windows.Forms.Button saveinfilebutton;
        private System.Windows.Forms.TextBox outputtextfield;
        private System.Windows.Forms.Button encryptbutton;
        private System.Windows.Forms.TextBox inputtextfield;
        private System.Windows.Forms.TextBox n_field;
        private System.Windows.Forms.TextBox expfield;
        private System.Windows.Forms.Label nfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backbutton;
    }
}