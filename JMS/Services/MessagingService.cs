using JMS.Models;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace JMS.Services
{
    public class MessagingService 
    {
        private static readonly string _siteAdminEmailAddress = ConfigurationManager.AppSettings["SiteAdminEmailAddress"];

        public static async Task SendConfirmationEmail(MailModel model) //****guide
        {
            SendGridMessage myMessage = new SendGridMessage();
            myMessage.AddTo(model.Email);
            myMessage.From = new MailAddress(_siteAdminEmailAddress, "JCP Team");
            myMessage.Subject = "Confirm Email";
            string path = HttpContext.Current.Server.MapPath("~/Template/ScheduledConfirm.html");
            string contents = File.ReadAllText(path);
            myMessage.Html = contents;
            await SendAsync(myMessage);

        }

        private static async Task SendAsync(ISendGrid message)
        {
            var credentials = new NetworkCredential("Gregorio", "LosAngeles8!");

            var trasportToWeb = new SendGrid.Web(credentials);

            await trasportToWeb.DeliverAsync(message);

        }

    }

}