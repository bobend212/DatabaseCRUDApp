namespace ProjectCRUDLoginFormApp
{
    partial class AdminUpdateUser
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
            this.bClose = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.groupUpdateUsers = new System.Windows.Forms.GroupBox();
            this.txtIDAdminPanelUPD = new System.Windows.Forms.TextBox();
            this.liD = new System.Windows.Forms.Label();
            this.comboRoleAdminPanelUPD = new System.Windows.Forms.ComboBox();
            this.txtPasswordAdminPanelUPD = new System.Windows.Forms.TextBox();
            this.txtLoginAdminPanelUPD = new System.Windows.Forms.TextBox();
            this.txtEmailAdminPanelUPD = new System.Windows.Forms.TextBox();
            this.txtLastNameAdminPanelUPD = new System.Windows.Forms.TextBox();
            this.txtFirstNameAdminPanelUPD = new System.Windows.Forms.TextBox();
            this.lRoleAdminPanel = new System.Windows.Forms.Label();
            this.lLastNameAdminPanel = new System.Windows.Forms.Label();
            this.lEmailAdminPanel = new System.Windows.Forms.Label();
            this.lLoginAdminPanel = new System.Windows.Forms.Label();
            this.lPasswordAdminPanel = new System.Windows.Forms.Label();
            this.lFirstNameAdminPanel = new System.Windows.Forms.Label();
            this.groupUpdateUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bClose.Location = new System.Drawing.Point(229, 267);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(184, 52);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.Green;
            this.bUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bUpdate.Location = new System.Drawing.Point(12, 267);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(184, 52);
            this.bUpdate.TabIndex = 4;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // groupUpdateUsers
            // 
            this.groupUpdateUsers.Controls.Add(this.txtIDAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.liD);
            this.groupUpdateUsers.Controls.Add(this.comboRoleAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.txtPasswordAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.txtLoginAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.txtEmailAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.txtLastNameAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.txtFirstNameAdminPanelUPD);
            this.groupUpdateUsers.Controls.Add(this.lRoleAdminPanel);
            this.groupUpdateUsers.Controls.Add(this.lLastNameAdminPanel);
            this.groupUpdateUsers.Controls.Add(this.lEmailAdminPanel);
            this.groupUpdateUsers.Controls.Add(this.lLoginAdminPanel);
            this.groupUpdateUsers.Controls.Add(this.lPasswordAdminPanel);
            this.groupUpdateUsers.Controls.Add(this.lFirstNameAdminPanel);
            this.groupUpdateUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupUpdateUsers.Location = new System.Drawing.Point(12, 12);
            this.groupUpdateUsers.Name = "groupUpdateUsers";
            this.groupUpdateUsers.Size = new System.Drawing.Size(401, 249);
            this.groupUpdateUsers.TabIndex = 3;
            this.groupUpdateUsers.TabStop = false;
            this.groupUpdateUsers.Text = "Update user";
            // 
            // txtIDAdminPanelUPD
            // 
            this.txtIDAdminPanelUPD.Enabled = false;
            this.txtIDAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIDAdminPanelUPD.Location = new System.Drawing.Point(291, 203);
            this.txtIDAdminPanelUPD.Multiline = true;
            this.txtIDAdminPanelUPD.Name = "txtIDAdminPanelUPD";
            this.txtIDAdminPanelUPD.ReadOnly = true;
            this.txtIDAdminPanelUPD.Size = new System.Drawing.Size(94, 21);
            this.txtIDAdminPanelUPD.TabIndex = 13;
            // 
            // liD
            // 
            this.liD.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liD.ForeColor = System.Drawing.Color.Yellow;
            this.liD.Location = new System.Drawing.Point(254, 199);
            this.liD.Name = "liD";
            this.liD.Size = new System.Drawing.Size(40, 28);
            this.liD.TabIndex = 12;
            this.liD.Text = "ID:";
            // 
            // comboRoleAdminPanelUPD
            // 
            this.comboRoleAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboRoleAdminPanelUPD.FormattingEnabled = true;
            this.comboRoleAdminPanelUPD.Items.AddRange(new object[] {
            "USER",
            "ADMIN"});
            this.comboRoleAdminPanelUPD.Location = new System.Drawing.Point(118, 199);
            this.comboRoleAdminPanelUPD.Name = "comboRoleAdminPanelUPD";
            this.comboRoleAdminPanelUPD.Size = new System.Drawing.Size(121, 24);
            this.comboRoleAdminPanelUPD.TabIndex = 11;
            // 
            // txtPasswordAdminPanelUPD
            // 
            this.txtPasswordAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPasswordAdminPanelUPD.Location = new System.Drawing.Point(117, 165);
            this.txtPasswordAdminPanelUPD.Multiline = true;
            this.txtPasswordAdminPanelUPD.Name = "txtPasswordAdminPanelUPD";
            this.txtPasswordAdminPanelUPD.Size = new System.Drawing.Size(268, 21);
            this.txtPasswordAdminPanelUPD.TabIndex = 10;
            // 
            // txtLoginAdminPanelUPD
            // 
            this.txtLoginAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginAdminPanelUPD.Location = new System.Drawing.Point(117, 131);
            this.txtLoginAdminPanelUPD.Multiline = true;
            this.txtLoginAdminPanelUPD.Name = "txtLoginAdminPanelUPD";
            this.txtLoginAdminPanelUPD.Size = new System.Drawing.Size(268, 21);
            this.txtLoginAdminPanelUPD.TabIndex = 9;
            // 
            // txtEmailAdminPanelUPD
            // 
            this.txtEmailAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmailAdminPanelUPD.Location = new System.Drawing.Point(117, 97);
            this.txtEmailAdminPanelUPD.Multiline = true;
            this.txtEmailAdminPanelUPD.Name = "txtEmailAdminPanelUPD";
            this.txtEmailAdminPanelUPD.Size = new System.Drawing.Size(268, 21);
            this.txtEmailAdminPanelUPD.TabIndex = 8;
            // 
            // txtLastNameAdminPanelUPD
            // 
            this.txtLastNameAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastNameAdminPanelUPD.Location = new System.Drawing.Point(117, 63);
            this.txtLastNameAdminPanelUPD.Multiline = true;
            this.txtLastNameAdminPanelUPD.Name = "txtLastNameAdminPanelUPD";
            this.txtLastNameAdminPanelUPD.Size = new System.Drawing.Size(268, 21);
            this.txtLastNameAdminPanelUPD.TabIndex = 7;
            // 
            // txtFirstNameAdminPanelUPD
            // 
            this.txtFirstNameAdminPanelUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFirstNameAdminPanelUPD.Location = new System.Drawing.Point(117, 29);
            this.txtFirstNameAdminPanelUPD.Multiline = true;
            this.txtFirstNameAdminPanelUPD.Name = "txtFirstNameAdminPanelUPD";
            this.txtFirstNameAdminPanelUPD.Size = new System.Drawing.Size(268, 21);
            this.txtFirstNameAdminPanelUPD.TabIndex = 6;
            // 
            // lRoleAdminPanel
            // 
            this.lRoleAdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRoleAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.lRoleAdminPanel.Location = new System.Drawing.Point(6, 199);
            this.lRoleAdminPanel.Name = "lRoleAdminPanel";
            this.lRoleAdminPanel.Size = new System.Drawing.Size(105, 34);
            this.lRoleAdminPanel.TabIndex = 5;
            this.lRoleAdminPanel.Text = "Role";
            // 
            // lLastNameAdminPanel
            // 
            this.lLastNameAdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLastNameAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.lLastNameAdminPanel.Location = new System.Drawing.Point(6, 63);
            this.lLastNameAdminPanel.Name = "lLastNameAdminPanel";
            this.lLastNameAdminPanel.Size = new System.Drawing.Size(105, 34);
            this.lLastNameAdminPanel.TabIndex = 4;
            this.lLastNameAdminPanel.Text = "Last Name";
            // 
            // lEmailAdminPanel
            // 
            this.lEmailAdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmailAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.lEmailAdminPanel.Location = new System.Drawing.Point(6, 97);
            this.lEmailAdminPanel.Name = "lEmailAdminPanel";
            this.lEmailAdminPanel.Size = new System.Drawing.Size(105, 34);
            this.lEmailAdminPanel.TabIndex = 3;
            this.lEmailAdminPanel.Text = "Email";
            // 
            // lLoginAdminPanel
            // 
            this.lLoginAdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLoginAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.lLoginAdminPanel.Location = new System.Drawing.Point(6, 131);
            this.lLoginAdminPanel.Name = "lLoginAdminPanel";
            this.lLoginAdminPanel.Size = new System.Drawing.Size(105, 34);
            this.lLoginAdminPanel.TabIndex = 2;
            this.lLoginAdminPanel.Text = "Login";
            // 
            // lPasswordAdminPanel
            // 
            this.lPasswordAdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPasswordAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.lPasswordAdminPanel.Location = new System.Drawing.Point(6, 165);
            this.lPasswordAdminPanel.Name = "lPasswordAdminPanel";
            this.lPasswordAdminPanel.Size = new System.Drawing.Size(105, 34);
            this.lPasswordAdminPanel.TabIndex = 1;
            this.lPasswordAdminPanel.Text = "Password";
            // 
            // lFirstNameAdminPanel
            // 
            this.lFirstNameAdminPanel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFirstNameAdminPanel.ForeColor = System.Drawing.Color.Yellow;
            this.lFirstNameAdminPanel.Location = new System.Drawing.Point(6, 29);
            this.lFirstNameAdminPanel.Name = "lFirstNameAdminPanel";
            this.lFirstNameAdminPanel.Size = new System.Drawing.Size(105, 34);
            this.lFirstNameAdminPanel.TabIndex = 0;
            this.lFirstNameAdminPanel.Text = "First Name";
            // 
            // AdminUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(433, 331);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.groupUpdateUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUpdateUser";
            this.groupUpdateUsers.ResumeLayout(false);
            this.groupUpdateUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.GroupBox groupUpdateUsers;
        private System.Windows.Forms.ComboBox comboRoleAdminPanelUPD;
        private System.Windows.Forms.TextBox txtPasswordAdminPanelUPD;
        private System.Windows.Forms.TextBox txtLoginAdminPanelUPD;
        private System.Windows.Forms.TextBox txtEmailAdminPanelUPD;
        private System.Windows.Forms.TextBox txtLastNameAdminPanelUPD;
        private System.Windows.Forms.TextBox txtFirstNameAdminPanelUPD;
        private System.Windows.Forms.Label lRoleAdminPanel;
        private System.Windows.Forms.Label lLastNameAdminPanel;
        private System.Windows.Forms.Label lEmailAdminPanel;
        private System.Windows.Forms.Label lLoginAdminPanel;
        private System.Windows.Forms.Label lPasswordAdminPanel;
        private System.Windows.Forms.Label lFirstNameAdminPanel;
        private System.Windows.Forms.TextBox txtIDAdminPanelUPD;
        private System.Windows.Forms.Label liD;
    }
}