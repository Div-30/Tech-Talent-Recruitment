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
    public partial class HRForm : Form
    {
        string connString;
        bool isLoading = false;
        public HRForm()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["HireProConnection"].ConnectionString;
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadPositionFilter();
            loadStatusOptions();
            displayAllApplications();
        }
        private void loadPositionFilter()
        {
            try {
                isLoading = true;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "SELECT position_ID, position_title FROM Job_Positions";
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    filterCombo.DataSource = dt;
                    filterCombo.DisplayMember = "position_title";
                    filterCombo.ValueMember = "position_ID";
                    filterCombo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load positions error: " + ex.Message);
            }
            finally
            {
                isLoading = false;
            }
        }
        private void loadStatusOptions()
        {
            statusCombo.Items.Clear();
            statusCombo.Items.Add("Approved");
            statusCombo.Items.Add("Under Review");
            statusCombo.Items.Add("Rejected");
            statusCombo.SelectedIndex = -1;
        }
        private void displayAllApplications()
        {
            try {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "SELECT c.candidate_ID, c.fullName, c.email, c.field_of_expertise, c.years_of_experience, j.position_title AS Position, c.description, c.status FROM Candidates c INNER JOIN Job_Positions j ON c.[position] = j.position_ID ORDER BY c.candidate_ID DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message);
            }
        }

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (filterCombo.SelectedIndex == -1) return;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string qry = "SELECT c.candidate_ID, c.fullName, c.email, c.field_of_expertise, c.years_of_experience, j.position_title AS Position, c.description, c.status FROM Candidates c INNER JOIN Job_Positions j ON c.[position] = j.position_ID WHERE c.position = @positionId ORDER BY c.candidate_ID DESC";
                        SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@positionId", filterCombo.SelectedValue);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering applications: " + ex.Message);
                }
        }
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            isLoading = true;
            filterCombo.SelectedIndex = -1;
            isLoading = false;
            displayAllApplications();
        }

        private void updateStatusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application to update");
                return;

            }

            if(statusCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status to apply");
                return;
            }

            try {
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Candidate_ID"].Value);
                string newStatus = statusCombo.SelectedItem.ToString();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "UPDATE Candidates SET status = @status WHERE candidate_ID = @candidateID";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@candidateID", selectedID);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Status updated successfully");
                        displayAllApplications(); 
                        statusCombo.SelectedIndex = -1;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
