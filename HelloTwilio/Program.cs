using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace HelloTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "usersid";
            const string authToken = "usertoken";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+821071706020");
            try
            {
                var message = MessageResource.Create(
                to,
                from: new PhoneNumber("+12563054160"),
                body: "Twilio 에서 보냅니다!!!!");

                Console.WriteLine(message.Sid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
