﻿using Microsoft.Extensions.Options;
using ShapeUp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class EmailSender : IEmailSender
    {

        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public Task SendEmail(string email, string subject, string htmlMessage)
        {
            try
            {
                using (var client = new SmtpClient
                {
                    Host = _emailSettings.MailServer,
                    Port = _emailSettings.MailPort,
                    EnableSsl = _emailSettings.EnableSsl,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(_emailSettings.SenderEmail, _emailSettings.SenderPassword)
                })
                {
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName)
                    };

                    mailMessage.To.Add(email);
                    mailMessage.Subject = subject;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = htmlMessage;
                    client.Send(mailMessage);
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Task.FromResult(0);
        }
    }

    public class EmailSettings
    {
        public string MailServer { get; set; }
        public int MailPort { get; set; }
        public bool EnableSsl { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
    }
}
