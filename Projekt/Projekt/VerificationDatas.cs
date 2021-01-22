using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    static class VerificationDatas
    {

       public static bool verificationEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool verificationName(string name)
        {
            if (name.Length > 2)
            {
                return true;
            }
            return false;
        }
        public static bool verificationSurname(string surname)
        {
            if (surname.Length > 2)
            {
                return true;
            }
            return false;
        }
        public static bool verificationPassword(string password)
        {
            if (password.Length >= 12)
            {
                return true;
            }
            return false;
        }
    }
}
