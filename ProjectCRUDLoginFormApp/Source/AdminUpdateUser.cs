using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProjectCRUDLoginFormApp
{
    public partial class AdminUpdateUser : Form
    {
        string connectionString = @"Data Source = DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog = ProjectCRUDLoginForm; Integrated Security =True";

        #region Constructor
        public AdminUpdateUser(string ID, string Role, string FirstName, string LastName, string Email, string Login, string Password)
        {
            InitializeComponent();
            
            txtFirstNameAdminPanelUPD.Text = FirstName;
            txtLastNameAdminPanelUPD.Text = LastName;
            txtEmailAdminPanelUPD.Text = Email;
            txtLoginAdminPanelUPD.Text = Login;
            txtPasswordAdminPanelUPD.Text = Password;
            comboRoleAdminPanelUPD.Text = Role;
            txtIDAdminPanelUPD.Text = ID;
        }
        #endregion

        #region Button Methods
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            UpdatingRecord();     
        }
        #endregion

        #region Other Methods
        private void UpdatingRecord()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("spUsersUpdateAsAdmin", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstNameAdminPanelUPD.Text);
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastNameAdminPanelUPD.Text);
                sqlCmd.Parameters.AddWithValue("@Email", txtEmailAdminPanelUPD.Text);
                sqlCmd.Parameters.AddWithValue("@Login", txtLoginAdminPanelUPD.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPasswordAdminPanelUPD.Text);
                sqlCmd.Parameters.AddWithValue("@Role", comboRoleAdminPanelUPD.Text);
                sqlCmd.Parameters.AddWithValue("@ID", txtIDAdminPanelUPD.Text);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully!", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
    }
}
