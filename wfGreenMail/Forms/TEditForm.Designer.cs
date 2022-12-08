namespace wfGreenMail
{
    partial class TEditForm
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.HtmlEditor = new BaiqiSoft.HtmlEditorControl.MstHtmlEditor();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.lblAttach = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubj = new System.Windows.Forms.Label();
            this.edtSubject = new System.Windows.Forms.TextBox();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Controls.Add(this.HtmlEditor, 0, 1);
            this.pnlMain.Controls.Add(this.pnlTop, 0, 0);
            this.pnlMain.Controls.Add(this.pnlBottom, 0, 2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.17355F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.82645F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.pnlMain.Size = new System.Drawing.Size(978, 644);
            this.pnlMain.TabIndex = 0;
            // 
            // HtmlEditor
            // 
            this.HtmlEditor.DataSource = null;
            this.HtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HtmlEditor.LanguageConfig = null;
            this.HtmlEditor.Location = new System.Drawing.Point(3, 117);
            this.HtmlEditor.Name = "HtmlEditor";
            this.HtmlEditor.ShowEditorModeToolbar = false;
            this.HtmlEditor.Size = new System.Drawing.Size(972, 478);
            this.HtmlEditor.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTop.Controls.Add(this.lblAttachments);
            this.pnlTop.Controls.Add(this.lblAttach);
            this.pnlTop.Controls.Add(this.btnAttach);
            this.pnlTop.Controls.Add(this.lblTo);
            this.pnlTop.Controls.Add(this.lblSubj);
            this.pnlTop.Controls.Add(this.edtSubject);
            this.pnlTop.Controls.Add(this.edtEmail);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(972, 108);
            this.pnlTop.TabIndex = 1;
            // 
            // lblAttachments
            // 
            this.lblAttachments.AutoSize = true;
            this.lblAttachments.BackColor = System.Drawing.Color.SlateGray;
            this.lblAttachments.ForeColor = System.Drawing.Color.White;
            this.lblAttachments.Location = new System.Drawing.Point(159, 83);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.Size = new System.Drawing.Size(0, 15);
            this.lblAttachments.TabIndex = 6;
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.ForeColor = System.Drawing.Color.White;
            this.lblAttach.Location = new System.Drawing.Point(3, 83);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(78, 15);
            this.lblAttach.TabIndex = 5;
            this.lblAttach.Text = "Attachments:";
            // 
            // btnAttach
            // 
            this.btnAttach.BackgroundImage = global::wfGreenMail.Properties.Resources.paperclip;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(102, 75);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(32, 30);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(3, 57);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(59, 15);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Recipient:";
            // 
            // lblSubj
            // 
            this.lblSubj.AutoSize = true;
            this.lblSubj.ForeColor = System.Drawing.Color.White;
            this.lblSubj.Location = new System.Drawing.Point(3, 28);
            this.lblSubj.Name = "lblSubj";
            this.lblSubj.Size = new System.Drawing.Size(49, 15);
            this.lblSubj.TabIndex = 2;
            this.lblSubj.Text = "Subject:";
            // 
            // edtSubject
            // 
            this.edtSubject.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edtSubject.ForeColor = System.Drawing.Color.White;
            this.edtSubject.Location = new System.Drawing.Point(71, 20);
            this.edtSubject.Name = "edtSubject";
            this.edtSubject.Size = new System.Drawing.Size(356, 23);
            this.edtSubject.TabIndex = 0;
            // 
            // edtEmail
            // 
            this.edtEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edtEmail.ForeColor = System.Drawing.Color.White;
            this.edtEmail.Location = new System.Drawing.Point(71, 49);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(356, 23);
            this.edtEmail.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlBottom.Controls.Add(this.btnSend);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(3, 601);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(972, 40);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SlateGray;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(9, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.pnlMain);
            this.Name = "TEditForm";
            this.Text = "TEditForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel pnlMain;
        private BaiqiSoft.HtmlEditorControl.MstHtmlEditor HtmlEditor;
        private Panel pnlTop;
        private Label lblTo;
        private Label lblSubj;
        private TextBox edtSubject;
        private TextBox edtEmail;
        private Panel pnlBottom;
        private Button btnSend;
        private SaveFileDialog saveFileDialog1;
        private Label lblAttach;
        private Button btnAttach;
        private OpenFileDialog openFileDialog1;
        private Label lblAttachments;
    }
}