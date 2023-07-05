using job_coaching_blazor_server.Data;
using Microsoft.AspNetCore.Identity.UI.Services;

using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Azure.Core;

namespace job_coaching_blazor_server.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            if (string.IsNullOrEmpty(Secrets.smtpSettings.server))
            {
                throw new Exception("Null no server added");
            }


            var server = Secrets.smtpSettings.server;
            var port = Secrets.smtpSettings.port;
            var username = Secrets.smtpSettings.username;
            var password = Secrets.smtpSettings.password;
            var useSsl = Secrets.smtpSettings.useSSL;

            Console.WriteLine(Secrets.smtpSettings.username);
            Console.WriteLine(Secrets.smtpSettings.password);

            var _message = new MimeMessage();

            _message.From.Add(new MailboxAddress("Your Application", username));
            _message.To.Add(new MailboxAddress("", toEmail));
            _message.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = message;
            _message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(server, port, SecureSocketOptions.StartTlsWhenAvailable);
                await client.AuthenticateAsync(username, password);
                await client.SendAsync(_message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
