namespace SQLi
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.PictureboxPassword = new System.Windows.Forms.PictureBox();
            this.PictureboxUser = new System.Windows.Forms.PictureBox();
            this.Textbox_username = new System.Windows.Forms.TextBox();
            this.Textbox_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ButtonCancel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Firebrick;
            this.ButtonCancel.Location = new System.Drawing.Point(123, 317);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(195, 57);
            this.ButtonCancel.TabIndex = 30;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ButtonLogin.Location = new System.Drawing.Point(322, 317);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(195, 57);
            this.ButtonLogin.TabIndex = 29;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.MistyRose;
            this.LabelLogin.Location = new System.Drawing.Point(151, 21);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(277, 98);
            this.LabelLogin.TabIndex = 28;
            this.LabelLogin.Text = "LOGIN";
            // 
            // PictureboxPassword
            // 
            this.PictureboxPassword.Image = ((System.Drawing.Image)(resources.GetObject("PictureboxPassword.Image")));
            this.PictureboxPassword.Location = new System.Drawing.Point(43, 234);
            this.PictureboxPassword.Name = "PictureboxPassword";
            this.PictureboxPassword.Size = new System.Drawing.Size(63, 51);
            this.PictureboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureboxPassword.TabIndex = 27;
            this.PictureboxPassword.TabStop = false;
            // 
            // PictureboxUser
            // 
            this.PictureboxUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureboxUser.Image")));
            this.PictureboxUser.Location = new System.Drawing.Point(43, 139);
            this.PictureboxUser.Name = "PictureboxUser";
            this.PictureboxUser.Size = new System.Drawing.Size(63, 61);
            this.PictureboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureboxUser.TabIndex = 26;
            this.PictureboxUser.TabStop = false;
            // 
            // Textbox_username
            // 
            this.Textbox_username.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_username.ForeColor = System.Drawing.Color.Gray;
            this.Textbox_username.Location = new System.Drawing.Point(123, 149);
            this.Textbox_username.Multiline = true;
            this.Textbox_username.Name = "Textbox_username";
            this.Textbox_username.Size = new System.Drawing.Size(394, 51);
            this.Textbox_username.TabIndex = 25;
            // 
            // Textbox_password
            // 
            this.Textbox_password.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_password.ForeColor = System.Drawing.Color.Gray;
            this.Textbox_password.Location = new System.Drawing.Point(123, 234);
            this.Textbox_password.Multiline = true;
            this.Textbox_password.Name = "Textbox_password";
            this.Textbox_password.Size = new System.Drawing.Size(394, 51);
            this.Textbox_password.TabIndex = 24;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.PictureboxPassword);
            this.Controls.Add(this.PictureboxUser);
            this.Controls.Add(this.Textbox_username);
            this.Controls.Add(this.Textbox_password);
            this.Name = "LoginForm";
            this.Text = "22110058 Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.PictureBox PictureboxPassword;
        private System.Windows.Forms.PictureBox PictureboxUser;
        private System.Windows.Forms.TextBox Textbox_username;
        private System.Windows.Forms.TextBox Textbox_password;
    }
}

