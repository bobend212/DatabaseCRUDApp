using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ProjectCRUDLoginFormApp
{
    public partial class RegistrationForm : Form, IValidators
    {
        string connectionString = @"Data Source = DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog = ProjectCRUDLoginForm; Integrated Security =True";
        LoginForm loginForm = new LoginForm();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        #region Buttons Methods

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();

        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            AddNewRecord();
        }
        #endregion

        #region Validations

        public void ClearAllFields()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtLoginRegistration.Text = txtPasswordRegistration.Text = txtConfirmPasswordRegistration.Text = "";
        }

        public bool CheckIfLoginExist()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("spDetectIfLoginExist", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Login", txtLoginRegistration.Text);

                int UserExist = (int)sqlCmd.ExecuteScalar();

                if (UserExist > 0)
                    return false;
                else
                    return true;      
            }
        }

        public bool CheckIfEmailExist()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("spDetectIfEmailExist", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                int EmailExist = (int)sqlCmd.ExecuteScalar();

                if (EmailExist > 0)
                    return false;
                else
                    return true;
            }
        }

        public bool EmailValidator()
        {
            string emailChecker = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailChecker);
            if (!(match.Success))
                return false;
            else
                return true;
        }

        public bool PasswordValidation()
        {
            string PasswordChecker = txtPasswordRegistration.Text;
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
            Match match = regex.Match(PasswordChecker);
            if (!(match.Success))
                return false;
            else
                return true;
        }

        public void AddNewRecord()
        {
            if (txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtEmail.Text == "" ||
                txtLoginRegistration.Text == "" ||
                txtPasswordRegistration.Text == "" ||
                txtConfirmPasswordRegistration.Text == "")
            {
                MessageBox.Show("Fill up all!");
            }
            else if (txtPasswordRegistration.Text != txtConfirmPasswordRegistration.Text)
            {
                MessageBox.Show("Incorrect password!");
            }
            else if (CheckIfLoginExist() == false)
            {
                MessageBox.Show("This Login already exist, choose different!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CheckIfEmailExist() == false)
            {
                MessageBox.Show("This EMAIL already exist, choose different!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (EmailValidator() == false)
            {
                MessageBox.Show("EMAIL is INCORRECT!");
            }
            else if (PasswordValidation() == false)
            {
                MessageBox.Show("Password MUST contain:" + "\n"
                    + "- Min. 8 characters" + "\n" + "- Max. 15 characters" + "\n"
                    + "- Min. One uppercase and lowercase letter" + "\n"
                    + "- Min. One number.");
            }
            else
            {
                AddNewRecordAsUser();
            }
        }
        #endregion

        #region Other Methods
        private void AddNewRecordAsUser()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("spUserRegistration", sqlConn);

                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Login", txtLoginRegistration.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPasswordRegistration.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Role", txtRole.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                ClearAllFields();
                this.Hide();
                loginForm.Show();
                MessageBox.Show("ACCOUNT CREATED SUCCESSFULLY!", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
