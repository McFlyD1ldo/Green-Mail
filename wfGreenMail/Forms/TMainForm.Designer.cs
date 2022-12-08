namespace wfGreenMail.Forms
{
    partial class TMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSplit = new System.Windows.Forms.SplitContainer();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.miWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.miAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.miMassMail = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grdContacts = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.tdmBday = new wfGreenMail.TDMDatePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.edtLName = new System.Windows.Forms.TextBox();
            this.edtFName = new System.Windows.Forms.TextBox();
            this.lblBDay = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSplit)).BeginInit();
            this.pnlSplit.Panel1.SuspendLayout();
            this.pnlSplit.Panel2.SuspendLayout();
            this.pnlSplit.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacts)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSplit
            // 
            this.pnlSplit.BackColor = System.Drawing.Color.Black;
            this.pnlSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplit.Location = new System.Drawing.Point(0, 0);
            this.pnlSplit.Name = "pnlSplit";
            // 
            // pnlSplit.Panel1
            // 
            this.pnlSplit.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSplit.Panel1.Controls.Add(this.pnlTitle);
            this.pnlSplit.Panel1.Controls.Add(this.MainMenu);
            // 
            // pnlSplit.Panel2
            // 
            this.pnlSplit.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSplit.Panel2.Controls.Add(this.pnlMain);
            this.pnlSplit.Panel2.Controls.Add(this.pnlBottom);
            this.pnlSplit.Panel2.Controls.Add(this.pnlInput);
            this.pnlSplit.Size = new System.Drawing.Size(920, 554);
            this.pnlSplit.SplitterDistance = 165;
            this.pnlSplit.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitle.Controls.Add(this.lblMenu);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(165, 61);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(0, 12);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(151, 37);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Main menu";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWrite,
            this.miAuto,
            this.miMassMail});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MainMenu.Location = new System.Drawing.Point(0, 60);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(126, 82);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // miWrite
            // 
            this.miWrite.ForeColor = System.Drawing.Color.White;
            this.miWrite.Name = "miWrite";
            this.miWrite.Size = new System.Drawing.Size(119, 19);
            this.miWrite.Text = "New E-Mail";
            this.miWrite.Click += new System.EventHandler(this.writingtoolStripMenuItem_Click);
            // 
            // miAuto
            // 
            this.miAuto.ForeColor = System.Drawing.Color.White;
            this.miAuto.Name = "miAuto";
            this.miAuto.Size = new System.Drawing.Size(119, 19);
            this.miAuto.Text = "E-Mail automation";
            this.miAuto.Click += new System.EventHandler(this.eMailAutomationToolStripMenuItem_Click);
            // 
            // miMassMail
            // 
            this.miMassMail.ForeColor = System.Drawing.Color.White;
            this.miMassMail.Name = "miMassMail";
            this.miMassMail.Size = new System.Drawing.Size(119, 19);
            this.miMassMail.Text = "Massmailing";
            this.miMassMail.Click += new System.EventHandler(this.massmailingToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grdContacts);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 134);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(751, 376);
            this.pnlMain.TabIndex = 2;
            // 
            // grdContacts
            // 
            this.grdContacts.AllowUserToAddRows = false;
            this.grdContacts.AllowUserToDeleteRows = false;
            this.grdContacts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.grdContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdContacts.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdContacts.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContacts.EnableHeadersVisualStyles = false;
            this.grdContacts.GridColor = System.Drawing.Color.SlateGray;
            this.grdContacts.Location = new System.Drawing.Point(0, 0);
            this.grdContacts.Name = "grdContacts";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdContacts.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.grdContacts.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdContacts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            this.grdContacts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdContacts.RowTemplate.Height = 25;
            this.grdContacts.Size = new System.Drawing.Size(751, 376);
            this.grdContacts.TabIndex = 0;
            this.grdContacts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdContacts_CellMouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 510);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(751, 44);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(598, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.tdmBday);
            this.pnlInput.Controls.Add(this.btnAdd);
            this.pnlInput.Controls.Add(this.edtEmail);
            this.pnlInput.Controls.Add(this.edtLName);
            this.pnlInput.Controls.Add(this.edtFName);
            this.pnlInput.Controls.Add(this.lblBDay);
            this.pnlInput.Controls.Add(this.lblMail);
            this.pnlInput.Controls.Add(this.lblLName);
            this.pnlInput.Controls.Add(this.lblFName);
            this.pnlInput.Controls.Add(this.pnlTop);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.ForeColor = System.Drawing.Color.White;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(751, 134);
            this.pnlInput.TabIndex = 1;
            // 
            // tdmBday
            // 
            this.tdmBday.BorderColor = System.Drawing.Color.White;
            this.tdmBday.BorderSize = 0;
            this.tdmBday.CalendarForeColor = System.Drawing.Color.White;
            this.tdmBday.CalendarMonthBackground = System.Drawing.Color.SlateGray;
            this.tdmBday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tdmBday.Location = new System.Drawing.Point(386, 102);
            this.tdmBday.MinimumSize = new System.Drawing.Size(0, 20);
            this.tdmBday.Name = "tdmBday";
            this.tdmBday.ShowIcon = true;
            this.tdmBday.Size = new System.Drawing.Size(200, 23);
            this.tdmBday.SkinColor = System.Drawing.Color.SlateGray;
            this.tdmBday.TabIndex = 11;
            this.tdmBday.TextColor = System.Drawing.Color.White;
            this.tdmBday.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(664, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // edtEmail
            // 
            this.edtEmail.BackColor = System.Drawing.Color.SlateGray;
            this.edtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtEmail.ForeColor = System.Drawing.Color.White;
            this.edtEmail.Location = new System.Drawing.Point(386, 75);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(200, 23);
            this.edtEmail.TabIndex = 7;
            // 
            // edtLName
            // 
            this.edtLName.BackColor = System.Drawing.Color.SlateGray;
            this.edtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtLName.ForeColor = System.Drawing.Color.White;
            this.edtLName.Location = new System.Drawing.Point(93, 104);
            this.edtLName.Name = "edtLName";
            this.edtLName.Size = new System.Drawing.Size(179, 23);
            this.edtLName.TabIndex = 6;
            // 
            // edtFName
            // 
            this.edtFName.BackColor = System.Drawing.Color.SlateGray;
            this.edtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtFName.ForeColor = System.Drawing.Color.White;
            this.edtFName.Location = new System.Drawing.Point(93, 75);
            this.edtFName.Name = "edtFName";
            this.edtFName.Size = new System.Drawing.Size(179, 23);
            this.edtFName.TabIndex = 5;
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Location = new System.Drawing.Point(290, 108);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(54, 15);
            this.lblBDay.TabIndex = 4;
            this.lblBDay.Text = "Birthday:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(290, 77);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(80, 15);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "E-Mail adress:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(11, 108);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(64, 15);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(11, 78);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(65, 15);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First name:";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.lblAdd);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(751, 61);
            this.pnlTop.TabIndex = 0;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.Location = new System.Drawing.Point(11, 12);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(160, 37);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add contact";
            // 
            // TMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 554);
            this.Controls.Add(this.pnlSplit);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "TMainForm";
            this.Text = "Green Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TMainForm_FormClosing);
            this.pnlSplit.Panel1.ResumeLayout(false);
            this.pnlSplit.Panel1.PerformLayout();
            this.pnlSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSplit)).EndInit();
            this.pnlSplit.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContacts)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer pnlSplit;
        private Panel pnlTitle;
        private Label lblMenu;
        private MenuStrip MainMenu;
        private ToolStripMenuItem miWrite;
        private ToolStripMenuItem miAuto;
        private ToolStripMenuItem miMassMail;
        private DataGridView grdContacts;
        private Panel pnlMain;
        private Panel pnlInput;
        private TextBox edtFName;
        private Label lblBDay;
        private Label lblMail;
        private Label lblLName;
        private Label lblFName;
        private Panel pnlTop;
        private Label lblAdd;
        private Button btnAdd;
        private TextBox edtEmail;
        private TextBox edtLName;
        private TDMDatePicker tdmBday;
        private Button btnSave;
        private Panel pnlBottom;
    }
}