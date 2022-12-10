using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using caAutoMailing;
using Task = Microsoft.Win32.TaskScheduler.Task;

namespace wfGreenMail.Forms
{
    public partial class TAutomizeForm : Form
    {
        private int selectedRB = 0;
        private string MailPath;
        private List<string> Attachments = new();
        public TAutomizeForm()
        {
            InitializeComponent();
            dpStartDate.MinDate = DateTime.Now;
            dpStartTime.MinDate = DateTime.Now;
            dpExpireDate.MinDate = DateTime.Now;
            dpExpireTime.MinDate = DateTime.Now;
        }

        private void rbOnce_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnce.Checked)
            {
                #region UI 
                selectedRB = 0;
                lblRepeat.Visible = false;
                lblSpan.Visible = false;
                lblMonths.Visible = false;
                lblDays.Visible = false;
                edtRepeat.Visible = false;
                clbWeeksOfMonth.Visible = false;
                clbDays.Visible = false;
                clbMonths.Visible = false;
                #endregion
            }
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDaily.Checked)
            {
                #region UI 
                selectedRB = 1;
                lblRepeat.Visible = true;
                lblSpan.Visible = true;
                edtRepeat.Visible = true;
                #endregion
            }
            else
            {
                lblRepeat.Visible = false;
                lblSpan.Visible = false;
                edtRepeat.Visible = false;
            }
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeekly.Checked)
            {
                #region UI 
                selectedRB = 2;
                lblSpan.Text = "weeks on";
                clbDays.Left = 280;
                lblRepeat.Visible = true;
                lblSpan.Visible = true;
                edtRepeat.Visible = true;
                clbDays.Visible = true;
                #endregion
            }
            else
            {
                lblRepeat.Visible = false;
                lblSpan.Visible = false;
                edtRepeat.Visible = false;
                clbDays.Visible = false;
            }
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonthly.Checked)
            {
                #region UI 
                selectedRB = 3;
                clbDays.Left = 163;
                lblDays.Visible = true;
                lblMonths.Visible = true;
                clbWeeksOfMonth.Visible = true;
                clbDays.Visible = true;
                clbMonths.Visible = true;
                #endregion

            }
            else
            {
                lblDays.Visible = false;
                lblMonths.Visible = false;
                clbWeeksOfMonth.Visible = false;
                clbDays.Visible = false;
                clbMonths.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MailPath = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (selectedRB)
            {
                case 0:
                    registerTaskOnce();
                    break;
                case 1:
                    registerTaskDaily();
                    break;
                case 2:
                    registerTaskWeekly();
                    break;
                case 3:
                    registerTaskMonthly();
                    break;
            }

        }

        private void registerTaskMonthly()
        {
            using (TaskService ts = new TaskService())
            using (ReadWriteINIfile writer = new(Environment.CurrentDirectory + "\\AutoMail\\monthlytask_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ".ini"))
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Green Mail automated monthly E-Mail";

                Trigger trigger = new MonthlyDOWTrigger()
                {
                    StartBoundary = dpStartDate.Value.Date + TimeSpan.FromHours(dpStartTime.Value.Hour) + TimeSpan.FromMinutes(dpStartTime.Value.Minute),
                    MonthsOfYear = getMonthsOfYear(),
                    WeeksOfMonth = getWeeksOfMonth(),
                    DaysOfWeek = getDaysOfWeek()

                };
                if (cbExp.Checked) trigger.EndBoundary = dpExpireDate.Value.Date + TimeSpan.FromHours(dpExpireTime.Value.Hour) + TimeSpan.FromMinutes(dpExpireTime.Value.Minute);
                td.Triggers.Add(trigger);
                writer.WriteINI("ACCESS", "HOST", ContactMailer.Host);
                writer.WriteINI("ACCESS", "PORT", ContactMailer.Port.ToString());
                writer.WriteINI("ACCESS", "USER", ContactMailer.Username);
                writer.WriteINI("ACCESS", "PASS", ContactMailer.Password);
                writer.WriteINI("DATA", "SUBJECT", edtSubj.Text);
                writer.WriteINI("DATA", "BODY", MailPath);
                writer.WriteINI("DATA", "ATTACHMENTS", string.Join(';', Attachments));
                writer.WriteINI("DATA", "ADRESSES", string.Join(';', Attachments)); //TODO generate List of Contacts
                td.Actions.Add(Environment.CurrentDirectory + "\\AutoMail\\caAutoMailing.exe", writer.path);
                ts.RootFolder.RegisterTaskDefinition(@"Green Mail automated monthly Email Task " + Guid.NewGuid().ToString(), td);
            }
        }

        private void registerTaskWeekly()
        {
            using (TaskService ts = new TaskService())
            using (ReadWriteINIfile writer = new(Environment.CurrentDirectory + "\\AutoMail\\weeklytask_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ".ini"))
            { 
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Green Mail automated weekly E-Mail";

                Trigger trigger = new WeeklyTrigger
                {
                    StartBoundary = dpStartDate.Value.Date + TimeSpan.FromHours(dpStartTime.Value.Hour) + TimeSpan.FromMinutes(dpStartTime.Value.Minute),
                    WeeksInterval = short.Parse(edtRepeat.Text),
                    DaysOfWeek = getDaysOfWeek()

                };
                if (cbExp.Checked) trigger.EndBoundary = dpExpireDate.Value.Date + TimeSpan.FromHours(dpExpireTime.Value.Hour) + TimeSpan.FromMinutes(dpExpireTime.Value.Minute);
                td.Triggers.Add(trigger);
                writer.WriteINI("ACCESS", "HOST", ContactMailer.Host);
                writer.WriteINI("ACCESS", "PORT", ContactMailer.Port.ToString());
                writer.WriteINI("ACCESS", "USER", ContactMailer.Username);
                writer.WriteINI("ACCESS", "PASS", ContactMailer.Password);
                writer.WriteINI("DATA", "SUBJECT", edtSubj.Text);
                writer.WriteINI("DATA", "BODY", MailPath);
                writer.WriteINI("DATA", "ATTACHMENTS", string.Join(';', Attachments));
                td.Actions.Add(Environment.CurrentDirectory + "\\AutoMail\\caAutoMailing.exe", writer.path);
                ts.RootFolder.RegisterTaskDefinition(@"Green Mail automated weekly Email Task " + Guid.NewGuid().ToString(), td);
            }
        }

        private void registerTaskDaily()
        {
            using (TaskService ts = new TaskService())
            using (ReadWriteINIfile writer = new(Environment.CurrentDirectory + "\\AutoMail\\dailytask_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ".ini"))
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Green Mail automated daily E-Mail";

                Trigger trigger = new DailyTrigger
                {
                    StartBoundary = dpStartDate.Value.Date + TimeSpan.FromHours(dpStartTime.Value.Hour) + TimeSpan.FromMinutes(dpStartTime.Value.Minute),
                    DaysInterval = short.Parse(edtRepeat.Text)

                };
                
                if (cbExp.Checked) trigger.EndBoundary = dpExpireDate.Value.Date + TimeSpan.FromHours(dpExpireTime.Value.Hour) + TimeSpan.FromMinutes(dpExpireTime.Value.Minute);
                td.Triggers.Add(trigger);
                writer.WriteINI("ACCESS", "HOST", ContactMailer.Host);
                writer.WriteINI("ACCESS", "PORT", ContactMailer.Port.ToString());
                writer.WriteINI("ACCESS", "USER", ContactMailer.Username);
                writer.WriteINI("ACCESS", "PASS", ContactMailer.Password);
                writer.WriteINI("DATA", "SUBJECT", edtSubj.Text);
                writer.WriteINI("DATA", "BODY", MailPath);
                writer.WriteINI("DATA", "ATTACHMENTS", string.Join(';', Attachments));
                td.Actions.Add(Environment.CurrentDirectory + "\\AutoMail\\caAutoMailing.exe", writer.path);
                ts.RootFolder.RegisterTaskDefinition(@"Green Mail automated daily Email Task " + Guid.NewGuid().ToString(), td);
            }
        }

        private void registerTaskOnce()
        {
            
            using (TaskService ts = new TaskService())
            using (ReadWriteINIfile writer = new(Environment.CurrentDirectory + "\\AutoMail\\task_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ".ini"))
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Green Mail automated E-Mail";
                Trigger trigger = new TimeTrigger
                {
                    StartBoundary = dpStartDate.Value.Date + TimeSpan.FromHours(dpStartTime.Value.Hour) + TimeSpan.FromMinutes(dpStartTime.Value.Minute),
                };
                if (cbExp.Checked) trigger.EndBoundary = dpExpireDate.Value.Date + TimeSpan.FromHours(dpExpireTime.Value.Hour) + TimeSpan.FromMinutes(dpExpireTime.Value.Minute);
                td.Triggers.Add(trigger);
                writer.WriteINI("ACCESS", "HOST", ContactMailer.Host);
                writer.WriteINI("ACCESS", "PORT", ContactMailer.Port.ToString());
                writer.WriteINI("ACCESS", "USER", ContactMailer.Username);
                writer.WriteINI("ACCESS", "PASS", ContactMailer.Password);
                writer.WriteINI("DATA", "SUBJECT", edtSubj.Text);
                writer.WriteINI("DATA", "BODY", MailPath);
                writer.WriteINI("DATA", "ATTACHMENTS", string.Join(';', Attachments));
                writer.WriteINI("DATA", "ADRESSES", "dani.mannsroller@googlemail.com");
                td.Actions.Add(Environment.CurrentDirectory + "\\AutoMail\\caAutoMailing.exe", writer.path);
                ts.RootFolder.RegisterTaskDefinition(@"Green Mail automated Email Task " + Guid.NewGuid().ToString(), td);
            }
        }

        private DaysOfTheWeek getDaysOfWeek()
        {
            DaysOfTheWeek days = new();
            if (clbDays.GetItemChecked(0)) days |= DaysOfTheWeek.Sunday;
            if (clbDays.GetItemChecked(1)) days |= DaysOfTheWeek.Monday;
            if (clbDays.GetItemChecked(2)) days |= DaysOfTheWeek.Tuesday;
            if (clbDays.GetItemChecked(3)) days |= DaysOfTheWeek.Wednesday;
            if (clbDays.GetItemChecked(4)) days |= DaysOfTheWeek.Thursday;
            if (clbDays.GetItemChecked(5)) days |= DaysOfTheWeek.Friday;
            if (clbDays.GetItemChecked(6)) days |= DaysOfTheWeek.Saturday;
            return days;
        }

        private WhichWeek getWeeksOfMonth()
        {
            WhichWeek weeks = new();
            if (clbWeeksOfMonth.GetItemChecked(0)) weeks |= WhichWeek.FirstWeek;
            if (clbWeeksOfMonth.GetItemChecked(1)) weeks |= WhichWeek.SecondWeek;
            if (clbWeeksOfMonth.GetItemChecked(2)) weeks |= WhichWeek.ThirdWeek;
            if (clbWeeksOfMonth.GetItemChecked(3)) weeks |= WhichWeek.FourthWeek;
            if (clbWeeksOfMonth.GetItemChecked(4)) weeks |= WhichWeek.LastWeek;
            return weeks;
        }

        private MonthsOfTheYear getMonthsOfYear()
        {
            MonthsOfTheYear months = new();
            if (clbMonths.GetItemChecked(0)) months |= MonthsOfTheYear.January;
            if (clbMonths.GetItemChecked(1)) months |= MonthsOfTheYear.February;
            if (clbMonths.GetItemChecked(2)) months |= MonthsOfTheYear.March;
            if (clbMonths.GetItemChecked(3)) months |= MonthsOfTheYear.April;
            if (clbMonths.GetItemChecked(4)) months |= MonthsOfTheYear.May;
            if (clbMonths.GetItemChecked(5)) months |= MonthsOfTheYear.June;
            if (clbMonths.GetItemChecked(6)) months |= MonthsOfTheYear.July;
            if (clbMonths.GetItemChecked(7)) months |= MonthsOfTheYear.August;
            if (clbMonths.GetItemChecked(8)) months |= MonthsOfTheYear.September;
            if (clbMonths.GetItemChecked(9)) months |= MonthsOfTheYear.October;
            if (clbMonths.GetItemChecked(10)) months |= MonthsOfTheYear.November;
            if (clbMonths.GetItemChecked(11)) months |= MonthsOfTheYear.December;
            return months;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet working, TODO: find way to pass attachments in args");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Attachments.Add(openFileDialog1.FileName);
                lblAttachments.Text = string.Join(";", Attachments);
            }
        }

        private void lblAttachments_Paint(object sender, PaintEventArgs e)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lblAttachments.Width, lblAttachments.Height);
            this.lblAttachments.Region = new Region(path);
        }
    }
}

