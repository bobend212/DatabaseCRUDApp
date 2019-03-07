using System;
using System.Windows.Forms;

namespace ProjectCRUDLoginFormApp
{
    public partial class NormalUserPanel : Form
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string UEmail { get; set; }

        public NormalUserPanel()
        {
            InitializeComponent();
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
            lDate.Text = "Current Date: " + DateTime.Now.ToShortDateString() + " (" + DateTime.Now.DayOfWeek.ToString() + ")";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lTime.Text =  "Current Time: " + currentTime.ToString("hh:mm:ss tt");
        }
    }
}
