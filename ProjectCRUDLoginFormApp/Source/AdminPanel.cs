using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectCRUDLoginFormApp
{
    public partial class AdminPanel : Form
    {
        string connectionString = @"Data Source = DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog = ProjectCRUDLoginForm; Integrated Security =True";

        public String Uname { get; set; }
        public String Lname { get; set; }

        public AdminPanel()
        {
            InitializeComponent();
        }

        #region Button Methods 

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
                RefreshTable();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while reading database!", "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AdminAddUsers addNewUser = new AdminAddUsers();
            addNewUser.Show();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string nameToDelete = dataTableViev.SelectedRows[0].Cells[2].Value.ToString();
                string lastNameToDelete = dataTableViev.SelectedRows[0].Cells[3].Value.ToString();

                DialogResult dialogResult = MessageBox.Show($"Do you want delete: {nameToDelete} {lastNameToDelete} from database?", "DELETING...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteRecord();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Select record to delete...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
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
            } catch(Exception ex)
            {
                MessageBox.Show("Refresh table and select row which you want update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Other Methods

        private void RefreshTable()
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

        private void DeleteRecord()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteUserAsAdmin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", dataTableViev.SelectedRows[0].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
            }
                int currCell = dataTableViev.CurrentCell.RowIndex;
                dataTableViev.Rows.RemoveAt(currCell);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lWelcome.Text = "Hi, " + Uname.ToUpper() + " " + Lname.ToUpper();
        }
        #endregion
    }
}