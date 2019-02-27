using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCRUDLoginFormApp
{
    public partial class AdminPanel : Form
    {
        string connectionString = @"Data Source = DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog = ProjectCRUDLoginForm; Integrated Security =True";
        SqlDataAdapter sqlCmd;

        private String uname;

        public String Uname
        {
            get { return uname; }
            set { uname = value; }
        }

        private String lname;

        public String Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public AdminPanel()
        {
            InitializeComponent();
        }

        #region ButtonsMethods 

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SelectAllFromTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while reading database!");
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AdminAddUsers addNewUser = new AdminAddUsers();
            addNewUser.Show();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string nameToDelete = dataTableViev.SelectedRows[0].Cells[2].Value.ToString();
            string lastNameToDelete = dataTableViev.SelectedRows[0].Cells[3].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"Do you want delete: {nameToDelete} {lastNameToDelete} from database?", "DELETING...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        #endregion

        #region Methods

        private void DeleteRecord()
        {

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                sqlCmd = new SqlDataAdapter("DELETE FROM tblUsers WHERE ID = '" + dataTableViev.SelectedRows[0].Cells[0].Value.ToString() + "'", sqlConn);
                sqlCmd.SelectCommand.ExecuteNonQuery();
                sqlConn.Close();
            }
            
            int currCell = dataTableViev.CurrentCell.RowIndex;
            dataTableViev.Rows.RemoveAt(currCell);

        }

        private void SelectAllFromTable()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("spShowTableInPanelAdmin", sqlConn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataTableViev.DataSource = dt;
            }
        }
        #endregion

        private void bUpdate_Click(object sender, EventArgs e)
        {
            AdminUpdateUser aU = new AdminUpdateUser(
                dataTableViev.SelectedRows[0].Cells[0].Value.ToString(),
                dataTableViev.SelectedRows[0].Cells[1].Value.ToString(),
                dataTableViev.SelectedRows[0].Cells[2].Value.ToString(),
                dataTableViev.SelectedRows[0].Cells[3].Value.ToString(),
                dataTableViev.SelectedRows[0].Cells[4].Value.ToString(),
                dataTableViev.SelectedRows[0].Cells[5].Value.ToString(),
                dataTableViev.SelectedRows[0].Cells[6].Value.ToString()
                );
            aU.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lWelcome.Text = "Hi, " + Uname + " " + Lname;
        }
        
    }
}