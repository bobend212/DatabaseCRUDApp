namespace ProjectCRUDLoginFormApp
{
    partial class NormalUserPanel
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
            this.components = new System.ComponentModel.Container();
            this.lDragMe = new System.Windows.Forms.Label();
            this.lDashboardInfo = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lBottomLabel = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.lDate = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lDisplayFirstName = new System.Windows.Forms.Label();
            this.lDisplayLastName = new System.Windows.Forms.Label();
            this.lDisplayEmail = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dragControl1 = new DragControlDemo.DragControl();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDragMe
            // 
            this.lDragMe.BackColor = System.Drawing.Color.LightCoral;
            this.lDragMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lDragMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDragMe.Location = new System.Drawing.Point(0, 0);
            this.lDragMe.Name = "lDragMe";
            this.lDragMe.Size = new System.Drawing.Size(481, 19);
            this.lDragMe.TabIndex = 0;
            this.lDragMe.Text = "drag me";
            this.lDragMe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lDashboardInfo
            // 
            this.lDashboardInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lDashboardInfo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDashboardInfo.Location = new System.Drawing.Point(0, 19);
            this.lDashboardInfo.Name = "lDashboardInfo";
            this.lDashboardInfo.Size = new System.Drawing.Size(481, 27);
            this.lDashboardInfo.TabIndex = 1;
            this.lDashboardInfo.Text = "Normal User DASHBOARD";
            this.lDashboardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lDisplayEmail);
            this.groupInfo.Controls.Add(this.lDisplayLastName);
            this.groupInfo.Controls.Add(this.lDisplayFirstName);
            this.groupInfo.Controls.Add(this.lEmail);
            this.groupInfo.Controls.Add(this.lLastName);
            this.groupInfo.Controls.Add(this.lFirstName);
            this.groupInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupInfo.Location = new System.Drawing.Point(5, 42);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(469, 113);
            this.groupInfo.TabIndex = 2;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "About you";
            // 
            // lBottomLabel
            // 
            this.lBottomLabel.BackColor = System.Drawing.Color.LightCoral;
            this.lBottomLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lBottomLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lBottomLabel.Location = new System.Drawing.Point(0, 261);
            this.lBottomLabel.Name = "lBottomLabel";
            this.lBottomLabel.Size = new System.Drawing.Size(481, 18);
            this.lBottomLabel.TabIndex = 3;
            this.lBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bExit.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.exit_button;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bExit.Location = new System.Drawing.Point(363, 210);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(108, 45);
            this.bExit.TabIndex = 12;
            this.bExit.Text = "Exit";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Thistle;
            this.bClose.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.log_out_button;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.Location = new System.Drawing.Point(251, 210);
            this.bClose.Margin = new System.Windows.Forms.Padding(2);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(108, 45);
            this.bClose.TabIndex = 11;
            this.bClose.Text = "Log out";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lDate
            // 
            this.lDate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lDate.Location = new System.Drawing.Point(7, 158);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(285, 25);
            this.lDate.TabIndex = 13;
            this.lDate.Text = "Date:";
            // 
            // lTime
            // 
            this.lTime.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lTime.Location = new System.Drawing.Point(7, 183);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(285, 25);
            this.lTime.TabIndex = 14;
            this.lTime.Text = "Current time:";
            // 
            // lFirstName
            // 
            this.lFirstName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFirstName.Location = new System.Drawing.Point(6, 32);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(131, 23);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "First Name:";
            // 
            // lLastName
            // 
            this.lLastName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLastName.Location = new System.Drawing.Point(6, 55);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(122, 23);
            this.lLastName.TabIndex = 1;
            this.lLastName.Text = "Last Name:";
            // 
            // lEmail
            // 
            this.lEmail.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmail.Location = new System.Drawing.Point(6, 78);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(82, 23);
            this.lEmail.TabIndex = 4;
            this.lEmail.Text = "Email:";
            // 
            // lDisplayFirstName
            // 
            this.lDisplayFirstName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayFirstName.ForeColor = System.Drawing.Color.White;
            this.lDisplayFirstName.Location = new System.Drawing.Point(134, 32);
            this.lDisplayFirstName.Name = "lDisplayFirstName";
            this.lDisplayFirstName.Size = new System.Drawing.Size(329, 23);
            this.lDisplayFirstName.TabIndex = 5;
            this.lDisplayFirstName.Text = "Name";
            // 
            // lDisplayLastName
            // 
            this.lDisplayLastName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayLastName.ForeColor = System.Drawing.Color.White;
            this.lDisplayLastName.Location = new System.Drawing.Point(134, 55);
            this.lDisplayLastName.Name = "lDisplayLastName";
            this.lDisplayLastName.Size = new System.Drawing.Size(329, 23);
            this.lDisplayLastName.TabIndex = 6;
            this.lDisplayLastName.Text = "Surname";
            // 
            // lDisplayEmail
            // 
            this.lDisplayEmail.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayEmail.ForeColor = System.Drawing.Color.White;
            this.lDisplayEmail.Location = new System.Drawing.Point(134, 78);
            this.lDisplayEmail.Name = "lDisplayEmail";
            this.lDisplayEmail.Size = new System.Drawing.Size(329, 23);
            this.lDisplayEmail.TabIndex = 7;
            this.lDisplayEmail.Text = "example@op.pl";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.lDragMe;
            // 
            // NormalUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(481, 279);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lBottomLabel);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.lDashboardInfo);
            this.Controls.Add(this.lDragMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NormalUserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormalUserPanel";
            this.Load += new System.EventHandler(this.NormalUserPanel_Load);
            this.groupInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Label lDragMe;
        private System.Windows.Forms.Label lDashboardInfo;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lBottomLabel;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lDisplayFirstName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lDisplayLastName;
        private System.Windows.Forms.Label lDisplayEmail;
        private System.Windows.Forms.Timer timer1;
    }
}