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
    public partial class frmCheckAttendence : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\Pulzz\\pulzz\\Pulzz_Database.mdf;Integrated Security=True");

        SqlCommand cm = new SqlCommand();
        public frmCheckAttendence()
        {
            InitializeComponent();
            LoadRecord1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
