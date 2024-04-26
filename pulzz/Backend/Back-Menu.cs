using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pulzz.Backend
{
    public partial class Back_Menu : Form
    {
        public Back_Menu()
        {
            InitializeComponent();
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            // guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Analytics";
            guna2PictureBox_val.Image = Properties.Resources.home2;
            container(new Back_Dashboard());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            label_val.Text = "Attendance Management";
            guna2PictureBox_val.Image = Properties.Resources.attendance2;
            container(new Back_Attendance());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            label_val.Text = "Shift Management";
            guna2PictureBox_val.Image = Properties.Resources.shift2;
            container(new Back_Shifts());
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            label_val.Text = "Leave Management";
            guna2PictureBox_val.Image = Properties.Resources.leave2;
            container(new Back_Leaves());
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            label_val.Text = "Payroll Management";
            guna2PictureBox_val.Image = Properties.Resources.payroll2;
            container(new Back_Payrolls());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Profiles";
            guna2PictureBox_val.Image = Properties.Resources.staff2;
            container(new Back_Profiles());
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            label_val.Text = "Settings";
            guna2PictureBox_val.Image = Properties.Resources.settings2;
            container(new Back_Settings());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Menu_Load(object sender, EventArgs e)
        {
            // guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Analytics";
            guna2PictureBox_val.Image = Properties.Resources.home2;
            container(new Back_Dashboard());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Menu p = new Menu();
            p.Show();
            this.Hide();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
