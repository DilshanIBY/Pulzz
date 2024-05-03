﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pulzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

       /* private void guna2Button1_Click(object sender, EventArgs e)
        {
            Loading _load = new Loading();
            _load.Show();
            this.Hide();
        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TOSHIBA\source\repos\Pulzz\pulzz\Pulzz_Database.mdf;Integrated Security=True");
            String username, password;

            username = txtuname.Text;
            password = txtpass.Text;

            try
            {
                string querry = "SELECT * FROM Employee_details WHERE UserName = '" + txtusername.Text + "' AND Password ='" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtusername.Text;
                    password = txtpassword.Text;

                    Loading _load = new Loading();
                    _load.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();

                    txtusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Left += 20;
            if (panel3.Left == 360)
            {
                timer1.Stop();
                panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel3.Left -= 20;
            if (panel3.Left == 0)
            {
                timer2.Stop();
                panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            timer1.Start();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            timer2.Start();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtdob.Text) || String.IsNullOrEmpty(combogender.SelectedItem.ToString()) || string.IsNullOrEmpty(txtaddress.Text) || String.IsNullOrEmpty(combopost.SelectedItem.ToString()) || string.IsNullOrEmpty(txtcontact.Text) || String.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtuname.Text) || String.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtcompass.Text))
            {
                MessageBox.Show("Please fill every fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Clear();
                txtname.Clear();
                txtdob.Clear();
                combogender.SelectedItem = 0;
                txtaddress.Clear();
                combopost.SelectedItem = 0;
                txtcontact.Clear();
                txtemail.Clear();
                txtuname.Clear();
                txtpass.Clear();
                txtcompass.Clear();
            }
            else
            {
                MessageBox.Show("Register Successfully");
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TOSHIBA\source\repos\Pulzz\pulzz\Pulzz_Database.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Employee_details]
           ([EmployeeID]
           ,[EmployeeName]
           ,[DateOfBirth]
           ,[Gender]
           ,[Address]
           ,[Post]
           ,[ContactNo]
           ,[Email]
           ,[UserName]
           ,[Password]
           ,[ConfirmPassword])
     VALUES
           ('" + txtid.Text + "','" + txtname.Text + "','" + txtdob.Text + "', '" + combogender.SelectedItem.ToString() + "','" + txtaddress.Text + "','" + combopost.SelectedItem.ToString() + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + txtuname.Text + "','" + txtpass.Text + "','" + txtcompass.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
