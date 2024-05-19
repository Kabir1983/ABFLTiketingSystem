using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace COMMON
{
    public class Sha1
    {
        
        private string _PlainText, _EncryptString;

        public string EncryptString
        {
            get { return _EncryptString; }
            set { _EncryptString = value; }
        }

        public string PlainText
        {
            get { return _PlainText; }
            set { _PlainText = value; }
        }

        public Sha1() {  }

        /// <summary>
        /// Return Encrypted String
        /// </summary>
        /// <param name="sha1Obj"></param>
        /// <returns></returns>
        /// 
        public string GetEncryptString(string plaintext)
        {
            return HashValue.Encrypt(plaintext);
        }

        /// <summary>
        /// Return the Plain text
        /// </summary>
        /// <param name="sha1Obj"></param>
        /// <returns></returns>
        /// 
        public string GetDecryptString(string encryptedString)
        {
            return HashValue.Decrypt(encryptedString);
        }

    }
}
