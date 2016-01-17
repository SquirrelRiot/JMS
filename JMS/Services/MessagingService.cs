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
            myMessage.AddTo("brijesh16386@gmail.com");
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
            var credentials = new NetworkCredential("Gregorio", "LosAngeles8!");

            var trasportToWeb = new SendGrid.Web(credentials);

            await trasportToWeb.DeliverAsync(message);

        }

        public static void SendText()
        {
            string AccountSid = "AC452813c46fd124fcfc48dcd617629b88";
            string AuthToken = "cfe9efda0c5bf9ce8da79d593f8148ef";
            TwilioRestClient twilio = new TwilioRestClient(AccountSid, AuthToken);

            string TwilioNumber = "+12016853569";
            string SendNumber = "+13233604432";
            string text = "You have been selected for a case, please report back to the room in 1 hour";

            var message = twilio.SendMessage(TwilioNumber, SendNumber, text);
            Console.WriteLine(message.Sid);
        }
    }

}