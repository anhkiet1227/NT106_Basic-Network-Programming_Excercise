using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace simpleClient
{
    public class myTransformer
    {
        public static string Encrypt(string plaintext, int key = 5)
        {
            string ciphertext = "";
            char charater;
            for (int i = 0; i < plaintext.Length; i++)
            {
                if (plaintext[i].ToString() == " ")
                {
                    ciphertext += " ";
                }
                else if (char.IsUpper(plaintext[i]))
                {
                    charater = (char)(((int)plaintext[i] + key - 65) % 26 + 65);
                    ciphertext += charater;
                }
                else
                {
                    charater = (char)(((int)plaintext[i] + key - 97) % 26 + 97);
                    ciphertext += charater;
                }
            }
            return ciphertext;

        }
        public static string Decrypt(string ciphertext, int key = 5)
        {
            string recovertext = "";
            char character;
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (ciphertext[i].ToString() == " ")
                {
                    recovertext += " ";
                }
                else if (char.IsUpper(ciphertext[i]))
                {
                    character = (char)(((int)ciphertext[i] - key - 65 + 26) % 26 + 65);
                    recovertext += character;
                }
                else
                {
                    character = (char)(((int)ciphertext[i] - key - 97 + 26) % 26 + 97);
                    recovertext += character;
                }
            }
            return recovertext;
        }
    }
}
