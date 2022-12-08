namespace wfGreenMail
{
    partial class TLoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edtUser = new System.Windows.Forms.TextBox();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(39, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(366, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Log in to your E-mail account";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(0, 198);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 21);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(-1, 244);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(79, 21);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password:";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProvider.ForeColor = System.Drawing.Color.White;
            this.lblProvider.Location = new System.Drawing.Point(-1, 140);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(72, 21);
            this.lblProvider.TabIndex = 3;
            this.lblProvider.Text = "Provider:";
            // 
            // cbProvider
            // 
            this.cbProvider.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbProvider.DataSource = this.providerBindingSource;
            this.cbProvider.DisplayMember = "Name";
            this.cbProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProvider.ForeColor = System.Drawing.Color.White;
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(85, 138);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(121, 23);
            this.cbProvider.TabIndex = 4;
            this.cbProvider.ValueMember = "Host";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(clMailer.Provider);
            // 
            // edtUser
            // 
            this.edtUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edtUser.ForeColor = System.Drawing.Color.White;
            this.edtUser.Location = new System.Drawing.Point(85, 196);
            this.edtUser.Name = "edtUser";
            this.edtUser.Size = new System.Drawing.Size(320, 23);
            this.edtUser.TabIndex = 5;
            this.edtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtUser_KeyDown);
            // 
            // edtPass
            // 
            this.edtPass.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edtPass.ForeColor = System.Drawing.Color.White;
            this.edtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edtPass.Location = new System.Drawing.Point(85, 242);
            this.edtPass.Name = "edtPass";
            this.edtPass.PasswordChar = '$';
            this.edtPass.Size = new System.Drawing.Size(320, 23);
            this.edtPass.TabIndex = 6;
            this.edtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtPass_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(142, 312);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 43);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // TLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(461, 367);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.edtPass);
            this.Controls.Add(this.edtUser);
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTitle);
            this.Name = "TLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblUser;
        private Label lblPass;
        private Label lblProvider;
        private ComboBox cbProvider;
        private TextBox edtUser;
        private TextBox edtPass;
        private Button btnLogin;
        private BindingSource providerBindingSource;
    }
}