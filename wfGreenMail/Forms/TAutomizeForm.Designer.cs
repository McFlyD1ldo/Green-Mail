namespace wfGreenMail.Forms
{
    partial class TAutomizeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblAttach = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSubj = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dpExpireDate = new wfGreenMail.TDMDatePicker();
            this.dpExpireTime = new wfGreenMail.TDMDatePicker();
            this.lblSpan = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.edtRepeat = new System.Windows.Forms.TextBox();
            this.clbWeeksOfMonth = new System.Windows.Forms.CheckedListBox();
            this.clbMonths = new System.Windows.Forms.CheckedListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dpStartDate = new wfGreenMail.TDMDatePicker();
            this.dpStartTime = new wfGreenMail.TDMDatePicker();
            this.clbDays = new System.Windows.Forms.CheckedListBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add auto email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 52);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 391);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 391);
            this.panel3.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.lblSpan);
            this.panel5.Controls.Add(this.lblRepeat);
            this.panel5.Controls.Add(this.edtRepeat);
            this.panel5.Controls.Add(this.clbWeeksOfMonth);
            this.panel5.Controls.Add(this.clbMonths);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.clbDays);
            this.panel5.Controls.Add(this.lblMonths);
            this.panel5.Controls.Add(this.lblDays);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(134, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 391);
            this.panel5.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblAttachments);
            this.panel7.Controls.Add(this.btnAttach);
            this.panel7.Controls.Add(this.lblAttach);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.edtSubj);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Controls.Add(this.dpExpireDate);
            this.panel7.Controls.Add(this.dpExpireTime);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 307);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(884, 80);
            this.panel7.TabIndex = 28;
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.BackColor = System.Drawing.Color.SlateGray;
            this.lblAttachments.Location = new System.Drawing.Point(577, 52);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(0, 15);
            this.lblAttachments.TabIndex = 35;
            this.lblAttachments.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAttachments_Paint);
            // 
            // btnAttach
            // 
            this.btnAttach.BackgroundImage = global::wfGreenMail.Properties.Resources.paperclip;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(515, 37);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(32, 30);
            this.btnAttach.TabIndex = 34;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.Location = new System.Drawing.Point(431, 52);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(78, 15);
            this.lblAttach.TabIndex = 33;
            this.lblAttach.Text = "Attachments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Subject:";
            // 
            // edtSubj
            // 
            this.edtSubj.BackColor = System.Drawing.Color.SlateGray;
            this.edtSubj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtSubj.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edtSubj.ForeColor = System.Drawing.Color.White;
            this.edtSubj.Location = new System.Drawing.Point(97, 45);
            this.edtSubj.Name = "edtSubj";
            this.edtSubj.Size = new System.Drawing.Size(225, 24);
            this.edtSubj.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(325, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "E-Mail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(787, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "expire:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dpExpireDate
            // 
            this.dpExpireDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpExpireDate.BorderSize = 0;
            this.dpExpireDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpExpireDate.Location = new System.Drawing.Point(98, 12);
            this.dpExpireDate.MinimumSize = new System.Drawing.Size(0, 20);
            this.dpExpireDate.Name = "dpExpireDate";
            this.dpExpireDate.ShowIcon = true;
            this.dpExpireDate.Size = new System.Drawing.Size(222, 24);
            this.dpExpireDate.SkinColor = System.Drawing.Color.SlateGray;
            this.dpExpireDate.TabIndex = 15;
            this.dpExpireDate.TextColor = System.Drawing.Color.White;
            // 
            // dpExpireTime
            // 
            this.dpExpireTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpExpireTime.BorderSize = 0;
            this.dpExpireTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpExpireTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpExpireTime.Location = new System.Drawing.Point(325, 12);
            this.dpExpireTime.MinimumSize = new System.Drawing.Size(0, 20);
            this.dpExpireTime.Name = "dpExpireTime";
            this.dpExpireTime.ShowIcon = false;
            this.dpExpireTime.ShowUpDown = true;
            this.dpExpireTime.Size = new System.Drawing.Size(88, 24);
            this.dpExpireTime.SkinColor = System.Drawing.Color.SlateGray;
            this.dpExpireTime.TabIndex = 16;
            this.dpExpireTime.TextColor = System.Drawing.Color.White;
            // 
            // lblSpan
            // 
            this.lblSpan.AutoSize = true;
            this.lblSpan.Location = new System.Drawing.Point(215, 84);
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(31, 15);
            this.lblSpan.TabIndex = 27;
            this.lblSpan.Text = "days";
            this.lblSpan.Visible = false;
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(23, 84);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(74, 15);
            this.lblRepeat.TabIndex = 25;
            this.lblRepeat.Text = "Repeat every";
            this.lblRepeat.Visible = false;
            // 
            // edtRepeat
            // 
            this.edtRepeat.Location = new System.Drawing.Point(107, 82);
            this.edtRepeat.Name = "edtRepeat";
            this.edtRepeat.Size = new System.Drawing.Size(93, 23);
            this.edtRepeat.TabIndex = 24;
            this.edtRepeat.Visible = false;
            // 
            // clbWeeksOfMonth
            // 
            this.clbWeeksOfMonth.CheckOnClick = true;
            this.clbWeeksOfMonth.FormattingEnabled = true;
            this.clbWeeksOfMonth.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Last"});
            this.clbWeeksOfMonth.Location = new System.Drawing.Point(62, 82);
            this.clbWeeksOfMonth.Name = "clbWeeksOfMonth";
            this.clbWeeksOfMonth.Size = new System.Drawing.Size(95, 94);
            this.clbWeeksOfMonth.TabIndex = 23;
            this.clbWeeksOfMonth.Visible = false;
            // 
            // clbMonths
            // 
            this.clbMonths.CheckOnClick = true;
            this.clbMonths.FormattingEnabled = true;
            this.clbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.clbMonths.Location = new System.Drawing.Point(60, 191);
            this.clbMonths.MultiColumn = true;
            this.clbMonths.Name = "clbMonths";
            this.clbMonths.Size = new System.Drawing.Size(345, 94);
            this.clbMonths.TabIndex = 22;
            this.clbMonths.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lblStart);
            this.panel6.Controls.Add(this.dpStartDate);
            this.panel6.Controls.Add(this.dpStartTime);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(884, 76);
            this.panel6.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Settings";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(21, 44);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 15);
            this.lblStart.TabIndex = 20;
            this.lblStart.Text = "Start:";
            // 
            // dpStartDate
            // 
            this.dpStartDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpStartDate.BorderSize = 0;
            this.dpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpStartDate.Location = new System.Drawing.Point(105, 38);
            this.dpStartDate.MinimumSize = new System.Drawing.Size(0, 20);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.ShowIcon = true;
            this.dpStartDate.Size = new System.Drawing.Size(223, 24);
            this.dpStartDate.SkinColor = System.Drawing.Color.SlateGray;
            this.dpStartDate.TabIndex = 18;
            this.dpStartDate.TextColor = System.Drawing.Color.White;
            // 
            // dpStartTime
            // 
            this.dpStartTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpStartTime.BorderSize = 0;
            this.dpStartTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpStartTime.Location = new System.Drawing.Point(336, 38);
            this.dpStartTime.MinimumSize = new System.Drawing.Size(0, 20);
            this.dpStartTime.Name = "dpStartTime";
            this.dpStartTime.ShowIcon = false;
            this.dpStartTime.ShowUpDown = true;
            this.dpStartTime.Size = new System.Drawing.Size(88, 24);
            this.dpStartTime.SkinColor = System.Drawing.Color.SlateGray;
            this.dpStartTime.TabIndex = 19;
            this.dpStartTime.TextColor = System.Drawing.Color.White;
            // 
            // clbDays
            // 
            this.clbDays.CheckOnClick = true;
            this.clbDays.FormattingEnabled = true;
            this.clbDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednessday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.clbDays.Location = new System.Drawing.Point(163, 82);
            this.clbDays.MultiColumn = true;
            this.clbDays.Name = "clbDays";
            this.clbDays.Size = new System.Drawing.Size(242, 94);
            this.clbDays.TabIndex = 17;
            this.clbDays.Visible = false;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(3, 193);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(51, 15);
            this.lblMonths.TabIndex = 9;
            this.lblMonths.Text = "Months:";
            this.lblMonths.Visible = false;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(21, 84);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(35, 15);
            this.lblDays.TabIndex = 8;
            this.lblDays.Text = "Days:";
            this.lblDays.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.rbMonthly);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.rbOnce);
            this.panel4.Controls.Add(this.rbWeekly);
            this.panel4.Controls.Add(this.rbDaily);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 391);
            this.panel4.TabIndex = 13;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(10, 107);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(70, 19);
            this.rbMonthly.TabIndex = 3;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Frequency";
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Checked = true;
            this.rbOnce.Location = new System.Drawing.Point(12, 32);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(53, 19);
            this.rbOnce.TabIndex = 0;
            this.rbOnce.TabStop = true;
            this.rbOnce.Text = "Once";
            this.rbOnce.UseVisualStyleBackColor = true;
            this.rbOnce.CheckedChanged += new System.EventHandler(this.rbOnce_CheckedChanged);
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(12, 82);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(63, 19);
            this.rbWeekly.TabIndex = 2;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            this.rbWeekly.CheckedChanged += new System.EventHandler(this.rbWeekly_CheckedChanged);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(12, 57);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(51, 19);
            this.rbDaily.TabIndex = 1;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.rbDaily_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TAutomizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1022, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TAutomizeForm";
            this.Text = "Automization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label lblMonths;
        private Label lblDays;
        private Label label2;
        private RadioButton rbMonthly;
        private RadioButton rbWeekly;
        private RadioButton rbDaily;
        private RadioButton rbOnce;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private CheckedListBox clbDays;
        private TDMDatePicker dpExpireTime;
        private TDMDatePicker dpExpireDate;
        private CheckBox checkBox1;
        private Label label5;
        private Label lblStart;
        private TDMDatePicker dpStartTime;
        private TDMDatePicker dpStartDate;
        private CheckedListBox clbMonths;
        private Panel panel6;
        private Label lblSpan;
        private Label lblRepeat;
        private TextBox edtRepeat;
        private CheckedListBox clbWeeksOfMonth;
        private Panel panel7;
        private TextBox edtSubj;
        private Button button2;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private Label lblAttach;
        private Label lblAttachments;
        private Button btnAttach;
    }
}