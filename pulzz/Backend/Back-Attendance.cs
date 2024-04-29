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
    public partial class Back_Attendance : Form
    {
        public Back_Attendance()
        {
            InitializeComponent();
        }

        private void Back_Attendance_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblAttendence WHERE EmpID = @EmpID ORDER BY Number DESC", conn);
                cmd.Parameters.AddWithValue("@EmpID", txt1.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // Display details of the latest record
                    txt1.Text = dr["EmpID"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr["ClockIn"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                dateTimePicker1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Add this Clock In?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    // Generate unique Id
                    string empId = txt1.Text;
                    string date = txt2.Text;
                    string Status = "1";
                    string currentTime = DateTime.Now.ToString("HH:mm:ss"); // Current time in HH:mm:ss format

                    // Retrieve the current maximum value of the Number column
                    SqlCommand getMaxNumberCmd = new SqlCommand("SELECT ISNULL(MAX(Number), 0) FROM tblAttendence", conn);
                    int currentMaxNumber = Convert.ToInt32(getMaxNumberCmd.ExecuteScalar());

                    // Increment the current maximum value by 1 to get the next value
                    int nextNumber = currentMaxNumber + 1;

                    string id = GenerateId(empId, date, currentTime);

                    cm = new SqlCommand("INSERT INTO tblAttendence(Number,EmpId, Date, ClockIn, Id,Status) VALUES (@Number,@EmpId, @Date, @ClockIn, @Id,@Status)", conn);

                    cm.Parameters.AddWithValue("@Number", nextNumber); // Use the incremented value
                    cm.Parameters.AddWithValue("@EmpId", empId);
                    cm.Parameters.AddWithValue("@Date", date);
                    cm.Parameters.AddWithValue("@ClockIn", txt3.Text);
                    cm.Parameters.AddWithValue("@Id", id);
                    cm.Parameters.AddWithValue("@Status", Status);

                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Set Clock In successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                txt1.Text = "";
                Application.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Set this Time...?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    // Updated SQL query to use an exact match on ClockIn
                    cm = new SqlCommand("UPDATE tblAttendence SET ClockOut = @ClockOut WHERE ClockIn = @ClockIn", conn);

                    cm.Parameters.AddWithValue("@ClockOut", txt4.Value);
                    cm.Parameters.AddWithValue("@ClockIn", dateTimePicker1.Text);

                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Time has been successfully Set.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt1.Text = "";
                Application.Restart();
            }
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
