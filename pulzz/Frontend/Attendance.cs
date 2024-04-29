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
        public Attendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Show();
            button3.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Close This Application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
