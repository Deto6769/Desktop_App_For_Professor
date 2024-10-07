namespace Desktop_App_For_Professor
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.login_top_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_account = new System.Windows.Forms.Label();
            this.label_account_password = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_login_cancel = new System.Windows.Forms.Button();
            this.button_login = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.login_top_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_top_logo
            // 
            this.login_top_logo.Image = ((System.Drawing.Image)(resources.GetObject("login_top_logo.Image")));
            this.login_top_logo.Location = new System.Drawing.Point(12, 12);
            this.login_top_logo.Name = "login_top_logo";
            this.login_top_logo.Size = new System.Drawing.Size(68, 72);
            this.login_top_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_top_logo.TabIndex = 0;
            this.login_top_logo.TabStop = false;
            this.login_top_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_top_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 100);
            this.panel1.TabIndex = 1;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_account.ForeColor = System.Drawing.Color.Gray;
            this.label_account.Location = new System.Drawing.Point(102, 175);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(115, 27);
            this.label_account.TabIndex = 2;
            this.label_account.Text = "Account:";
            this.label_account.Click += new System.EventHandler(this.label_account_id_Click);
            // 
            // label_account_password
            // 
            this.label_account_password.AutoSize = true;
            this.label_account_password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_account_password.ForeColor = System.Drawing.Color.Gray;
            this.label_account_password.Location = new System.Drawing.Point(102, 229);
            this.label_account_password.Name = "label_account_password";
            this.label_account_password.Size = new System.Drawing.Size(121, 27);
            this.label_account_password.TabIndex = 3;
            this.label_account_password.Text = "Password:";
            // 
            // textBox_account
            // 
            this.textBox_account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_account.Location = new System.Drawing.Point(229, 175);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(192, 32);
            this.textBox_account.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(229, 229);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(192, 32);
            this.textBox_password.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_login_cancel
            // 
            this.button_login_cancel.Location = new System.Drawing.Point(449, 303);
            this.button_login_cancel.Name = "button_login_cancel";
            this.button_login_cancel.Size = new System.Drawing.Size(92, 38);
            this.button_login_cancel.TabIndex = 6;
            this.button_login_cancel.Text = "Cancle";
            this.button_login_cancel.UseVisualStyleBackColor = true;
            this.button_login_cancel.Click += new System.EventHandler(this.button_login_cancel_Click);
            // 
            // button_login
            // 
            this.button_login.BorderRadius = 10;
            this.button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(436, 175);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(119, 81);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_login_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label_account_password);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.panel1);
            this.Name = "Form_login";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_top_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox login_top_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Label label_account_password;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_login_cancel;
        private Guna.UI2.WinForms.Guna2Button button_login;
    }
}