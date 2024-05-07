using DatabaseOperations;
using Guna.UI2.WinForms;
using pulzz.Backend;
using pulzz.Frontend;
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
    public partial class Dashboard : Form
    {

        SqlConnection con = new SqlConnection(new DatabaseReader().getConnStr());
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
             Shifts form2 = new Shifts ();
            form2.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT [EmployeeID], [Gender], [Post], [Attendence] FROM [dbo].[Employee_details]", con);
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            Profile form2 = new Profile();
            form2.Show();
            this.Hide();
        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {
            Attendance form2 = new Attendance();
            form2.Show();
            this.Hide();
        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {
            Leaves form2 = new Leaves();
            form2.Show();
            this.Hide();

        }

        private void guna2Panel12_Paint(object sender, PaintEventArgs e)
        {
           Payrolls form2 = new Payrolls();
            form2.Show();
            this.Hide();
        }
    }
}
