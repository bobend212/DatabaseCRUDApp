using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectCRUDLoginFormApp
{
    public partial class AdminUpdateUser : Form
    {
        string connectionString = @"Data Source = DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog = ProjectCRUDLoginForm; Integrated Security =True";

        public AdminUpdateUser(string ID, string Role, string FirstName, string LastName, string Email, string Login, string Password )
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

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            UpdatingRecord();     
        }


        private void UpdatingRecord()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                string updateQuery = "UPDATE tblUsers SET " +
                    "FirstName = '" + txtFirstNameAdminPanelUPD.Text +
                    "', LastName = '" + txtLastNameAdminPanelUPD.Text +
                    "', Email = '" + txtEmailAdminPanelUPD.Text +
                    "', Login = '" + txtLoginAdminPanelUPD.Text +
                    "', Password = '" + txtPasswordAdminPanelUPD.Text +
                    "', Role = '" + comboRoleAdminPanelUPD.Text +
                    "' WHERE ID = '" + txtIDAdminPanelUPD.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(updateQuery, sqlConn);
                adapter.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record updated", "UPDATE");
                this.Close();
            }
        }


    }
}
