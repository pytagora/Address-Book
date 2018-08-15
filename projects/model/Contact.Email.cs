using System;
using System.Collections;
using System.Net.Mail;

namespace Model
{
    public partial class Contact
    {
        public class Email
        {
            private string address = "";
            private string type = "";
            public Email()
            {

            }
            public string Address
            {
                get
                {
                    return address;
                }
                set
                {
                    if (IsValidEmail(value))
                    {
                        address = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public string Type
            {
                get
                {
                    return type;
                }
                set
                {
                    if (value.Length > 1 && value.Length < 20 && value.IsNormalized())
                    {
                        type = value;
                    }
                    else
                        throw new InvalidOperationException();
                }
            }
            public string SendEmail(string subject, string body, string sender)
            {
                if (IsValidEmail(sender))
                {
                    MailMessage mailMessage = new MailMessage(sender, Address);
                    SmtpClient smtpClient = new SmtpClient
                    {
                        Port = 25,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Host = "smptp.gmail.com"
                    };
                    mailMessage.Subject = subject;
                    mailMessage.Body = body;
                    smtpClient.Send(mailMessage);
                    return "Email have been sent successfully!\n";
                }
                else
                {
                    return "Sender email is in invalid format!\n";
                }
            }
        }
    }
}