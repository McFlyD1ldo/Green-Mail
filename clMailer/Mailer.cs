

using FluentEmail.Core;
using FluentEmail.Smtp;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace clMailer
{
    public class Mailer
    {
        public static SmtpClient client = new();

        public static string Username;

        public static string Password;

        public static string Host;

        public static int Port;



        public bool establishConnection(string host, int port)
        {
            try
            {
                Host = host;
                Port = port;
                client.Disconnect(true);
                client.Connect(host, port, SecureSocketOptions.StartTls);
                return client.IsConnected;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public void cutConnection()
        {
            if (client.IsConnected)
            {
                client.Disconnect(true);
            }
        }

        public bool Authenticate()
        {
            try
            {
                client.Authenticate(Username, Password);
                if (!client.IsAuthenticated) return false;
                else return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        protected static MimeMessage buildEmail(EmailDto dto)
        {
            MimeMessage mail = new();
            mail.From.Add(MailboxAddress.Parse(dto.From));
            mail.To.Add(MailboxAddress.Parse(dto.To));
            mail.Attachments.Concat(dto.Attachments);
            mail.Subject = dto.Subject;
            mail.Sender = MailboxAddress.Parse(Username);
            mail.Body = new TextPart(TextFormat.Html) { Text = dto.Body };
            return mail;
        }

        protected static List<MimeMessage> buildMassMail(List<string> adresses, EmailDto dto)
        {
            List<MimeMessage> mails = new();
            foreach (var item in adresses)
            {
                MimeMessage mail = new();
                mail.To.Add(MailboxAddress.Parse(item));
                mail.Subject = dto.Subject;
                mail.Sender = MailboxAddress.Parse(Username);
                mail.Body = new TextPart(TextFormat.Html) { Text = dto.Body };
                mail.Attachments.Concat(dto.Attachments);
                mails.Add(mail);
            }
            return mails;
        }
    
        public static async Task sendMail(EmailDto dto)
        {
            MimeMessage mail = buildEmail(dto);
            await client.SendAsync(mail);
        }

        public static async Task sendMail(MimeMessage mail)
        {
            await client.SendAsync(mail);
        }

        

        public static async Task sendMassMail(List<string> adresses, EmailDto dto)
        {
            List<MimeMessage> mails = buildMassMail(adresses, dto);
            foreach (var item in mails)
            {
                await sendMail(item);
            }
        }
    }
}