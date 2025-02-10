using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using OODPrinciples.OCP;

namespace OODPrinciples.DIP
{
    public class Membership
    {
        private readonly IEmailSender _emailSender;
        private readonly EncryptionUtility _encryptionUtility;
        private readonly DataUtility _dataUtility;

        public Membership(IEmailSender emailSender)
        {
            _emailSender = emailSender;
            _encryptionUtility = new EncryptionUtility();
            _dataUtility = new DataUtility();
        }
        public void CreateAccount(string userName, string password, string email)
        {

            if (!_dataUtility.CheckDuplicateUserName(userName))
            {
                password = _encryptionUtility.EncryptPassword(password);
                if (_dataUtility.SaveAccount(userName, password, email))
                {
                    _emailSender.SendNewAccountEmail(email);
                }
            }
            else
            {
                throw new InvalidDataException();
            }
        }
    }
}
