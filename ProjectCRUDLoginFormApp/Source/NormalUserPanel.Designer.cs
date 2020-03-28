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
            this.lDisplayUserID = new System.Windows.Forms.Label();
            this.lUserId = new System.Windows.Forms.Label();
            this.lDisplayEmail = new System.Windows.Forms.Label();
            this.lDisplayLastName = new System.Windows.Forms.Label();
            this.lDisplayFirstName = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lBottomLabel = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.lDate = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.gbNotes = new System.Windows.Forms.GroupBox();
            this.txtNewNote = new System.Windows.Forms.RichTextBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.gbNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDragMe
            // 
            this.lDragMe.BackColor = System.Drawing.Color.LightCoral;
            this.lDragMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lDragMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDragMe.Location = new System.Drawing.Point(0, 0);
            this.lDragMe.Name = "lDragMe";
            this.lDragMe.Size = new System.Drawing.Size(503, 19);
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
            this.lDashboardInfo.Size = new System.Drawing.Size(503, 27);
            this.lDashboardInfo.TabIndex = 1;
            this.lDashboardInfo.Text = "Normal User DASHBOARD";
            this.lDashboardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lDisplayUserID);
            this.groupInfo.Controls.Add(this.lUserId);
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
            this.groupInfo.Size = new System.Drawing.Size(483, 130);
            this.groupInfo.TabIndex = 2;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "About Me";
            // 
            // lDisplayUserID
            // 
            this.lDisplayUserID.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayUserID.ForeColor = System.Drawing.Color.White;
            this.lDisplayUserID.Location = new System.Drawing.Point(133, 30);
            this.lDisplayUserID.Name = "lDisplayUserID";
            this.lDisplayUserID.Size = new System.Drawing.Size(329, 23);
            this.lDisplayUserID.TabIndex = 9;
            this.lDisplayUserID.Text = "1";
            // 
            // lUserId
            // 
            this.lUserId.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lUserId.Location = new System.Drawing.Point(5, 30);
            this.lUserId.Name = "lUserId";
            this.lUserId.Size = new System.Drawing.Size(131, 23);
            this.lUserId.TabIndex = 8;
            this.lUserId.Text = "ID:";
            // 
            // lDisplayEmail
            // 
            this.lDisplayEmail.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayEmail.ForeColor = System.Drawing.Color.White;
            this.lDisplayEmail.Location = new System.Drawing.Point(133, 99);
            this.lDisplayEmail.Name = "lDisplayEmail";
            this.lDisplayEmail.Size = new System.Drawing.Size(329, 23);
            this.lDisplayEmail.TabIndex = 7;
            this.lDisplayEmail.Text = "example@op.pl";
            // 
            // lDisplayLastName
            // 
            this.lDisplayLastName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayLastName.ForeColor = System.Drawing.Color.White;
            this.lDisplayLastName.Location = new System.Drawing.Point(133, 76);
            this.lDisplayLastName.Name = "lDisplayLastName";
            this.lDisplayLastName.Size = new System.Drawing.Size(329, 23);
            this.lDisplayLastName.TabIndex = 6;
            this.lDisplayLastName.Text = "Surname";
            // 
            // lDisplayFirstName
            // 
            this.lDisplayFirstName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDisplayFirstName.ForeColor = System.Drawing.Color.White;
            this.lDisplayFirstName.Location = new System.Drawing.Point(133, 53);
            this.lDisplayFirstName.Name = "lDisplayFirstName";
            this.lDisplayFirstName.Size = new System.Drawing.Size(329, 23);
            this.lDisplayFirstName.TabIndex = 5;
            this.lDisplayFirstName.Text = "Name";
            // 
            // lEmail
            // 
            this.lEmail.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmail.Location = new System.Drawing.Point(5, 99);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(82, 23);
            this.lEmail.TabIndex = 4;
            this.lEmail.Text = "Email:";
            // 
            // lLastName
            // 
            this.lLastName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLastName.Location = new System.Drawing.Point(5, 76);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(122, 23);
            this.lLastName.TabIndex = 1;
            this.lLastName.Text = "Last Name:";
            // 
            // lFirstName
            // 
            this.lFirstName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFirstName.Location = new System.Drawing.Point(5, 53);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(131, 23);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "First Name:";
            // 
            // lBottomLabel
            // 
            this.lBottomLabel.BackColor = System.Drawing.Color.LightCoral;
            this.lBottomLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lBottomLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lBottomLabel.Location = new System.Drawing.Point(0, 689);
            this.lBottomLabel.Name = "lBottomLabel";
            this.lBottomLabel.Size = new System.Drawing.Size(503, 18);
            this.lBottomLabel.TabIndex = 3;
            this.lBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bExit.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.exit_button;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bExit.Location = new System.Drawing.Point(121, 635);
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
            this.bClose.Location = new System.Drawing.Point(9, 635);
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
            this.lDate.Location = new System.Drawing.Point(1, 175);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(285, 25);
            this.lDate.TabIndex = 13;
            this.lDate.Text = "Date:";
            // 
            // lTime
            // 
            this.lTime.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lTime.Location = new System.Drawing.Point(1, 200);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(285, 25);
            this.lTime.TabIndex = 14;
            this.lTime.Text = "Current time:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvNotes
            // 
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(6, 33);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvNotes.RowTemplate.Height = 20;
            this.dgvNotes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(471, 206);
            this.dgvNotes.TabIndex = 15;
            this.dgvNotes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellValueChanged);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bDelete.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.delete_button;
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.Location = new System.Drawing.Point(343, 545);
            this.bDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(139, 41);
            this.bDelete.TabIndex = 17;
            this.bDelete.Text = "Delete";
            this.bDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAdd.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.add_button;
            this.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAdd.Location = new System.Drawing.Point(343, 500);
            this.bAdd.Margin = new System.Windows.Forms.Padding(2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(139, 41);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "Add";
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // gbNotes
            // 
            this.gbNotes.Controls.Add(this.dgvNotes);
            this.gbNotes.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.gbNotes.Location = new System.Drawing.Point(-1, 228);
            this.gbNotes.Name = "gbNotes";
            this.gbNotes.Size = new System.Drawing.Size(483, 257);
            this.gbNotes.TabIndex = 19;
            this.gbNotes.TabStop = false;
            this.gbNotes.Text = "My Notes";
            // 
            // txtNewNote
            // 
            this.txtNewNote.Location = new System.Drawing.Point(9, 500);
            this.txtNewNote.Name = "txtNewNote";
            this.txtNewNote.Size = new System.Drawing.Size(329, 130);
            this.txtNewNote.TabIndex = 20;
            this.txtNewNote.Text = "";
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bRefresh.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefresh.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.refresh_button;
            this.bRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRefresh.Location = new System.Drawing.Point(343, 590);
            this.bRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(139, 41);
            this.bRefresh.TabIndex = 21;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
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
            this.ClientSize = new System.Drawing.Size(503, 707);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.txtNewNote);
            this.Controls.Add(this.gbNotes);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.gbNotes.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox gbNotes;
        private System.Windows.Forms.RichTextBox txtNewNote;
        private System.Windows.Forms.Label lDisplayUserID;
        private System.Windows.Forms.Label lUserId;
        private System.Windows.Forms.Button bRefresh;
    }
}