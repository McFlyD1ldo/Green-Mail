

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



        public bool establishConnection(string host, int port)
        {
            try
            {
                client.Disconnect(true);
                client.Connect(host, port, SecureSocketOptions.StartTls);
                if (!client.IsConnected) return false;
                else return true;
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

        private static MimeMessage buildEmail(EmailDto dto)
        {
            MimeMessage mail = new();
            mail.From.Add(MailboxAddress.Parse(dto.From));
            mail.To.Add(MailboxAddress.Parse(dto.To));
            mail.Subject = dto.Subject;
            mail.Sender = MailboxAddress.Parse(Username);
            mail.Body = new TextPart(TextFormat.Html) { Text = dto.Body };
            return mail;
        }

        public static async Task sendMail(EmailDto dto)
        {
            MimeMessage mail = buildEmail(dto);
            await client.SendAsync(mail);
        }
    }
}