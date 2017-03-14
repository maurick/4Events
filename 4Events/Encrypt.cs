using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace _4Events
{
    public class Encrypt
    {
        public string EncryptPassword(string inputString)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}
