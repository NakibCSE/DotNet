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
            if (algorithm == "MD5")
            {
                //use md5 hashing algorithm
            }
            else if(algorithm == "SHA256")
            { 
                //use sha256 algorithm
            }
            throw new NotImplementedException();
        }
    }
}
