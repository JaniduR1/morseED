using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace MorseRSAAlgorithms
{

    class RSA
    {


        public class RSAEncryptor
        {
            private static RSACryptoServiceProvider rsacsp = new RSACryptoServiceProvider(1024);
        }

        public string RSAEncrypt(string rsaV)
        {
            RSACryptoServiceProvider rsacsp = new RSACryptoServiceProvider(1024);
            List<string> output = new List<string>(rsaV.Length);
            string str = rsaV;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                //char ch = str[i];
                //string[] chSplit = Regex.Split(ch.ToString(), " ");
                //int sta = Int32.Parse(chSplit.ToString());
                //int ascii = System.Convert.ToInt32(sta);
                //output.Add(ascii.ToString(), " ");

                int ascii = System.Convert.ToInt32(ch);
                string outchar =" ";
                output.Add(outchar.ToString());
                output.Add(ascii.ToString());



                var encryptedText = Math.Pow(ascii, 3);

            }

            return string.Join(" ", output);
        }
    }
}
