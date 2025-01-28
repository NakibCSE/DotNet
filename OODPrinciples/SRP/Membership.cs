using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OODPrinciples.SRP
{
    public class Membership
    {
        public void CreateAccount(string userName, string password, string email)
        {

            if (!CheckDuplicateUserName(userName))
            {
                password = EncryptPassword(password);
                if (SaveAccount(userName, password, email))
                {
                    SendNewAccountEmail(email);
                }
            }
            else
            {
                throw new InvalidDataException();
            }
        }
    }
}
