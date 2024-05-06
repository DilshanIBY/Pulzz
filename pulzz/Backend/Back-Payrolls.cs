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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pulzz.Backend
{
    public partial class Back_Payrolls : Form
    {
        //Data Source=DESKTOP-H7G6VPS;Initial Catalog=EmpSalary;Integrated Security=True
        SqlConnection con = new SqlConnection(new DatabaseReader().getConnStr());
        SqlCommand cmd;
        SqlDataAdapter adapt;

        double sal = 0;
        double etf, epf, etfamount, epfamount, gsal, allow, nsal;

        

        private void Back_Payrolls_Load(object sender, EventArgs e)
        {
            AnotherFunction(); //call the data set
        }

        int over;

        


        public Back_Payrolls()
        {
            InitializeComponent();
            DisplayData();
        }

      

        // Display Data in DataGridView
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Salary", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

      
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void AnotherFunction()
        {
            //this.tSTable01TableAdapter.Fill(this.testDataSet1.TSTable01);
        }

       

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text != "" && txtEmpName.Text != "")
            {
                try
                {
                    con.Open();
                    string insert_query = "insert into Salary (EmployeeID,EmployeeName,Position,PayDates,BasicSalary,ETFAmount,EPFAmount,Allowance,GrossSalary,NetSalary,AttendanceDates,OverTime,NetPay) " +
                        "values (@EmployeeID ,@EmployeeName,@Position,@PayDates,@BasicSalary,@ETFAmount,@EPFAmount,@Allowance,@GrossSalary,@NetSalary,@AttendanceDates,@OverTime,@NetPay )";
                    //string insert_query = "insert into Salary (EmployeeID) values (@ID)";
                    cmd = new SqlCommand(insert_query, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(txtEmpId.Text));
                    cmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@Position", cmbPosition.Text);
                    cmd.Parameters.AddWithValue("@PayDates", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@BasicSalary", Double.Parse(txtBasic.Text));
                    cmd.Parameters.AddWithValue("@ETFAmount", Double.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@EPFAmount", Double.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Allowance", Double.Parse(txtAllowance.Text));
                    cmd.Parameters.AddWithValue("@GrossSalary", Double.Parse(txtGrossSalary.Text));
                    cmd.Parameters.AddWithValue("@NetSalary", Double.Parse(txtNetSalary.Text));
                    cmd.Parameters.AddWithValue("@AttendanceDates", int.Parse(txtAttendance.Text));
                    cmd.Parameters.AddWithValue("@OverTime", int.Parse(txtOver.Text));
                    cmd.Parameters.AddWithValue("@NetPay", Double.Parse(txtNet.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Record Inserted Successfully");
                    //refresh the data table 
                    DisplayData(); //02

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERORR:" + ex.ToString());

                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        

        // Clear Data
        private void ClearData()
        {
            txtEmpId.Text = "";
            txtEmpName.Text = "";
            cmbPosition.Text = "";
            dateTimePicker1.Text = "";
            txtBasic.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            txtAttendance.Text = "";
            txtOver.Text = "";
            txtAllowance.Text = "";
            txtGrossSalary.Text = "";
            txtNetSalary.Text = "";
            txtNet.Text = "";


        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

       
        // Update Record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text != "" && txtEmpName.Text != "")
            {
                try
                {
                    con.Open();
                    string update_query = "update Salary set EmployeeName=@EmployeeName,Position=@Position,PayDates=@PayDates,BasicSalary=@BasicSalary,ETFAmount=@ETFAmount ,EPFAmount=@EPFAmount,Allowance=@Allowance,GrossSalary=@GrossSalary,NetSalary=@NetSalary, AttendanceDates=@AttendanceDates,OverTime=@OverTime,NetPay=@NetPay     where EmployeeID=@EmployeeID";
                    cmd = new SqlCommand(update_query, con);
                    cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(txtEmpId.Text));
                    cmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@Position", cmbPosition.Text);
                    cmd.Parameters.AddWithValue("@PayDates", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@BasicSalary", Double.Parse(txtBasic.Text));
                    cmd.Parameters.AddWithValue("@ETFAmount", Double.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@EPFAmount", Double.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Allowance", Double.Parse(txtAllowance.Text));
                    cmd.Parameters.AddWithValue("@GrossSalary", Double.Parse(txtGrossSalary.Text));
                    cmd.Parameters.AddWithValue("@NetSalary", Double.Parse(txtNetSalary.Text));
                    cmd.Parameters.AddWithValue("@AttendanceDates", int.Parse(txtAttendance.Text));
                    cmd.Parameters.AddWithValue("@OverTime", int.Parse(txtOver.Text));
                    //cmd.Parameters.AddWithValue("@Total", int.Parse(txtAllowance.Text));
                    //cmd.Parameters.AddWithValue("@Tax", Double.Parse(txtGrossSalary.Text));
                    //cmd.Parameters.AddWithValue("@ETF", Double.Parse(txtNetSalary.Text));
                    cmd.Parameters.AddWithValue("@NetPay", Double.Parse(txtNet.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update Successfully");
                    con.Close();
                    //refresh the data table
                    AnotherFunction();  //01
                    DisplayData(); //02

                    ClearData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERORR:" + ex.ToString());

                }
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        

        // Delete Record
        private void btnDelate_Click(object sender, EventArgs e)
        {
            
                if (txtEmpId.Text != "" && txtEmpName.Text != "")
                {
                    try
                    {
                        con.Open();
                        string delete_query = "delete Salary where EmployeeID=@EmployeeID AND EmployeeName=@EmployeeName";
                        cmd = new SqlCommand(delete_query, con);
                        cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(txtEmpId.Text));
                        cmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                        //cmd.Parameters.AddWithValue("@Position", cmbPosition.Text);
                        //cmd.Parameters.AddWithValue("@PayDates", dateTimePicker1.Text);
                        //cmd.Parameters.AddWithValue("@BasicSalary", Double.Parse(txtBasic.Text));
                        //cmd.Parameters.AddWithValue("@AttendanceDates", int.Parse(txtAttendance.Text));
                        //cmd.Parameters.AddWithValue("@OverTime", int.Parse(txtOver.Text));
                        //cmd.Parameters.AddWithValue("@Total", int.Parse(txtTotal.Text));
                        //cmd.Parameters.AddWithValue("@Tax", Double.Parse(txtTax.Text));
                        //cmd.Parameters.AddWithValue("@ETF", Double.Parse(txtETF.Text));
                        //cmd.Parameters.AddWithValue("@NetPay", Double.Parse(txtNet.Text));

                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record Delete Successfully");
                        //refresh the data table
                        AnotherFunction();  //01
                        DisplayData(); //02

                        ClearData();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERORR:" + ex.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }

            }
        // Search Record
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Salary where  EmployeeID like '" + txtEmpId.Text + "%' OR EmployeeName like '" + txtEmpName.Text + "%'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            DisplayData();

        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Salary where  EmployeeID like '" + textBox12.Text + "%'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Employee Payroll", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            over = int.Parse(txtOver.Text);


            if (cmbPosition.Text == "Doctor")
            {
                txtNet.Text = (over * 500).ToString();
            }
            else if (cmbPosition.Text == "nurse")
            {
                txtNet.Text = (over * 350).ToString();
            }
            else if (cmbPosition.Text == "Attendent")
            {
                txtNet.Text = (over * 100).ToString();
            }

        }
        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();


            string sql2 = "Select BasicSalary From BasicSalary Where Position  = @Position ";
            SqlCommand cmd3 = new SqlCommand(sql2, con);
            cmd3.Parameters.AddWithValue("@Position", cmbPosition.Text);
            SqlDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                int BA = Convert.ToInt32(reader["BasicSalary"]);
                txtBasic.Text = BA.ToString();
            }
            con.Close();

        }
        //tax
        private void button1_Click_1(object sender, EventArgs e)
        {
            sal = Double.Parse(txtBasic.Text);

            if (chkETF.Checked == true)
            {

                if (cmbPosition.Text == "Doctor")
                {
                    etfamount = sal * 10 / 100;
                }
                else if (cmbPosition.Text == "Nurse")
                {
                    etfamount = sal * 8 / 100;
                }
                else if (cmbPosition.Text == "Attendent")
                {
                    etfamount = sal * 5 / 100;
                }


            }

            if (chkEPF.Checked == true)
            {
                if (cmbPosition.Text == "Doctor")
                {
                    epfamount = sal * 8 / 100;
                }
                else if (cmbPosition.Text == "Nurse")
                {
                    epfamount = sal * 5 / 100;
                }
                else if (cmbPosition.Text == "Attendent")
                {
                    epfamount = sal * 2.5 / 100;
                }

            }

            textBox2.Text = etfamount.ToString();
            textBox1.Text = epfamount.ToString();

            gsal = sal - etfamount + epfamount;

            txtGrossSalary.Text = gsal.ToString();

            if (sal > 50000)
            {
                allow = 2000;
            }
            else if (sal > 30000)
            {
                allow = 1000;
            }
            else
            {
                allow = 0;
            }

            txtAllowance.Text = allow.ToString();


            nsal = gsal + allow + over;

            txtNetSalary.Text = nsal.ToString();
        }
    }


}


