using pulzz.Backend;
using pulzz.Frontend;
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

namespace pulzz
{
    public partial class Menu : Form
    {
        public Menu()
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

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 156, b.Location.Y - 28);
            imgSlide.SendToBack();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.home1;
            container(new Dashboard());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            label_val.Text = "Shifts";
            guna2PictureBox_val.Image = Properties.Resources.shift1;
            container(new Shifts());
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            label_val.Text = "Leaves";
            guna2PictureBox_val.Image = Properties.Resources.leave1;
            container(new Leaves());
            
        }

        private void guna2Button11_CheckedChanged_1(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            label_val.Text = "Attends";
            guna2PictureBox_val.Image = Properties.Resources.attendance1;
            container(new frmCheckAttendence());
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            label_val.Text = "Payrolls";
            guna2PictureBox_val.Image = Properties.Resources.payroll1;
            container(new Payrolls());
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Profile";
            guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Profile());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Back_Menu p = new Back_Menu();
            p.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.home1;
            container(new Dashboard());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
