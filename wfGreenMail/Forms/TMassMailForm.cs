using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfGreenMail.Data;

namespace wfGreenMail.Forms
{
    public partial class TMassMailForm : Form
    {
        Mailer mailer;
        ContactDBContext GreenMailDB;
        string messageBody;
        private List<string> Attachments = new();
        public TMassMailForm(Mailer mailer)
        {
            this.mailer = mailer;
            InitializeComponent();
            GreenMailDB = new();
            GreenMailDB.Contacts.Load();
            lbContacts.DataSource = GreenMailDB.Contacts.Local.ToBindingList();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                messageBody = File.ReadAllText(openFileDialog.FileName);
                htmlMessage.DocumentHTML = messageBody;
            }

        }

        private void TMassMailForm_Resize(object sender, EventArgs e)
        {
            btnMessage.Left = ((this.Width - 270) / 2 - 130) + 270;
            btnSend.Left = btnMessage.Left + 180;
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            ContactDBContext GreenMailDB = new();
            GreenMailDB.Contacts.Load();
            lbContacts.DataSource = GreenMailDB.Contacts.Local.Where(x => x.Newsletter == true).ToList();
            lbContacts.DisplayMember = "Email";
            lbContacts.ValueMember = "Email";
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            EmailDto dto = new(Mailer.Username, edtSubj.Text, htmlMessage.DocumentHTML, Attachments);
            List<Contact> contacts = new();
            List<string> adresses = new();
            using (ContactDBContext db = new())
            {
                contacts = lbContacts.Items.Cast<Contact>().ToList();
            }
            foreach (var contact in contacts)
            {
                adresses.Add(contact.Email);
            }
            await Mailer.sendMassMail(adresses, dto);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Attachments.Add(openFileDialog.FileName);
                lblAttachments.Text += openFileDialog.FileName.Split('\\').Last() + ';';
            }
        }

        private void lblAttachments_Paint(object sender, PaintEventArgs e)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lblAttachments.Width, lblAttachments.Height + 5);
            this.lblAttachments.Region = new Region(path);
        }
    }
}
