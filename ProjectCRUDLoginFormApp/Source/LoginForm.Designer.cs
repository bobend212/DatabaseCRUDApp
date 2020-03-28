namespace ProjectCRUDLoginFormApp
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
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bRegistration = new System.Windows.Forms.Button();
            this.lInfoRegistration = new System.Windows.Forms.Label();
            this.lDragControl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbNormalUser = new System.Windows.Forms.RadioButton();
            this.dragControl1 = new DragControlDemo.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLogin.ForeColor = System.Drawing.Color.Yellow;
            this.lLogin.Location = new System.Drawing.Point(117, 178);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(82, 37);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Login";
            // 
            // lPassword
            // 
            this.lPassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lPassword.Location = new System.Drawing.Point(100, 250);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(118, 37);
            this.lPassword.TabIndex = 2;
            this.lPassword.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(55, 218);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(208, 29);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(55, 290);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(208, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bLogin.Location = new System.Drawing.Point(12, 360);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(146, 46);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Log in";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bExit.Location = new System.Drawing.Point(164, 360);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(146, 46);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bRegistration
            // 
            this.bRegistration.BackColor = System.Drawing.Color.LightGray;
            this.bRegistration.Location = new System.Drawing.Point(93, 445);
            this.bRegistration.Name = "bRegistration";
            this.bRegistration.Size = new System.Drawing.Size(141, 36);
            this.bRegistration.TabIndex = 7;
            this.bRegistration.Text = "Sign in";
            this.bRegistration.UseVisualStyleBackColor = false;
            this.bRegistration.Click += new System.EventHandler(this.bRegistration_Click);
            // 
            // lInfoRegistration
            // 
            this.lInfoRegistration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lInfoRegistration.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lInfoRegistration.Location = new System.Drawing.Point(80, 421);
            this.lInfoRegistration.Name = "lInfoRegistration";
            this.lInfoRegistration.Size = new System.Drawing.Size(172, 21);
            this.lInfoRegistration.TabIndex = 8;
            this.lInfoRegistration.Text = "You haven\'t account yet?";
            // 
            // lDragControl
            // 
            this.lDragControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lDragControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lDragControl.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDragControl.ForeColor = System.Drawing.Color.Gray;
            this.lDragControl.Location = new System.Drawing.Point(0, 0);
            this.lDragControl.Name = "lDragControl";
            this.lDragControl.Size = new System.Drawing.Size(323, 37);
            this.lDragControl.TabIndex = 9;
            this.lDragControl.Text = "drag me";
            this.lDragControl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.loginForm_picture;
            this.pictureBox1.Location = new System.Drawing.Point(93, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbAdmin.Location = new System.Drawing.Point(164, 325);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(78, 25);
            this.rbAdmin.TabIndex = 10;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbNormalUser
            // 
            this.rbNormalUser.AutoSize = true;
            this.rbNormalUser.Checked = true;
            this.rbNormalUser.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rbNormalUser.Location = new System.Drawing.Point(80, 325);
            this.rbNormalUser.Name = "rbNormalUser";
            this.rbNormalUser.Size = new System.Drawing.Size(63, 25);
            this.rbNormalUser.TabIndex = 11;
            this.rbNormalUser.TabStop = true;
            this.rbNormalUser.Text = "User";
            this.rbNormalUser.UseVisualStyleBackColor = true;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.lDragControl;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(323, 490);
            this.Controls.Add(this.rbNormalUser);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.lDragControl);
            this.Controls.Add(this.lInfoRegistration);
            this.Controls.Add(this.bRegistration);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bRegistration;
        private System.Windows.Forms.Label lInfoRegistration;
        private System.Windows.Forms.Label lDragControl;
        private DragControlDemo.DragControl dragControl1;
        public System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbNormalUser;
    }
}

