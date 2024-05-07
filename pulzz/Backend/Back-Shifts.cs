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

namespace pulzz.Backend
{
    public partial class Back_Shifts : Form
    {
        public Back_Shifts()
        {
            InitializeComponent();
        }

        private void txtEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Declaring variables to add data
            string EmployeeID = txtEmployeeID.Text;
            string EmployeeName = txtEmployeeName.Text;
            string Date = txtDate.Text;
            //Creating the SQL query
            string query = $"INSERT INTO Shift Rejected ('{EmployeeID}','{EmployeeName}','{Date}');";

            //Creating the SQL command
            SqlCommand cmd = new SqlCommand(query, conn);
            //Executing the SQL command
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SQL Command Execution Successful", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the ShiftApprovedForm
            this.Close();
            // Optionally, show the main form again
            // Assuming Form1 is the name of your main form
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
