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

        Menu fr = new Menu();

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            fr.container(new Shifts());
            fr.UpdateContainerUI();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            fr.container(new Profile());
            fr.UpdateContainerUI();
        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {
            fr.container(new Attendance());
            fr.UpdateContainerUI();
        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {
            fr.container(new Leaves());
            fr.UpdateContainerUI();
        }

        private void guna2Panel12_Paint(object sender, PaintEventArgs e)
        {
            fr.container(new Payrolls());
            fr.UpdateContainerUI();
        }
    }
}
