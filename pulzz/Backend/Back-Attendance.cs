using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pulzz.Backend
{
    public partial class AdninForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\Pulzz\\pulzz\\Pulzz_Database.mdf;Integrated Security=True");

        SqlCommand cm = new SqlCommand();
        public AdninForm()
        {
            InitializeComponent();
            LoadRecord1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Close This Application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            txt3.Text = DateTime.Now.ToLongTimeString();
            txt4.Text = DateTime.Now.ToLongTimeString();
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

        private int GetNextNumber()
        {
            int nextNumber = 1;
            try
            {
                conn.Open();
                SqlCommand getMaxNumberCmd = new SqlCommand("SELECT ISNULL(MAX(Number), 0) FROM tblAttendence", conn);
                object result = getMaxNumberCmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextNumber = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next number: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return nextNumber;
        }

        private string GenerateId(string empId, string date, string currentTime)
        {
            string concatenatedString = empId + date + currentTime;
            byte[] bytes = Encoding.UTF8.GetBytes(concatenatedString);
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(bytes);
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 10);
                return hashString;
            }
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

        private void AdninForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            label4.Text = DateTime.Now.ToLongTimeString();
            txt3.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
            txt4.Text = DateTime.Now.ToLongTimeString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.Restart();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
