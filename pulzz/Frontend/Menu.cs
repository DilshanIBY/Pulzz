using pulzz.Backend;
using pulzz.Frontend;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Configuration;
using Control = System.Windows.Forms.Control;
using Pulzz;

namespace pulzz
{
    public partial class Menu : Form
    {
        private Any _load;
        public Menu()
        {
            InitializeComponent();
            initializeDarkMode();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.home1;
            container(new Dashboard());
            UpdateContainerUI();
        }

        public void container(object _form)
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
            string uiMode = WebConfigurationManager.AppSettings["UIMode"];
            imgSlide.Location = new Point(b.Location.X + 156, b.Location.Y - 28);
            imgSlide.SendToBack();
            imgSlideDark.Location = new Point(b.Location.X + 156, b.Location.Y - 28);
            imgSlideDark.SendToBack();
            if (uiMode == "light")
            {
                imgSlide.Visible = true;
            }
            else
            {
                imgSlideDark.Visible = true;
            }

   

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            label_val.Text = "Dashboard Overview";
            guna2PictureBox_val.Image = Properties.Resources.home1;
            container(new Dashboard());
            UpdateContainerUI();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            label_val.Text = "Shifts";
            guna2PictureBox_val.Image = Properties.Resources.shift1;
            container(new Shifts());
            UpdateContainerUI();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            label_val.Text = "Leaves";
            guna2PictureBox_val.Image = Properties.Resources.leave1;
            container(new Leaves());
            UpdateContainerUI();

        }

        public void guna2Button11_CheckedChanged_1(object sender, EventArgs e)
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
            container(new Attendance());
            UpdateContainerUI();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            label_val.Text = "Payrolls";
            guna2PictureBox_val.Image = Properties.Resources.payroll1;
            container(new Payrolls());
            UpdateContainerUI();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Profile";
            guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Profile());
            UpdateContainerUI();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _load = new Any();
            _load.anyFrontendUI();
            _load.AnyDarkMode();
            _load.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Back_Menu p = new Back_Menu();
            p.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ChangeUIMode();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Any any = Application.OpenForms["Front_Any"] as Any;

            if (any != null)
            {
                any.Hide();
            }
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Any any = Application.OpenForms["Front_Any"] as Any;

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
                if (search.Contains("Dash") || search.Contains("Overview") || search.Contains("dash") || search.Contains("overview"))
                {
                    label_val.Text = "Dashboard Overview";
                    guna2PictureBox_val.Image = Properties.Resources.home1;
                    container(new Dashboard());
                    UpdateContainerUI();
                    guna2Button11.Checked = true;
                }
                else if (search.Contains("Shift") || search.Contains("Shifts") || search.Contains("shift") || search.Contains("shifts"))
                {
                    label_val.Text = "Shifts";
                    guna2PictureBox_val.Image = Properties.Resources.shift1;
                    container(new Shifts());
                    UpdateContainerUI();
                    guna2Button13.Checked = true;

                }
                else if (search.Contains("Leave") || search.Contains("Leaves") || search.Contains("leave") || search.Contains("leaves"))
                {
                    label_val.Text = "Leaves";
                    guna2PictureBox_val.Image = Properties.Resources.leave1;
                    container(new Leaves());
                    UpdateContainerUI();
                    guna2Button14.Checked = true;

                }
                else if (search.Contains("Attend") || search.Contains("Attends") || search.Contains("attend") || search.Contains("attends"))
                {
                    label_val.Text = "Attends";
                    guna2PictureBox_val.Image = Properties.Resources.attendance1;
                    container(new Attendance());
                    UpdateContainerUI();
                    guna2Button8.Checked = true;

                }
                else if (search.Contains("Payroll") || search.Contains("Payrolls") || search.Contains("payroll") || search.Contains("payrolls"))
                {
                    label_val.Text = "Payrolls";
                    guna2PictureBox_val.Image = Properties.Resources.payroll1;
                    container(new Payrolls());
                    UpdateContainerUI();
                    guna2Button12.Checked = true;

                }
                else if (search.Contains("Profile") || search.Contains("My") || search.Contains("profile") || search.Contains("my"))
                {
                    label_val.Text = "Profile";
                    guna2PictureBox_val.Image = Properties.Resources.person__1_;
                    container(new Profile());
                    UpdateContainerUI();

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
                    imgSlide.Visible = false;
                    imgSlideDark.Visible = true;
                    ForeColor = Color.White;
                    BackColor = Color.FromArgb(5, 5, 5);
                    guna2Panel1.ForeColor = Color.White;
                    guna2TextBox1.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Panel1.ForeColor = Color.White;
                    guna2Panel1.FillColor = Color.FromArgb(5, 5, 5);
                    guna2Button8.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
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
                    imgSlideDark.Visible = false;
                    imgSlide.Visible = true;
                    ForeColor = Color.FromArgb(5, 5, 5);
                    BackColor = Color.White;
                    guna2Panel1.ForeColor = Color.FromArgb(5, 5, 5);
                    guna2TextBox1.FillColor = Color.White;
                    guna2Panel1.ForeColor = Color.FromArgb(5, 5, 5);
                    guna2Panel1.FillColor = Color.White;
                    guna2Button8.CheckedState.FillColor = Color.White;
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
                imgSlide.Visible = false;
                imgSlideDark.Visible = true;
                ForeColor = Color.White;
                BackColor = Color.FromArgb(5, 5, 5);
                guna2Panel1.ForeColor = Color.White;
                guna2TextBox1.FillColor = Color.FromArgb(5, 5, 5);
                guna2Panel1.ForeColor = Color.White;
                guna2Panel1.FillColor = Color.FromArgb(5, 5, 5);
                guna2Button8.CheckedState.FillColor = Color.FromArgb(5, 5, 5);
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
