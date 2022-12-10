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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tcEditMode = new wfGreenMail.TDMTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.tdmBday = new wfGreenMail.TDMDatePicker();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.edtLName = new System.Windows.Forms.TextBox();
            this.lblBDay = new System.Windows.Forms.Label();
            this.edtFName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbsNewsletter = new System.Windows.Forms.CheckBox();
            this.edtsEmail = new System.Windows.Forms.TextBox();
            this.dpsBday = new wfGreenMail.TDMDatePicker();
            this.lblsFname = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblsLName = new System.Windows.Forms.Label();
            this.lblsEmail = new System.Windows.Forms.Label();
            this.edtsLname = new System.Windows.Forms.TextBox();
            this.lblsBday = new System.Windows.Forms.Label();
            this.edtsFname = new System.Windows.Forms.TextBox();
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
            this.tcEditMode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.pnlSplit.Size = new System.Drawing.Size(941, 554);
            this.pnlSplit.SplitterDistance = 168;
            this.pnlSplit.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitle.Controls.Add(this.lblMenu);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(168, 61);
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
            this.MainMenu.Size = new System.Drawing.Size(124, 63);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // miWrite
            // 
            this.miWrite.ForeColor = System.Drawing.Color.White;
            this.miWrite.Name = "miWrite";
            this.miWrite.Size = new System.Drawing.Size(117, 19);
            this.miWrite.Text = "New E-Mail";
            this.miWrite.Click += new System.EventHandler(this.writingtoolStripMenuItem_Click);
            // 
            // miAuto
            // 
            this.miAuto.ForeColor = System.Drawing.Color.White;
            this.miAuto.Name = "miAuto";
            this.miAuto.Size = new System.Drawing.Size(117, 19);
            this.miAuto.Text = "E-Mail automation";
            this.miAuto.Click += new System.EventHandler(this.eMailAutomationToolStripMenuItem_Click);
            // 
            // miMassMail
            // 
            this.miMassMail.ForeColor = System.Drawing.Color.White;
            this.miMassMail.Name = "miMassMail";
            this.miMassMail.Size = new System.Drawing.Size(117, 19);
            this.miMassMail.Text = "Massmailing";
            this.miMassMail.Click += new System.EventHandler(this.massmailingToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grdContacts);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 115);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(769, 395);
            this.pnlMain.TabIndex = 2;
            // 
            // grdContacts
            // 
            this.grdContacts.AllowUserToAddRows = false;
            this.grdContacts.AllowUserToDeleteRows = false;
            this.grdContacts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grdContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdContacts.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdContacts.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContacts.EnableHeadersVisualStyles = false;
            this.grdContacts.GridColor = System.Drawing.Color.SlateGray;
            this.grdContacts.Location = new System.Drawing.Point(0, 0);
            this.grdContacts.Name = "grdContacts";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdContacts.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.grdContacts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdContacts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateGray;
            this.grdContacts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdContacts.RowTemplate.Height = 25;
            this.grdContacts.Size = new System.Drawing.Size(769, 395);
            this.grdContacts.TabIndex = 0;
            this.grdContacts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdContacts_CellMouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 510);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(769, 44);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pnlInput.Controls.Add(this.tcEditMode);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.ForeColor = System.Drawing.Color.White;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(769, 115);
            this.pnlInput.TabIndex = 1;
            // 
            // tcEditMode
            // 
            this.tcEditMode.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tcEditMode.Controls.Add(this.tabPage1);
            this.tcEditMode.Controls.Add(this.tabPage2);
            this.tcEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEditMode.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcEditMode.Location = new System.Drawing.Point(0, 0);
            this.tcEditMode.Name = "tcEditMode";
            this.tcEditMode.SelectedIndex = 0;
            this.tcEditMode.Size = new System.Drawing.Size(769, 115);
            this.tcEditMode.TabIndex = 12;
            this.tcEditMode.TextColor = System.Drawing.Color.White;
            this.tcEditMode.SelectedIndexChanging += new wfGreenMail.SelectedTabPageChangeEventHandler(this.tcEditMode_SelectedIndexChanging);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.edtEmail);
            this.tabPage1.Controls.Add(this.tdmBday);
            this.tabPage1.Controls.Add(this.lblFName);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblLName);
            this.tabPage1.Controls.Add(this.lblMail);
            this.tabPage1.Controls.Add(this.edtLName);
            this.tabPage1.Controls.Add(this.lblBDay);
            this.tabPage1.Controls.Add(this.edtFName);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "add contact";
            // 
            // edtEmail
            // 
            this.edtEmail.BackColor = System.Drawing.Color.SlateGray;
            this.edtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtEmail.ForeColor = System.Drawing.Color.White;
            this.edtEmail.Location = new System.Drawing.Point(382, 15);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(200, 23);
            this.edtEmail.TabIndex = 7;
            // 
            // tdmBday
            // 
            this.tdmBday.BorderColor = System.Drawing.Color.White;
            this.tdmBday.BorderSize = 0;
            this.tdmBday.CalendarForeColor = System.Drawing.Color.White;
            this.tdmBday.CalendarMonthBackground = System.Drawing.Color.SlateGray;
            this.tdmBday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tdmBday.Location = new System.Drawing.Point(382, 42);
            this.tdmBday.MinimumSize = new System.Drawing.Size(0, 20);
            this.tdmBday.Name = "tdmBday";
            this.tdmBday.ShowIcon = true;
            this.tdmBday.Size = new System.Drawing.Size(200, 23);
            this.tdmBday.SkinColor = System.Drawing.Color.SlateGray;
            this.tdmBday.TabIndex = 11;
            this.tdmBday.TextColor = System.Drawing.Color.White;
            this.tdmBday.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(7, 18);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(65, 15);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(678, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(7, 48);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(64, 15);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last name:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(286, 17);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(80, 15);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "E-Mail adress:";
            // 
            // edtLName
            // 
            this.edtLName.BackColor = System.Drawing.Color.SlateGray;
            this.edtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtLName.ForeColor = System.Drawing.Color.White;
            this.edtLName.Location = new System.Drawing.Point(89, 44);
            this.edtLName.Name = "edtLName";
            this.edtLName.Size = new System.Drawing.Size(179, 23);
            this.edtLName.TabIndex = 6;
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Location = new System.Drawing.Point(286, 48);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(54, 15);
            this.lblBDay.TabIndex = 4;
            this.lblBDay.Text = "Birthday:";
            // 
            // edtFName
            // 
            this.edtFName.BackColor = System.Drawing.Color.SlateGray;
            this.edtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtFName.ForeColor = System.Drawing.Color.White;
            this.edtFName.Location = new System.Drawing.Point(89, 15);
            this.edtFName.Name = "edtFName";
            this.edtFName.Size = new System.Drawing.Size(179, 23);
            this.edtFName.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.cbsNewsletter);
            this.tabPage2.Controls.Add(this.edtsEmail);
            this.tabPage2.Controls.Add(this.dpsBday);
            this.tabPage2.Controls.Add(this.lblsFname);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.lblsLName);
            this.tabPage2.Controls.Add(this.lblsEmail);
            this.tabPage2.Controls.Add(this.edtsLname);
            this.tabPage2.Controls.Add(this.lblsBday);
            this.tabPage2.Controls.Add(this.edtsFname);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "search contact";
            // 
            // cbsNewsletter
            // 
            this.cbsNewsletter.AutoSize = true;
            this.cbsNewsletter.Location = new System.Drawing.Point(594, 19);
            this.cbsNewsletter.Name = "cbsNewsletter";
            this.cbsNewsletter.Size = new System.Drawing.Size(80, 19);
            this.cbsNewsletter.TabIndex = 21;
            this.cbsNewsletter.Text = "newsletter";
            this.cbsNewsletter.UseVisualStyleBackColor = true;
            // 
            // edtsEmail
            // 
            this.edtsEmail.BackColor = System.Drawing.Color.SlateGray;
            this.edtsEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtsEmail.ForeColor = System.Drawing.Color.White;
            this.edtsEmail.Location = new System.Drawing.Point(382, 15);
            this.edtsEmail.Name = "edtsEmail";
            this.edtsEmail.Size = new System.Drawing.Size(200, 23);
            this.edtsEmail.TabIndex = 18;
            // 
            // dpsBday
            // 
            this.dpsBday.BorderColor = System.Drawing.Color.White;
            this.dpsBday.BorderSize = 0;
            this.dpsBday.CalendarForeColor = System.Drawing.Color.White;
            this.dpsBday.CalendarMonthBackground = System.Drawing.Color.SlateGray;
            this.dpsBday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpsBday.Location = new System.Drawing.Point(382, 42);
            this.dpsBday.MinimumSize = new System.Drawing.Size(0, 20);
            this.dpsBday.Name = "dpsBday";
            this.dpsBday.ShowIcon = true;
            this.dpsBday.Size = new System.Drawing.Size(200, 23);
            this.dpsBday.SkinColor = System.Drawing.Color.SlateGray;
            this.dpsBday.TabIndex = 20;
            this.dpsBday.TextColor = System.Drawing.Color.White;
            this.dpsBday.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // lblsFname
            // 
            this.lblsFname.AutoSize = true;
            this.lblsFname.Location = new System.Drawing.Point(7, 18);
            this.lblsFname.Name = "lblsFname";
            this.lblsFname.Size = new System.Drawing.Size(65, 15);
            this.lblsFname.TabIndex = 12;
            this.lblsFname.Text = "First name:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(678, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblsLName
            // 
            this.lblsLName.AutoSize = true;
            this.lblsLName.Location = new System.Drawing.Point(7, 48);
            this.lblsLName.Name = "lblsLName";
            this.lblsLName.Size = new System.Drawing.Size(64, 15);
            this.lblsLName.TabIndex = 13;
            this.lblsLName.Text = "Last name:";
            // 
            // lblsEmail
            // 
            this.lblsEmail.AutoSize = true;
            this.lblsEmail.Location = new System.Drawing.Point(286, 17);
            this.lblsEmail.Name = "lblsEmail";
            this.lblsEmail.Size = new System.Drawing.Size(80, 15);
            this.lblsEmail.TabIndex = 14;
            this.lblsEmail.Text = "E-Mail adress:";
            // 
            // edtsLname
            // 
            this.edtsLname.BackColor = System.Drawing.Color.SlateGray;
            this.edtsLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtsLname.ForeColor = System.Drawing.Color.White;
            this.edtsLname.Location = new System.Drawing.Point(89, 44);
            this.edtsLname.Name = "edtsLname";
            this.edtsLname.Size = new System.Drawing.Size(179, 23);
            this.edtsLname.TabIndex = 17;
            // 
            // lblsBday
            // 
            this.lblsBday.AutoSize = true;
            this.lblsBday.Location = new System.Drawing.Point(286, 48);
            this.lblsBday.Name = "lblsBday";
            this.lblsBday.Size = new System.Drawing.Size(54, 15);
            this.lblsBday.TabIndex = 15;
            this.lblsBday.Text = "Birthday:";
            // 
            // edtsFname
            // 
            this.edtsFname.BackColor = System.Drawing.Color.SlateGray;
            this.edtsFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtsFname.ForeColor = System.Drawing.Color.White;
            this.edtsFname.Location = new System.Drawing.Point(89, 15);
            this.edtsFname.Name = "edtsFname";
            this.edtsFname.Size = new System.Drawing.Size(179, 23);
            this.edtsFname.TabIndex = 16;
            // 
            // TMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 554);
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
            this.tcEditMode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private Button btnAdd;
        private TextBox edtEmail;
        private TextBox edtLName;
        private TDMDatePicker tdmBday;
        private Button btnSave;
        private Panel pnlBottom;
        private TDMTabControl tcEditMode;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox cbsNewsletter;
        private TextBox edtsEmail;
        private TDMDatePicker dpsBday;
        private Label lblsFname;
        private Button btnSearch;
        private Label lblsLName;
        private Label lblsEmail;
        private TextBox edtsLname;
        private Label lblsBday;
        private TextBox edtsFname;
    }
}