using DatabaseOperations;
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

namespace pulzz.Backend
{
    public partial class Back_Dashboard : Form
    {
        SqlConnection con = new SqlConnection(new DatabaseReader().getConnStr());
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Back_Dashboard()
        {
            InitializeComponent();
        }

        private void Back_Dashboard_Load(object sender, EventArgs e)
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
                guna2DataGridView1.DataSource = dt;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "EmployeeID";
            guna2DataGridView1.Columns[1].HeaderText = "Status";
            
        }

        private void guna2HtmlLabel28_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel28.Text = dt.Rows.Count.ToString();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "EmployeeID";
            guna2DataGridView1.Columns[1].HeaderText = "Male";
            guna2DataGridView1.Columns[0].HeaderText = "Female";
            
        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel14.Text = dt.Rows.Count.ToString();
        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel13.Text = dt.Rows.Count.ToString();
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.Columns[0].HeaderText = "EmployeeID";
            guna2DataGridView1.Columns[1].HeaderText = "Doctors";
            guna2DataGridView1.Columns[0].HeaderText = "Nurse";
            guna2DataGridView1.Columns[0].HeaderText = "Others";
           
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel17.Text = dt.Rows.Count.ToString();
        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel12.Text = dt.Rows.Count.ToString();
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel11.Text = dt.Rows.Count.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"C:\Users\SADINI\Desktop\C# & SAD Project\Admin Dashboard 1\Admin Dashboard 1\Database1.mdf");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
        }

        Back_Menu bk = new Back_Menu();

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            bk.container(new Back_Profiles());
            bk.UpdateContainerUI();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            bk.container(new Back_Shifts());
            bk.UpdateContainerUI();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            bk.container(new Back_Leaves());
            bk.UpdateContainerUI();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            bk.container(new Back_Attendance());
            bk.UpdateContainerUI();
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
            bk.container(new Back_Payrolls());
            bk.UpdateContainerUI();
        }
    }
}
