using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clMailer
{
    public class EmailDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        
        public List<MimeEntity> Attachments { get; set; }

        public EmailDto(string from, string to, string subject, string body)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
        }

        public EmailDto(string from, string to, string subject, string body, List<string> attachments)
        {
            Attachments = new();
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            for (int i = 0; i < attachments.Count; i++)
            {
                Attachments.Add(new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(attachments[i]), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(attachments[i])
                });
            }
        }

        public EmailDto(string from, string subject, string body, List<string> attachments)
        {
            Attachments = new();
            From = from;
            Subject = subject;
            Body = body;
            for (int i = 0; i < attachments.Count; i++)
            {
                Attachments.Add(new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(attachments[i]), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(attachments[i])
                });
            }
        }

        public EmailDto(string from, string subject, string body)
        {
            From = from;
            Subject = subject;
            Body = body;
        }
    }
}
