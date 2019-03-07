namespace ProjectCRUDLoginFormApp
{
    partial class AdminPanel
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
            this.dataTableViev = new System.Windows.Forms.DataGridView();
            this.lSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lWelcome = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lAdminDashboard = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tipSearchBar = new System.Windows.Forms.ToolTip(this.components);
            this.dragControl1 = new DragControlDemo.DragControl();
            this.lDragMe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableViev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableViev
            // 
            this.dataTableViev.AllowUserToAddRows = false;
            this.dataTableViev.AllowUserToOrderColumns = true;
            this.dataTableViev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableViev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTableViev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataTableViev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTableViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableViev.Location = new System.Drawing.Point(9, 107);
            this.dataTableViev.Margin = new System.Windows.Forms.Padding(2);
            this.dataTableViev.Name = "dataTableViev";
            this.dataTableViev.ReadOnly = true;
            this.dataTableViev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableViev.Size = new System.Drawing.Size(732, 332);
            this.dataTableViev.TabIndex = 0;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.ForeColor = System.Drawing.Color.White;
            this.lSearch.Location = new System.Drawing.Point(677, 50);
            this.lSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(67, 23);
            this.lSearch.TabIndex = 5;
            this.lSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(587, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 23);
            this.txtSearch.TabIndex = 6;
            this.tipSearchBar.SetToolTip(this.txtSearch, "Searching through FirstName, LastName, Email and Login");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lWelcome
            // 
            this.lWelcome.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lWelcome.Location = new System.Drawing.Point(13, 443);
            this.lWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(445, 51);
            this.lWelcome.TabIndex = 7;
            this.lWelcome.Text = "Hi, \'defaultname\'";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(279, 451);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(87, 26);
            this.txtTest.TabIndex = 11;
            this.txtTest.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(636, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 41);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lAdminDashboard
            // 
            this.lAdminDashboard.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdminDashboard.ForeColor = System.Drawing.Color.White;
            this.lAdminDashboard.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.admin;
            this.lAdminDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lAdminDashboard.Location = new System.Drawing.Point(225, 23);
            this.lAdminDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAdminDashboard.Name = "lAdminDashboard";
            this.lAdminDashboard.Size = new System.Drawing.Size(273, 37);
            this.lAdminDashboard.TabIndex = 12;
            this.lAdminDashboard.Text = "Admin Dashboard";
            this.lAdminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bExit.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.exit_button;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bExit.Location = new System.Drawing.Point(462, 443);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(139, 51);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Thistle;
            this.bClose.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.log_out_button;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.Location = new System.Drawing.Point(605, 443);
            this.bClose.Margin = new System.Windows.Forms.Padding(2);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(139, 51);
            this.bClose.TabIndex = 8;
            this.bClose.Text = "Log out";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bRefresh.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefresh.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.refresh_button;
            this.bRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRefresh.Location = new System.Drawing.Point(442, 62);
            this.bRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(139, 41);
            this.bRefresh.TabIndex = 4;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.update_button;
            this.bUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUpdate.Location = new System.Drawing.Point(299, 62);
            this.bUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(139, 41);
            this.bUpdate.TabIndex = 3;
            this.bUpdate.Text = "Update";
            this.bUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bDelete.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Image = global::ProjectCRUDLoginFormApp.Properties.Resources.delete_button;
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.Location = new System.Drawing.Point(156, 62);
            this.bDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(139, 41);
            this.bDelete.TabIndex = 2;
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
            this.bAdd.Location = new System.Drawing.Point(13, 62);
            this.bAdd.Margin = new System.Windows.Forms.Padding(2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(139, 41);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add new";
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tipSearchBar
            // 
            this.tipSearchBar.AutomaticDelay = 100;
            this.tipSearchBar.AutoPopDelay = 1000;
            this.tipSearchBar.ForeColor = System.Drawing.Color.Red;
            this.tipSearchBar.InitialDelay = 20;
            this.tipSearchBar.ReshowDelay = 50;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.lDragMe;
            // 
            // lDragMe
            // 
            this.lDragMe.BackColor = System.Drawing.Color.Sienna;
            this.lDragMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lDragMe.Font = new System.Drawing.Font("Mongolian Baiti", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDragMe.Location = new System.Drawing.Point(0, 0);
            this.lDragMe.Name = "lDragMe";
            this.lDragMe.Size = new System.Drawing.Size(752, 23);
            this.lDragMe.TabIndex = 14;
            this.lDragMe.Text = "drag me";
            this.lDragMe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(752, 499);
            this.Controls.Add(this.lDragMe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lAdminDashboard);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dataTableViev);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableViev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bExit;
        public System.Windows.Forms.DataGridView dataTableViev;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lAdminDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tipSearchBar;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Label lDragMe;
    }
}