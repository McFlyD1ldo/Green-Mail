using Microsoft.EntityFrameworkCore;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfGreenMail.Data;
using clMailer;
using Task = System.Threading.Tasks.Task;

namespace wfGreenMail
{
    public class ContactMailer : Mailer
    {
        public static async new Task sendMail(EmailDto dto)
        {
            ContactDBContext GreenMailDB = new();
            GreenMailDB.Contacts.Load();
#pragma warning disable CS8600 
            Contact recipient = GreenMailDB.Contacts.Local.FirstOrDefault(x => x.Email == dto.To);
#pragma warning restore CS8600 
            if (recipient != null)
            {
                dto.Body = dto.Body.Replace("<<FNAME>>", recipient.FName);
                dto.Body = dto.Body.Replace("<<LNAME>>", recipient.LName);
                dto.Body = dto.Body.Replace("<<BDAY>>", recipient.Birthday.ToString());
                dto.Body = dto.Body.Replace("<<SIGNEDUP>>", recipient.SignupDate.ToString());    
            }
            MimeMessage mail = buildEmail(dto);
            await client.SendAsync(mail);
            
        }
        public static async new Task sendMassMail(List<string> adresses, EmailDto dto)
        {
            List<MimeMessage> mails = buildMassMail(adresses, dto);
            foreach (var item in mails)
            {
                await sendMail(item);
            }
        }
    }
}
