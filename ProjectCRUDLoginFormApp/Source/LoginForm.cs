using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectCRUDLoginFormApp
{
    public partial class LoginForm : Form
    {
        private string connString = ConfigurationManager.ConnectionStrings
            ["ProjectCRUDLoginFormApp.Properties.Settings.ProjectCRUDLoginFormConnectionString"].ConnectionString;

        private String fname;
        private String lname;

        #region Constructor
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Buttons Methods
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            logIn();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logIn();
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region Other Methods
        private void logIn()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("spLogInChecking", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                int count = dataSet.Tables[0].Rows.Count;

                if (count == 1)
                {
                    this.getUserNameAndLastName(txtLogin.Text);
                    this.Hide();
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Uname = fname.Trim();
                    adminPanel.Lname = lname.Trim();
                    adminPanel.Show();
                }
                else
                {
                    txtLogin.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Wrong login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLogin.Focus();
                }
            }
        }

        private void getUserNameAndLastName(String Login)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("spGetUserName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                con.Open();
                cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    fname = rdr["FirstName"].ToString();
                    lname = rdr["LastName"].ToString();
                }
            }
        }
        #endregion
    }
}
