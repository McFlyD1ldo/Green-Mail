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

        public EmailDto(string from, string to, string subject, string body)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
        }
    }
}
