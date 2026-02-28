using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thursday_Gen_Quiz
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void applicationBtn_Click(object sender, EventArgs e)
        {
            ApplicationForm appForm = new ApplicationForm();
            appForm.Show();
            this.Hide();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            ApplicationStatus statusForm = new ApplicationStatus();
            statusForm.Show();
            this.Hide();
        }

        private void hrBtn_Click(object sender, EventArgs e)
        {
                HRForm hrForm = new HRForm();
                hrForm.Show();
                this.Hide();
            
        }
    }
}
