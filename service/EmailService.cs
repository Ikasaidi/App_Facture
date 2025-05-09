using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;

namespace dash_app.service
{
    public class EmailService
    {
        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            string token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message sent !");
            }
            mailSent = true;
        }
        public static void main(string[] args)
        {

            SmtpClient client = new SmtpClient(args[0]);

            MailAddress from = new MailAddress
                ("jane@contoso.com",                             // email de l'utilisateur
               "Jane Clayton",                                   // nom de l'utilisateur
                System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress("kevy.jean26@gmail.com"); // email du client (receveur)

            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a the body of the email.";   // message dans l'email
            message.Subject = "This is the title of the email."; // titre dans l'email



            client.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);

            // The userState can be any object that allows your callback
            // method to identify this send operation.
            // For this example, the userToken is a string constant.
            string userState = "test message1";
            client.SendAsync(message, userState);
            Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
            string answer = Console.ReadLine();

            if (answer.StartsWith("c") && !mailSent) // peut annuler a tout moment
            {
                client.SendAsyncCancel();
            }

            message.Dispose();
            client.Dispose();
        }
    }
}
