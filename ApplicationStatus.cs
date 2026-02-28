using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thursday_Gen_Quiz
{
    public partial class ApplicationStatus : Form
    {
        string connString;
        int currentCandidateID = 0;
        public ApplicationStatus()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["HireProConnection"].ConnectionString;
        }

        private void ApplicationStatus_Load(object sender, EventArgs e)
        {
            withdrawBtn.Enabled = false;
            updateBtn.Enabled = false;
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "SELECT c.candidate_ID, c.fullName, c.email, c.field_of_expertise, c.years_of_experience, j.position_title AS Position, c.status FROM Candidates c INNER JOIN Job_Positions j ON c.position = j.position_ID WHERE c.email = @email";
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@email", emailBox.Text.Trim());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        currentCandidateID = Convert.ToInt32( dt.Rows[0]["Candidate_Id"]);
                        withdrawBtn.Enabled = true;
                        updateBtn.Enabled = true;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        currentCandidateID = 0;
                        withdrawBtn.Enabled = false;
                        updateBtn.Enabled = false;
                        MessageBox.Show("No application found for this email.");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error loading application status: " + ex.Message);
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (currentCandidateID == 0)
            {
                MessageBox.Show("No application loaded.");
                return;
            }
            try {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "DELETE FROM Candidates WHERE candidate_ID = @candidateID";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@candidateID", currentCandidateID);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Your application has been withdrawn.");
                        dataGridView1.DataSource = null;
                        emailBox.Clear();
                        currentCandidateID = 0;
                        withdrawBtn.Enabled = false;
                        updateBtn.Enabled = false;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error withdrawing application: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (currentCandidateID == 0) {
                MessageBox.Show("No application loaded.");
                return;
            }

                ApplicationUpdate updateForm =
                new ApplicationUpdate(currentCandidateID);
                updateForm.Show();
                this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
