using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Twilio;

namespace WpfContacts.Classes
{
    public class SmsService
    {

        // Account SID and auth token for Twilio
        public static string accountSid = "ACec0ad743458a6066b6f9359e1a4bdeeb";
        public static string authToken = "e6fed7966a41f4cc48d1e35fe8949693";
        public static string twilioPhoneNumber = "5162657051";

        // Send input message to input phone number
        public static bool sendSms(string phoneNumber, string message)
        {
            var twilio = new TwilioRestClient(accountSid, authToken);
            var msg = twilio.SendMessage(twilioPhoneNumber, phoneNumber, message);
            //MessageBox.Show("status: " + msg.Status + " error code: " + msg.ErrorCode +
            //                " error message: " + msg.ErrorMessage +
            //                " REST exception: " + msg.RestException);

            // SMS was sent if there is no REST exception
            if (msg.RestException == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
