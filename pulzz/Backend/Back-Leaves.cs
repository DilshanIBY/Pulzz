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

namespace pulzz.Backend
{
    public partial class Back_Leaves : Form
    {
        public Back_Leaves()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(new DatabaseReader().getConnStr());


        private void LAenterBtn_Click(object sender, EventArgs e)
        {
            // declaring variables to store data
            string id = LAId.Text;

            // creating sql query
            string query = $"SELECT * FORM leavetable WHERE Id = '{id}'";

            // creating sql command
            SqlCommand cmd = new SqlCommand(query, conn);

            // executing the sql command 
            try
            {
                conn.Open();

                SqlDataReader data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    data.Read();
                    LAempId.Text = data["EmpId"].ToString();
                    LAempName.Text = data["EmpName"].ToString();
                    LAtype.Text = data["Type"].ToString();
                    LAstart.Value = Convert.ToDateTime(data["Start"]);
                    LAend.Value = Convert.ToDateTime(data["End"]);
                   
                }
                conn.Close();

                MessageBox.Show("Approval this leave", "APPROVAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LAsaveBtn_Click(object sender, EventArgs e)
        {
            // declaring variables to store data
            string status = LAStatus.Text;

            // creating sql query
            string query = $"INSERT INTO leavetable VALUES ('{status}');";


            // creating sql command
            SqlCommand cmd = new SqlCommand(query, conn);

            // executing the sql command 
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Approval Leave Successful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LAclearBtn_Click(object sender, EventArgs e)
        {
            LAId.Text = "";
            LAempId.Text = "";
            LAempName.Text = "";
            LAtype.Text = "";
            LAstart.Value = DateTime.Now;
            LAend.Value = DateTime.Now;
            LAStatus.SelectedIndex = -1;
        }

        private void LAcancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    
}

