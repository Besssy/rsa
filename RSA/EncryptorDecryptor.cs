using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace RSA
{
    class EncryptorDecryptor
    {
        public BigInteger c, m;

        public void Encrypt(BigInteger m, BigInteger e, BigInteger n)          //encryption
        {
            c = BigInteger.ModPow(m, e, n);
        }

        public void Decrypt(BigInteger cResult, BigInteger d, BigInteger n)    //decryption
        {
            m = BigInteger.ModPow(cResult, d, n);
        }
    }
}
