using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfContacts.Classes
{
    public class VerificationCodeService
    {
        // Current verification code
        public static int verificationCode = 0;

        // Generate new 6-digit verification code,
        //  save it in verificationCode, 
        //  and return string containing it
        public static string GetNewVerificationCode()
        {
            Random generator = new Random();
            int codeNum = generator.Next(100000, 1000000);
            //MessageBox.Show("new code: " + codeNum);
            verificationCode = codeNum;
            return codeNum.ToString();
        }

        // Check if the input string matches current verification code
        public static bool VerificationCodeMatches (string input)
        {
            int inputNum;
            bool result = false;            
            if (int.TryParse(input, out inputNum))
            {
                if (inputNum == verificationCode)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
