using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BlogSite.Core.Controllers;
using BlogSite.Core.ViewModels;
using Umbraco.Core.Logging;

namespace BlogSite.Core.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;

        }

        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry from: {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, message: "Error sending contact form.");
                return false;

            }
        }
    }
}
