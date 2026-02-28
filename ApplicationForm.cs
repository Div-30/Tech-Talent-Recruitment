using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Thursday_Gen_Quiz
{
    public partial class ApplicationForm : Form
    {
        string connString;

        public ApplicationForm()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["HireProConnection"].ConnectionString;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            dobPicker.Format = DateTimePickerFormat.Short;
            dobPicker.MaxDate = DateTime.Today;
            loadPosition();
        }

        private void loadPosition()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "SELECT position_ID, position_title FROM JOB_POSITIONS";
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    positionCombo.DataSource = dt;
                    positionCombo.DisplayMember = "position_title";
                    positionCombo.ValueMember = "position_ID";
                    positionCombo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load positions error: " + ex.Message);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailBox.Text) ||
                string.IsNullOrWhiteSpace(fullNameBox.Text) ||
                string.IsNullOrWhiteSpace(expertiseBox.Text) ||
                string.IsNullOrWhiteSpace(yearsExperienceBox.Text) ||
                string.IsNullOrWhiteSpace(applicantDescriptionBox.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (positionCombo.SelectedIndex == -1 ||
                positionCombo.SelectedValue == null)
            {
                MessageBox.Show("Please select a position.");
                return;
            }

            if (!int.TryParse(yearsExperienceBox.Text, out int years))
            {
                MessageBox.Show("Years of experience must be a valid number.");
                return;
            }

            DateTime dob = dobPicker.Value;
            int age = DateTime.Today.Year - dob.Year;
            if (dob.Date > DateTime.Today.AddYears(-age))
                age--;

            if (age >= 35)
            {
                MessageBox.Show("Only applicants under 35 years old can apply.");
                return;
            }

            if (years < 2)
            {
                MessageBox.Show("Only applicants with at least 2 years ");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string qry = "INSERT INTO Candidates (email, fullName, dob, field_of_expertise, years_of_experience, [position], description) VALUES (@email, @fullName, @dob, @field, @years, @position, @description)";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@email", emailBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@fullName", fullNameBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@field", expertiseBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@years", years);
                    cmd.Parameters.AddWithValue("@position", positionCombo.SelectedValue);
                    cmd.Parameters.AddWithValue("@description", applicantDescriptionBox.Text.Trim());
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Application submitted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submit error: " + ex.Message);
            }
        }
        
    }
}