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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mstHtmlEditor1 = new BaiqiSoft.HtmlEditorControl.MstHtmlEditor();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtSubject = new System.Windows.Forms.TextBox();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mstHtmlEditor1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.45455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 644);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mstHtmlEditor1
            // 
            this.mstHtmlEditor1.DataSource = null;
            this.mstHtmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mstHtmlEditor1.LanguageConfig = null;
            this.mstHtmlEditor1.Location = new System.Drawing.Point(3, 108);
            this.mstHtmlEditor1.Name = "mstHtmlEditor1";
            this.mstHtmlEditor1.ShowEditorModeToolbar = false;
            this.mstHtmlEditor1.Size = new System.Drawing.Size(972, 494);
            this.mstHtmlEditor1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edtSubject);
            this.panel1.Controls.Add(this.edtEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 99);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empfänger:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Betreff:";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 33);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "HTML Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Senden";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TEditForm";
            this.Text = "TEditForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private BaiqiSoft.HtmlEditorControl.MstHtmlEditor mstHtmlEditor1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox edtSubject;
        private TextBox edtEmail;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
    }
}