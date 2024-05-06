using Guna.UI2.WinForms;
using pulzz.Frontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using Pulzz;

namespace pulzz.Backend
{
    public partial class Back_Menu : Form
    {
        private Any _load;
        public Back_Menu()
        {
            InitializeComponent();
            initializeDarkMode();
        }

        private void Back_Menu_Load(object sender, EventArgs e)
        {
            // guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Analytics";
            guna2PictureBox_val.Image = Properties.Resources.home2;
            container(new Back_Dashboard());
            UpdateContainerUI();
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
            UpdateContainerUI();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            label_val.Text = "Attendance Management";
            guna2PictureBox_val.Image = Properties.Resources.attendance2;
            container(new Back_Attendance());
            UpdateContainerUI();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            label_val.Text = "Shift Management";
            guna2PictureBox_val.Image = Properties.Resources.shift2;
            container(new Back_Shifts());
            UpdateContainerUI();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            label_val.Text = "Leave Management";
            guna2PictureBox_val.Image = Properties.Resources.leave2;
            container(new Back_Leaves());
            UpdateContainerUI();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            label_val.Text = "Payroll Management";
            guna2PictureBox_val.Image = Properties.Resources.payroll2;
            container(new Back_Payrolls());
            UpdateContainerUI();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Profiles";
            guna2PictureBox_val.Image = Properties.Resources.staff2;
            container(new Back_Profiles());
            UpdateContainerUI();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            label_val.Text = "Settings";
            guna2PictureBox_val.Image = Properties.Resources.settings2;
            container(new Back_Settings());
            UpdateContainerUI();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _load = new Any();
            _load.anyBackendUI();
            _load.AnyDarkMode();
            _load.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Menu p = new Menu();
            p.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ChangeUIMode();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Any any = Application.OpenForms["Any"] as Any;

            if (any != null)
            {
                any.Hide();
            }
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Any any = Application.OpenForms["Any"] as Any;

            if (any != null)
            {
                any.Hide();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                search();
            }
        }

        public void search()
        {
            string search = guna2TextBox1.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                if (search.Contains("Dash") || search.Contains("Overview") || search.Contains("Analytics") || search.Contains("dash") || search.Contains("overview") || search.Contains("analytics"))
                {
                    label_val.Text = "Analytics";
                    guna2PictureBox_val.Image = Properties.Resources.home2;
                    container(new Back_Dashboard());
                    UpdateContainerUI();
                    guna2Button11.Checked = true;
                }
                else if (search.Contains("Shift") || search.Contains("Shifts") || search.Contains("shift") || search.Contains("shifts"))
                {
                    label_val.Text = "Shift Management";
                    guna2PictureBox_val.Image = Properties.Resources.shift2;
                    container(new Back_Shifts());
                    UpdateContainerUI();
                    guna2Button13.Checked = true;

                }
                else if (search.Contains("Leave") || search.Contains("Leaves") || search.Contains("leave") || search.Contains("leaves"))
                {
                    label_val.Text = "Leave Management";
                    guna2PictureBox_val.Image = Properties.Resources.leave2;
                    container(new Back_Leaves());
                    UpdateContainerUI();
                    guna2Button14.Checked = true;

                }
                else if (search.Contains("Attend") || search.Contains("Attends") || search.Contains("attend") || search.Contains("attends"))
                {
                    label_val.Text = "Attendance Management";
                    guna2PictureBox_val.Image = Properties.Resources.attendance2;
                    container(new Back_Attendance());
                    UpdateContainerUI();
                    guna2Button8.Checked = true;

                }
                else if (search.Contains("Payroll") || search.Contains("Payrolls") || search.Contains("payroll") || search.Contains("payrolls"))
                {
                    label_val.Text = "Payroll Management";
                    guna2PictureBox_val.Image = Properties.Resources.payroll2;
                    container(new Back_Payrolls());
                    UpdateContainerUI();
                    guna2Button12.Checked = true;

                }
                else if (search.Contains("Profile") || search.Contains("Staff") || search.Contains("profile") || search.Contains("staff"))
                {
                    label_val.Text = "Profiles";
                    guna2PictureBox_val.Image = Properties.Resources.staff2;
                    container(new Back_Profiles());
                    UpdateContainerUI();
                    guna2Button1.Checked = true;

                }
                else if (search.Contains("Settings") || search.Contains("Setting") || search.Contains("settings") || search.Contains("setting"))
                {
                    label_val.Text = "Settings";
                    guna2PictureBox_val.Image = Properties.Resources.settings2;
                    container(new Back_Settings());
                    UpdateContainerUI();
                    guna2Button10.Checked = true;

                }
            }
        }

        private void ChangeUIMode()
        {
            try
            {
                string uiMode = WebConfigurationManager.AppSettings["UIMode"];
                if (uiMode == "light")
                {
                    pulzzLogo.Visible = false;
                    pulzzLogoDark.Visible = true;
                    guna2Panel_top.ForeColor = Color.White;
                    guna2Panel_top.BackColor = Color.FromArgb(5, 5, 5);
                    guna2Panel1.ForeColor = Color.White;
                    guna2TextBox1.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Panel1.ForeColor = Color.White;
                    guna2Panel1.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button1.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button8.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button10.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button11.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button12.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button13.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button14.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                    foreach (Control ctrl in guna2Panel_container.Controls)
                    {
                        ctrl.ForeColor = Color.White;
                        ctrl.BackColor = Color.FromArgb(5, 5, 5);
                    }
                    ChangeControlColors(guna2Panel_container.Controls, Color.White, Color.FromArgb(5, 5, 5));
                    WebConfigurationManager.AppSettings["UIMode"] = "dark";
                }
                else
                {
                    pulzzLogoDark.Visible = false;
                    pulzzLogo.Visible = true;
                    guna2Panel_top.ForeColor = Color.FromArgb(5, 5, 5);
                    guna2Panel_top.BackColor = Color.White;
                    guna2Panel1.ForeColor = Color.FromArgb(5, 5, 5);
                    guna2TextBox1.FillColor = Color.White;
                    guna2Panel1.ForeColor = Color.FromArgb(5, 5, 5);
                    guna2Panel1.FillColor = Color.White;
                    guna2Button1.CheckedState.FillColor = Color.White;
                    guna2Button8.CheckedState.FillColor = Color.White;
                    guna2Button10.CheckedState.FillColor = Color.White;
                    guna2Button11.CheckedState.FillColor = Color.White;
                    guna2Button12.CheckedState.FillColor = Color.White;
                    guna2Button13.CheckedState.FillColor = Color.White;
                    guna2Button14.CheckedState.FillColor = Color.White;
                    foreach (System.Windows.Forms.Control ctrl in guna2Panel_container.Controls)
                    {
                        ctrl.ForeColor = Color.FromArgb(5, 5, 5);
                        ctrl.BackColor = Color.White;
                    }
                    ChangeControlColors(guna2Panel_container.Controls, Color.FromArgb(5, 5, 5), Color.White);
                    WebConfigurationManager.AppSettings["UIMode"] = "light";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void initializeDarkMode()
        {
            string uiMode = WebConfigurationManager.AppSettings["UIMode"];
            if (uiMode == "dark")
            {
                pulzzLogo.Visible = false;
                pulzzLogoDark.Visible = true;
                guna2Panel_top.ForeColor = Color.White;
                guna2Panel_top.BackColor = Color.FromArgb(5, 5, 5);
                guna2Panel1.ForeColor = Color.White;
                guna2TextBox1.FillColor = Color.FromArgb(5, 5, 5);
                guna2Panel1.ForeColor = Color.White;
                guna2Panel1.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button1.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button8.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button10.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button11.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button12.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button13.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button14.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
            }
        }
        public void UpdateContainerUI()
        {
            string uiMode = WebConfigurationManager.AppSettings["UIMode"];
            if (uiMode == "dark")
            {
                foreach (Control ctrl in guna2Panel_container.Controls)
                {
                    ctrl.ForeColor = Color.White;
                    ctrl.BackColor = Color.FromArgb(5, 5, 5);
                }
                ChangeControlColors(guna2Panel_container.Controls, Color.White, Color.FromArgb(5, 5, 5));
            }
        }


        private void ChangeControlColors(Control.ControlCollection controls, Color fromColor, Color toColor)
        {
            foreach (Control control in controls)
            {
                if (control.ForeColor == fromColor)
                    control.ForeColor = toColor;

                if (control.BackColor == fromColor)
                    control.BackColor = toColor;

                if (control.HasChildren)
                    ChangeControlColors(control.Controls, fromColor, toColor);
            }
        }

    }
}
