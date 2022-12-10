using wfGreenMail.Data;
using clMailer;
using Microsoft.EntityFrameworkCore;

namespace caAutoMailing
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            List<string> Attachments;
            Console.WriteLine("E-mail pending...");
            ContactDBContext GreenMailDB = new();
            wfGreenMail.ContactMailer mailer = new();
            ReadWriteINIfile reader = new(args[0]);
            Attachments = reader.ReadINI("DATA", "ATTACHMENTS").Split(';').ToList();
            mailer.establishConnection(reader.ReadINI("ACCESS", "HOST"), int.Parse(reader.ReadINI("ACCESS", "PORT")));
            wfGreenMail.ContactMailer.Username = reader.ReadINI("ACCESS", "USER");
            wfGreenMail.ContactMailer.Password = reader.ReadINI("ACCESS", "PASS");
            mailer.Authenticate();
            GreenMailDB.Contacts.Load();
            List<string> adresses = reader.ReadINI("DATA", "ADRESSES").Split(';').ToList();
            adresses.Remove(adresses.Last());
            try
            {
                if (Attachments.Count > 0)
                {
                    await wfGreenMail.ContactMailer.sendMassMail(adresses, new EmailDto(from: wfGreenMail.ContactMailer.Username, reader.ReadINI("DATA", "SUBJECT"), File.ReadAllText(reader.ReadINI("DATA", "BODY")), Attachments));
                }
                else
                {
                    await wfGreenMail.ContactMailer.sendMassMail(adresses, new EmailDto(from: wfGreenMail.ContactMailer.Username, reader.ReadINI("DATA", "SUBJECT"), File.ReadAllText(reader.ReadINI("DATA", "BODY"))));
                }
            }
            catch (Exception e)
            {
                File.WriteAllText(Environment.CurrentDirectory + "log_" + DateTime.Now, "Error while sending: " + e.Message);
            }
        }
    }
}