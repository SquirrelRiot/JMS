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
using Twilio;

namespace JMS.Services
{
    public class MessagingService 
    {
        private static readonly string _siteAdminEmailAddress = ConfigurationManager.AppSettings["SiteAdminEmailAddress"];

        public static async Task SendConfirmationEmail() //****guide
        {
            SendGridMessage myMessage = new SendGridMessage();
            myMessage.AddTo("xyz@gmail.com");
            myMessage.From = new MailAddress(_siteAdminEmailAddress, "The Honor System");
            myMessage.Subject = "Confirm Email";
            string path = HttpContext.Current.Server.MapPath("~/Template/ScheduledConfirm.html");
            string contents = File.ReadAllText(path);
            myMessage.Html = contents;
            await SendAsync(myMessage);

        }
        public static async Task CompletionMail(JuryModel model) //****guide
        {
            SendGridMessage myMessage = new SendGridMessage();

                myMessage.AddTo(model.Email);
                myMessage.From = new MailAddress(_siteAdminEmailAddress, "The Honor System");
                myMessage.Subject = "Confirm Email";
                string path = HttpContext.Current.Server.MapPath("~/Template/CompletionEmail.html");
                string contents = File.ReadAllText(path);
                myMessage.Html = contents;
                await SendAsync(myMessage);
            
        }

        private static async Task SendAsync(ISendGrid message)
        {
            var credentials = new NetworkCredential("xyz", "12345!");

            var trasportToWeb = new SendGrid.Web(credentials);

            await trasportToWeb.DeliverAsync(message);

        }

        public static void SendText()
        {
            string AccountSid = "yourAccoundSid";
            string AuthToken = "Your token";
            TwilioRestClient twilio = new TwilioRestClient(AccountSid, AuthToken);

            string TwilioNumber = "1234";
            string SendNumber = "123456";
            string text = "You have been selected for a case, please report back to the room in 1 hour";

            var message = twilio.SendMessage(TwilioNumber, SendNumber, text);
            Console.WriteLine(message.Sid);
        }
    }

}
