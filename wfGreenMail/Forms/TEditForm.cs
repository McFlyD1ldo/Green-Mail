global using clMailer;
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

namespace wfGreenMail
{
    public partial class TEditForm : Form
    {
        Mailer mailer;
        Contact Contact;
        public TEditForm(Mailer mailer)
        {
            this.mailer = mailer;
            
            InitializeComponent();
        }

        public TEditForm(Mailer mailer, Contact contact)
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
                File.WriteAllText(saveFileDialog1.FileName, mstHtmlEditor1.DocumentHTML);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EmailDto dto = new(Mailer.Username, edtEmail.Text, edtSubject.Text, mstHtmlEditor1.DocumentHTML);
                await Mailer.sendMail(dto);
                MessageBox.Show("E-Mail sent succesfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("There has been an error while trying to send your E-Mail:\n" +
                                ex.Message);
            }
        }
    }
}
