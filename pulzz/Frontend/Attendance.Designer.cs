namespace pulzz
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FindBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PresentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AbsentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 547);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 162;
            this.label1.Text = "Results";
            this.label1.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.FormattingEnabled = true;
            this.txt1.Location = new System.Drawing.Point(558, 236);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(436, 37);
            this.txt1.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 157;
            this.label3.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 31);
            this.label4.TabIndex = 156;
            this.label4.Text = "Check Your Attendance";
            // 
            // FindBtn
            // 
            this.FindBtn.BorderRadius = 10;
            this.FindBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FindBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FindBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FindBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(234)))));
            this.FindBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FindBtn.ForeColor = System.Drawing.Color.White;
            this.FindBtn.Location = new System.Drawing.Point(854, 316);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(141, 45);
            this.FindBtn.TabIndex = 163;
            this.FindBtn.Text = "Find";
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // PresentsBtn
            // 
            this.PresentsBtn.BorderRadius = 10;
            this.PresentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PresentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PresentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PresentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PresentsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PresentsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PresentsBtn.ForeColor = System.Drawing.Color.White;
            this.PresentsBtn.Location = new System.Drawing.Point(684, 458);
            this.PresentsBtn.Name = "PresentsBtn";
            this.PresentsBtn.Size = new System.Drawing.Size(311, 45);
            this.PresentsBtn.TabIndex = 164;
            this.PresentsBtn.Text = "Absent Days";
            this.PresentsBtn.Click += new System.EventHandler(this.PresentsBtn_Click);
            // 
            // AbsentsBtn
            // 
            this.AbsentsBtn.BorderRadius = 10;
            this.AbsentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AbsentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AbsentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AbsentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AbsentsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AbsentsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AbsentsBtn.ForeColor = System.Drawing.Color.White;
            this.AbsentsBtn.Location = new System.Drawing.Point(312, 458);
            this.AbsentsBtn.Name = "AbsentsBtn";
            this.AbsentsBtn.Size = new System.Drawing.Size(311, 45);
            this.AbsentsBtn.TabIndex = 165;
            this.AbsentsBtn.Text = "Present Days";
            this.AbsentsBtn.Click += new System.EventHandler(this.AbsentsBtn_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 863);
            this.Controls.Add(this.AbsentsBtn);
            this.Controls.Add(this.PresentsBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Frontend_ATTENDS";
            this.Load += new System.EventHandler(this.frmCheckAttendence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button FindBtn;
        private Guna.UI2.WinForms.Guna2Button PresentsBtn;
        private Guna.UI2.WinForms.Guna2Button AbsentsBtn;
    }
}