﻿using Microsoft.EntityFrameworkCore;
using MimeKit.Cryptography;
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
    public partial class TMainForm : Form
    {
        ContactMailer mailer;
        ContactDBContext GreenMailDB;

        public TMainForm(ContactMailer mailer)
        {
            this.mailer = mailer;
            InitializeComponent();
            GreenMailDB = new();
            GreenMailDB.Contacts.Load();
            grdContacts.DataSource = GreenMailDB.Contacts.Local.ToBindingList();
        }

        private void writingtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TEditForm editForm = new(mailer);
            editForm.ShowDialog();
        }
        private void massmailingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMassMailForm mailForm = new(mailer);
            mailForm.ShowDialog();
        }
        private void eMailAutomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TAutomizeForm automizeForm = new();
            automizeForm.ShowDialog();
        }

        private void TMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GreenMailDB.SaveChanges();
            GreenMailDB.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (edtLName.Text == string.Empty || edtEmail.Text == string.Empty) MessageBox.Show("Last name and E-Mail adress are required fields. Make sure to fill them with a value");
            else
            {
                Contact contact = new();
                contact.Id = GreenMailDB.Contacts.Count();
                contact.LName = edtLName.Text;
                contact.Email = edtEmail.Text;
                contact.FName = edtFName.Text;
                if (tdmBday.Value != DateTime.MinValue) contact.Birthday = tdmBday.Value;
                GreenMailDB.Contacts.Add(contact);
                GreenMailDB.SaveChanges();
                grdContacts.DataSource = GreenMailDB.Contacts.Local.ToBindingList();
            }
        }

        /// <summary>
        /// This method is called when the user double clcks a cell. It will open the edit form with the selected contact to instantly write an email to this contact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdContacts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Contact contact = (Contact)grdContacts.Rows[e.RowIndex].DataBoundItem;
            TEditForm editForm = new(mailer, contact);
            editForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GreenMailDB.SaveChanges();
            grdContacts.DataSource = GreenMailDB.Contacts.Local.ToBindingList();
        }

        private void tcEditMode_SelectedIndexChanging(object sender, TabPageChangeEventArgs e)
        {
            GreenMailDB.SaveChanges();
            if (e.NextTab == tabPage1)
            {
                edtFName.Text = string.Empty;
                edtLName.Text = string.Empty;
                edtEmail.Text = string.Empty;
                tdmBday.Value = DateTime.MinValue;
                GreenMailDB.Contacts.Load();
                grdContacts.DataSource = GreenMailDB.Contacts.Local.ToBindingList();
            }
            else
            {
                edtsFname.Text = string.Empty;
                edtsLname.Text = string.Empty;
                edtsEmail.Text = string.Empty;
                dpsBday.Value = DateTime.MinValue;
                grdContacts.DataSource = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Contact> result = GreenMailDB.Contacts.Local.ToList();
            if (edtsFname.Text != string.Empty)
            {
                result = result.Where(c => c.FName.Contains(edtsFname.Text)).ToList();
            }
            if (edtsLname.Text != string.Empty)
            {
                result = result.Where(c => c.LName.Contains(edtsLname.Text)).ToList();
            }
            if (edtsEmail.Text != string.Empty)
            {
                result = result.Where(c => c.Email.Contains(edtsEmail.Text)).ToList();
            }
            if (dpsBday.Value != DateTime.Parse("1753-01-01"))
            {
                result = result.Where(c => c.Birthday == dpsBday.Value).ToList();
            }
            if (cbsNewsletter.Checked)
            {
                result = result.Where(c => c.Newsletter == cbsNewsletter.Checked).ToList();
            }
            grdContacts.DataSource = result;
        }
    }
}
