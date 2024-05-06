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
using System.Runtime.InteropServices;
using DatabaseOperations;

namespace pulzz.Frontend
{
    public partial class Leaves : Form
    {
        public Leaves()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(new DatabaseReader().getConnStr());


        private void LapplyBtn_Click(object sender, EventArgs e)
        {
            // declaring variables to store data
            string id = LformId.Text;
            string empid = LempId.Text;
            string empname = LempName.Text;
            string type = Ltype.Text;
            string start = Lstart.Text;
            string end = Lend.Text;

            // creating sql query
            string query = $"INSERT INTO leavetable VALUES ('{id}','{empid}','{empname}','{type}','{start}','{end}');";


            // creating sql command
            SqlCommand cmd = new SqlCommand(query, conn);

            // executing the sql command 
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Apply Leave Successful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LclearBtn_Click(object sender, EventArgs e)
        {
            LformId.Text = "";
            LempId.Text = "";
            LempName.Text = "";
            Ltype.SelectedIndex = -1;
            Lstart.Value = DateTime.Now;
            Lend.Value = DateTime.Now;
        }

        private void LcancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LenterBtn_Click(object sender, EventArgs e)
        {
            // declaring variables to store data
           string id = LformId.Text;

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
                   LempId.Text = data["EmpId"].ToString();
                   LempName.Text = data["EmpName"].ToString();
                   Ltype.Text = data["Type"].ToString();
                   Lstart.Value = Convert.ToDateTime(data["Start"]);
                   Lend.Value = Convert.ToDateTime(data["End"]);
                   LStatus.Text = data["Status"].ToString();
               }
                conn.Close();

                MessageBox.Show("Approval this leave", "APPROVAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LformId_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // declaring variables to store data
            string id = LformId.Text;

            // creating sql query
            string query = $"SELECT * FORM leavesTbl WHERE Id = '{id}'";

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
                    LempId.Text = data["EmpId"].ToString();
                    LempName.Text = data["EmpName"].ToString();
                    Ltype.Text = data["Type"].ToString();
                    Lstart.Value = Convert.ToDateTime(data["Start"]);
                    Lend.Value = Convert.ToDateTime(data["End"]);
                    LStatus.Text = data["Status"].ToString();
                }
                conn.Close();

                MessageBox.Show("Approval this leave", "APPROVAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

 }

