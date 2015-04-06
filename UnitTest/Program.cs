using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using WSharp.Core;
using WSharp.Generic;

namespace Aes_Example
{
    class AesExample
    {
        public static void Main(string[] args)
        {
            SinaEmail();
            //NetworkCredential credential = new NetworkCredential("hell.innocence@outlook.com", "PerfectPurpose").GetCredential("smtp-mail.outlook.com", 25, "TLS");
            
            Console.ReadKey(true);
        }

        public static void OutlookEmail()
        {
            MailAddress from = new MailAddress("hell.innocence@outlook.com");
            MailAddress to = new MailAddress("hell.innocence@outlook.com");
            MailMessage msg = new MailMessage(from, to);
            msg.Headers.Add("From", "hell.innocence@outlook.com");
            msg.Subject = "Hello";
            msg.Body = "Hello World";
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                Credentials = new NetworkCredential("hell.innocence@outlook.com", "PerfectPurpose"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                UseDefaultCredentials = true
            };
            client.Send(msg);
            Console.WriteLine("outlook");
        }

        public static void SinaEmail()
        {
            MailAddress from = new MailAddress("hell.innocence@sina.com");
            MailAddress to = new MailAddress("hell.innocence@outlook.com");
            MailMessage msg = new MailMessage(from, to);
            msg.Subject = "Hello";
            msg.Body = "Hello World";
            SmtpClient client = new SmtpClient("smtp.sina.com")
            {
                Credentials = new NetworkCredential("hell.innocence@sina.com", "innocence"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                UseDefaultCredentials = true
            };
            client.Send(msg);
            Console.WriteLine("outlook");
        }

    }
}