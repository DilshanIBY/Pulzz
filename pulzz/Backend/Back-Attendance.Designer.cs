namespace pulzz.Backend
{
    partial class Back_Attendance
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.DateTimePicker();
            this.txt1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CheckInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CheckOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AbsentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 409);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(436, 40);
            this.dateTimePicker1.TabIndex = 178;
            this.dateTimePicker1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(833, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 177;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(833, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 31);
            this.label4.TabIndex = 176;
            this.label4.Text = "Time";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 33);
            this.label2.TabIndex = 175;
            this.label2.Text = "Date";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txt2.Location = new System.Drawing.Point(291, 257);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(436, 40);
            this.txt2.TabIndex = 174;
            this.txt2.ValueChanged += new System.EventHandler(this.txt2_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 607);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 171;
            this.label1.Text = "Clock Out";
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txt4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt4.Location = new System.Drawing.Point(291, 606);
            this.txt4.Margin = new System.Windows.Forms.Padding(4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(436, 40);
            this.txt4.TabIndex = 170;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 33);
            this.label8.TabIndex = 169;
            this.label8.Text = "Clock In";
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txt3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt3.Location = new System.Drawing.Point(291, 409);
            this.txt3.Margin = new System.Windows.Forms.Padding(4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(436, 40);
            this.txt3.TabIndex = 168;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.FormattingEnabled = true;
            this.txt1.Location = new System.Drawing.Point(291, 186);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(436, 37);
            this.txt1.TabIndex = 167;
            this.txt1.SelectedIndexChanged += new System.EventHandler(this.txt1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 166;
            this.label3.Text = "Employee ID";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CheckInBtn
            // 
            this.CheckInBtn.BorderRadius = 10;
            this.CheckInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckInBtn.FillColor = System.Drawing.Color.Red;
            this.CheckInBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInBtn.ForeColor = System.Drawing.Color.White;
            this.CheckInBtn.Location = new System.Drawing.Point(587, 479);
            this.CheckInBtn.Name = "CheckInBtn";
            this.CheckInBtn.Size = new System.Drawing.Size(150, 45);
            this.CheckInBtn.TabIndex = 180;
            this.CheckInBtn.Text = "Check In";
            this.CheckInBtn.Click += new System.EventHandler(this.CheckInBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.BorderRadius = 10;
            this.CheckOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckOutBtn.FillColor = System.Drawing.Color.Red;
            this.CheckOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.ForeColor = System.Drawing.Color.White;
            this.CheckOutBtn.Location = new System.Drawing.Point(586, 673);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(150, 45);
            this.CheckOutBtn.TabIndex = 181;
            this.CheckOutBtn.Text = "Check Out";
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // AbsentBtn
            // 
            this.AbsentBtn.BorderRadius = 10;
            this.AbsentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AbsentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AbsentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AbsentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AbsentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AbsentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentBtn.ForeColor = System.Drawing.Color.White;
            this.AbsentBtn.Location = new System.Drawing.Point(1012, 95);
            this.AbsentBtn.Name = "AbsentBtn";
            this.AbsentBtn.Size = new System.Drawing.Size(150, 45);
            this.AbsentBtn.TabIndex = 182;
            this.AbsentBtn.Text = "Absent";
            this.AbsentBtn.Click += new System.EventHandler(this.AbsentBtn_Click);
            // 
            // Back_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 796);
            this.Controls.Add(this.AbsentBtn);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.CheckInBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Back_Attendance";
            this.Text = "Back_Attendance";
            this.Load += new System.EventHandler(this.AdninForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txt3;
        private System.Windows.Forms.ComboBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button CheckInBtn;
        private Guna.UI2.WinForms.Guna2Button CheckOutBtn;
        private Guna.UI2.WinForms.Guna2Button AbsentBtn;
    }
}