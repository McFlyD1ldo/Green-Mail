namespace wfGreenMail.Forms
{
    partial class TMassMailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblAttach = new System.Windows.Forms.Label();
            this.edtSubj = new System.Windows.Forms.TextBox();
            this.lblSubj = new System.Windows.Forms.Label();
            this.htmlMessage = new BaiqiSoft.HtmlEditorControl.MstHtmlEditor();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 79);
            this.panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(275, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(121, 37);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Contacts";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 565);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.htmlMessage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(270, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(605, 487);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Controls.Add(this.lblAttachments);
            this.panel7.Controls.Add(this.btnAttach);
            this.panel7.Controls.Add(this.lblAttach);
            this.panel7.Controls.Add(this.edtSubj);
            this.panel7.Controls.Add(this.lblSubj);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(605, 68);
            this.panel7.TabIndex = 5;
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.BackColor = System.Drawing.Color.SlateGray;
            this.lblAttachments.ForeColor = System.Drawing.Color.White;
            this.lblAttachments.Location = new System.Drawing.Point(157, 46);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(0, 15);
            this.lblAttachments.TabIndex = 6;
            this.lblAttachments.Paint += new System.Windows.Forms.PaintEventHandler(this.lblAttachments_Paint);
            // 
            // btnAttach
            // 
            this.btnAttach.BackgroundImage = global::wfGreenMail.Properties.Resources.paperclip;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(101, 37);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(32, 30);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.ForeColor = System.Drawing.Color.White;
            this.lblAttach.Location = new System.Drawing.Point(6, 46);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(78, 15);
            this.lblAttach.TabIndex = 2;
            this.lblAttach.Text = "Attachments:";
            // 
            // edtSubj
            // 
            this.edtSubj.BackColor = System.Drawing.Color.SlateGray;
            this.edtSubj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtSubj.ForeColor = System.Drawing.Color.White;
            this.edtSubj.Location = new System.Drawing.Point(78, 12);
            this.edtSubj.Name = "edtSubj";
            this.edtSubj.Size = new System.Drawing.Size(515, 23);
            this.edtSubj.TabIndex = 1;
            // 
            // lblSubj
            // 
            this.lblSubj.AutoSize = true;
            this.lblSubj.ForeColor = System.Drawing.Color.White;
            this.lblSubj.Location = new System.Drawing.Point(6, 15);
            this.lblSubj.Name = "lblSubj";
            this.lblSubj.Size = new System.Drawing.Size(49, 15);
            this.lblSubj.TabIndex = 0;
            this.lblSubj.Text = "Subject:";
            // 
            // htmlMessage
            // 
            this.htmlMessage.DataSource = null;
            this.htmlMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlMessage.LanguageConfig = null;
            this.htmlMessage.Location = new System.Drawing.Point(0, 0);
            this.htmlMessage.Name = "htmlMessage";
            this.htmlMessage.ShowEditorModeToolbar = false;
            this.htmlMessage.ShowFormattingToolbar = false;
            this.htmlMessage.ShowStandardToolbar = false;
            this.htmlMessage.Size = new System.Drawing.Size(605, 487);
            this.htmlMessage.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(260, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 487);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbContacts);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 487);
            this.panel4.TabIndex = 6;
            // 
            // lbContacts
            // 
            this.lbContacts.BackColor = System.Drawing.Color.SlateGray;
            this.lbContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbContacts.ForeColor = System.Drawing.Color.White;
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.ItemHeight = 15;
            this.lbContacts.Location = new System.Drawing.Point(0, 0);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(260, 487);
            this.lbContacts.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.btnContacts);
            this.panel3.Controls.Add(this.btnMessage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 78);
            this.panel3.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SlateGray;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSend.Location = new System.Drawing.Point(606, 27);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.SlateGray;
            this.btnContacts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnContacts.Location = new System.Drawing.Point(50, 27);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(143, 23);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "load newsletter contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.SlateGray;
            this.btnMessage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMessage.Location = new System.Drawing.Point(450, 27);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(130, 23);
            this.btnMessage.TabIndex = 3;
            this.btnMessage.Text = "load message";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "html";
            this.openFileDialog.Filter = "\"Text files|*.txt|HTML files|*.html";
            // 
            // TMassMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(875, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TMassMailForm";
            this.Text = "TMassMailForm";
            this.Resize += new System.EventHandler(this.TMassMailForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Button btnMessage;
        private Button btnContacts;
        private OpenFileDialog openFileDialog;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private BaiqiSoft.HtmlEditorControl.MstHtmlEditor htmlMessage;
        private Label lblMessage;
        private ListBox lbContacts;
        private Panel panel6;
        private Button btnSend;
        private Panel panel7;
        private TextBox edtSubj;
        private Label lblSubj;
        private Label lblAttach;
        private Button btnAttach;
        private Label lblAttachments;
    }
}