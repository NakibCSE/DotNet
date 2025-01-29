using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODPrinciples.OCP
{
    public class MD5EncryptionUtility : IEncryptionProcess
    {
        private readonly string _encryptionHash = "This sis is my original sis";
        public string EncryptPassword(string password)
        {
            //Use MD5 hashing algorithm
            throw new NotImplementedException();
        }
    }
}
