using DatabaseOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pulzz
{
    public partial class Attendance : Form
    {

        SqlConnection conn = new SqlConnection(new DatabaseReader().getConnStr());

        SqlCommand cm = new SqlCommand();
        public Attendance()
        {
            InitializeComponent();
            LoadRecord1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to count distinct EmpId values
                    string sql = "SELECT COUNT(DISTINCT EmpID) AS EmpCount FROM tblAttendence";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Execute the command and get the result
                        object result = command.ExecuteScalar();

                        // Display the result in a label or any other control
                        if (result != null)
                        {
                            label1.Text = "Present Days in this Month : " + result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            label1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to count distinct EmpId values
                    string sql = "SELECT COUNT(DISTINCT EmpID) AS EmpCount FROM tblAttendence";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Execute the command and get the result
                        object result = command.ExecuteScalar();

                        // Display the result in a label or any other control
                        if (result != null)
                        {
                            label1.Text = "Absent Days in this Month : " + result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            label1.Show();
        }

        private void LoadRecord1()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT EmpID FROM tblAttendence", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt1.Items.Add(dr["EmpID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmCheckAttendence_Load(object sender, EventArgs e)
        {
        }

        private void txt1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbsentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to count distinct EmpId values
                    string sql = "SELECT COUNT(DISTINCT EmpID) AS EmpCount FROM tblAttendence where Status='1'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Execute the command and get the result
                        object result = command.ExecuteScalar();

                        // Display the result in a label or any other control
                        if (result != null)
                        {
                            label1.Text = "Present Days in this Month : " + result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            label1.Show();
        }

        private void PresentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to count distinct EmpId values
                    string sql = "SELECT COUNT(DISTINCT EmpID) AS EmpCount FROM tblAttendence where status = '0'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Execute the command and get the result
                        object result = command.ExecuteScalar();

                        // Display the result in a label or any other control
                        if (result != null)
                        {
                            label1.Text = "Absent Days in this Month : " + result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            label1.Show();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            PresentsBtn.Show();
            AbsentsBtn.Show();
        }
    }
}
