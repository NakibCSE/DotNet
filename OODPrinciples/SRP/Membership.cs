﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using OODPrinciples.OCP;

namespace OODPrinciples.SRP
{
    public class Membership
    {
        private readonly EmailSender _emailSender;
        private readonly EncryptionUtility _encryptionUtility;
        private readonly DataUtility _dataUtility;

        public Membership()
        {
            _emailSender = new EmailSender();
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
