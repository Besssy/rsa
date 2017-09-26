using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;

namespace RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyGenerator p = new KeyGenerator();
            KeyGenerator q = new KeyGenerator();
            KeyGenerator e = new KeyGenerator();
            KeyGenerator f = new KeyGenerator();
            KeyGenerator pub_key = new KeyGenerator();
            KeyGenerator priv_key = new KeyGenerator();
            EncryptorDecryptor cipher = new EncryptorDecryptor();
            EncryptorDecryptor plain = new EncryptorDecryptor();

            p.randomGenerator();
            q.randomGenerator();
            e.randomGenerator();

            BigInteger n;
            if (p.MillerRabinTest(10) == true && q.MillerRabinTest(10) == true)
            {
                n = p.result * q.result;
            }
            else
            {
                p.GetNearestPrime();
                q.GetNearestPrime();
                n = p.result * q.result;
            }

            f.EulerFunction(p.result, q.result);
            pub_key.GeneratePublicKey(e.result, n);
            priv_key.GeneratePrivateKey(e.result);

            Console.WriteLine("Enter your message:");
            string msg = Console.ReadLine();
            BigInteger m = BigInteger.Parse(msg);

            cipher.Encrypt(m, e.result, n);
            Console.WriteLine("The ciphertext is : {0}", cipher.c);

            plain.Decrypt(cipher.c, priv_key.d, n);
            Console.WriteLine("The plaintext is : {0}", plain.m);

        }
    }
}
