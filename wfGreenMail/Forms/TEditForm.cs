global using clMailer;
global using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfGreenMail.Data;

namespace wfGreenMail
{
    public partial class TEditForm : Form
    {
        ContactMailer
            mailer;
        Contact Contact;
        private List<string> Attachments = new();
        public TEditForm(ContactMailer mailer)
        {
            this.mailer = mailer;
            
            InitializeComponent();
        }

        public TEditForm(ContactMailer mailer, Contact contact)
        {
            Contact = contact;
            this.mailer = mailer;
            InitializeComponent();
            edtEmail.Text = Contact.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, HtmlEditor.DocumentHTML);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EmailDto dto = new(ContactMailer.Username, edtEmail.Text, edtSubject.Text, HtmlEditor.DocumentHTML, Attachments);
                await ContactMailer.sendMail(dto);
                MessageBox.Show("E-Mail sent succesfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("There has been an error while trying to send your E-Mail:\n" +
                                ex.Message);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Attachments.Add(openFileDialog1.FileName);
                lblAttachments.Text += openFileDialog1.FileName.Split('\\').Last() + ';';
            }
        }
    }
}
