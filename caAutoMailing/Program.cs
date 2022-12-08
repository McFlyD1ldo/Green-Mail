using wfGreenMail.Data;
using wfGreenMail;
using clMailer;
using Microsoft.EntityFrameworkCore;

namespace caAutoMailing
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("E-mail pending...");
            ContactDBContext GreenMailDB = new();
            ContactMailer mailer = new();
            mailer.establishConnection(args[0], int.Parse(args[1]));
            ContactMailer.Username = args[2];
            ContactMailer.Password = args[3];
            mailer.Authenticate();
            GreenMailDB.Contacts.Load();
            var contacts = GreenMailDB.Contacts.Local.Where(c => c.Newsletter).ToList();
            List<string> adresses = new();
            foreach (var item in contacts)
            {
                adresses.Add(item.Email);
            }
            try
            {
               await ContactMailer.sendMassMail(adresses, new EmailDto(from: ContactMailer.Username, args[4], File.ReadAllText(args[5])));
            }
            catch (Exception e)
            {

                File.WriteAllText(Environment.CurrentDirectory + "log_" + DateTime.Now, "Error while sending: " + e.Message);
            }
        }
    }
}