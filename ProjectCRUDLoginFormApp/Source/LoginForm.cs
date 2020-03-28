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

        private string fname;
        private string lname;
        private string email;
        private string userId;

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
            if (rbAdmin.Checked)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spLogInCheckingAdmin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    int counter = dataSet.Tables[0].Rows.Count;

                    if (counter == 1)
                    {
                        this.getUserInfoAsAdmin(txtLogin.Text);
                    }
                    else
                    {
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                        MessageBox.Show("Check login/password or wrong rights!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtLogin.Focus();
                    }
                }
            }
            else if (rbNormalUser.Checked)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spLogInCheckingNormalUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    int counter = dataSet.Tables[0].Rows.Count;

                    if (counter == 1)
                    {
                        this.getUserInfo(txtLogin.Text);
                    }
                    else
                    {
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                        MessageBox.Show("Check login/password or wrong rights!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtLogin.Focus();
                    }
                }
            }
        }

        private void getUserInfoAsAdmin(string Login)
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
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Uname = fname.Trim();
            adminPanel.Lname = lname.Trim();
            adminPanel.Show();
        }
        private void getUserInfo(string login)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("spGetUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                con.Open();
                cmd.ExecuteScalar();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    fname = rdr["FirstName"].ToString();
                    lname = rdr["LastName"].ToString();
                    email = rdr["Email"].ToString();
                    userId = rdr[0].ToString();
                }
            }
            this.Hide();
            NormalUserPanel normaluser = new NormalUserPanel();
            normaluser.FName = fname.Trim();
            normaluser.LName = lname.Trim();
            normaluser.UEmail = email.Trim();
            normaluser.UId = userId.Trim();
            normaluser.Show();
        }
        #endregion
    }
}
