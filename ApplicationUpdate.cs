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
    public partial class ApplicationUpdate : Form
    {
        string connString;
        int currentCandidateID = 0;
        public ApplicationUpdate(int id)
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["HireProConnection"].ConnectionString;
            currentCandidateID = id;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "UPDATE Candidates SET [position] = @position, description = @description WHERE Candidate_Id = @candidateId";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@position", positionCombo.SelectedValue);
                    cmd.Parameters.AddWithValue("@description", descriptionBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@candidateId", currentCandidateID);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Application updated successfully!");
                        ApplicationStatus statusForm = new ApplicationStatus();
                        statusForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating application: " + ex.Message);
            }
        }

        private void ApplicationUpdate_Load(object sender, EventArgs e)
        {
            loadPosition();
        }
        private void loadPosition()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "SELECT position_ID, position_title FROM Job_Positions";
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    positionCombo.DataSource = dt;
                    positionCombo.DisplayMember = "position_title";
                    positionCombo.ValueMember = "position_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load positions error: " + ex.Message);
            }

        }
        private void loadCurrentData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "SELECT position, description FROM Candidates WHERE candidateId = @candidateId";

                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@candidateId", currentCandidateID);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        positionCombo.SelectedValue = Convert.ToInt32(reader["position"]);
                        descriptionBox.Text = reader["description"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load current data error: " + ex.Message);
            }
        }
    }
}

