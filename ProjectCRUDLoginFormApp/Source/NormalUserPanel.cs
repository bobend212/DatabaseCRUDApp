using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectCRUDLoginFormApp
{
    public partial class NormalUserPanel : Form
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string UEmail { get; set; }
        public string UId { get; set; }

        string connectionString = @"Data Source = DESKTOP-3P9I28U\MATEUSZSQL; Initial Catalog = ProjectCRUDLoginForm; Integrated Security =True";
        DataTable dt;

        public NormalUserPanel()
        {
            InitializeComponent();
            RefreshTable();
            timer1.Start();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void NormalUserPanel_Load(object sender, EventArgs e)
        {
            lDisplayFirstName.Text = FName.ToUpper();
            lDisplayLastName.Text = LName.ToUpper();
            lDisplayEmail.Text = UEmail.ToUpper();
            lDisplayUserID.Text = UId.ToString();
            lDate.Text = "Current Date: " + DateTime.Now.ToShortDateString() + " (" + DateTime.Now.DayOfWeek.ToString() + ")";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lTime.Text = "Current Time: " + currentTime.ToString("hh:mm:ss tt");
        }

        private void RefreshTable()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("showUserNotes", sqlConn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sqlCmd.Parameters.Add(new SqlParameter("@UserID", lDisplayUserID.Text.Trim()));
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand = sqlCmd;
                dt = new DataTable();
                sda.Fill(dt);

                dgvNotes.DefaultCellStyle.Font = new Font("Arial", 11, GraphicsUnit.Pixel);
                dgvNotes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvNotes.DataSource = dt;
                dgvNotes.Columns[0].Visible = false;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddNewNote();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void RemoveNote()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDeleteNote", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", dgvNotes.SelectedRows[0].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            int currCell = dgvNotes.CurrentCell.RowIndex;
            dgvNotes.Rows.RemoveAt(currCell);
        }

        private void AddNewNote()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("spAddNewNote", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserID", lDisplayUserID.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Note", txtNewNote.Text.Trim());
                sqlCmd.ExecuteNonQuery();
            }
            txtNewNote.Text = "";
            RefreshTable();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void dgvNotes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvNotes.CurrentCell.RowIndex;
            int columnindex = dgvNotes.CurrentCell.ColumnIndex;

            if (dgvNotes.CurrentRow != null)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    DataGridViewRow dgvRow = dgvNotes.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("spEditNote", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NoteId", dgvNotes.SelectedRows[0].Cells[0].Value);
                    sqlCmd.Parameters.AddWithValue("@Note", dgvNotes.SelectedRows[0].Cells[1].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    RefreshTable();
                }
                MessageBox.Show("Note changed successfully.", "Update note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
