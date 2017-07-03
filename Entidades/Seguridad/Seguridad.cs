using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Seguridad
{
    public class Seguridad
    {
        public string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            //string result;
            //byte[] decrypted = Convert.FromBase64String(output.ToString());
            //result = System.Text.Encoding.Unicode.GetString(decrypted);

            return output.ToString();
        }
        //public static string Decrypt(string password)
        //{

        //    if (password == null)
        //    {
        //        password = String.Empty;
        //    }

        //    // Get the bytes of the string
        //    var bytesToBeDecrypted = Convert.FromBase64String(password);
        //    var passwordBytes = Encoding.UTF8.GetBytes(password);

        //    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        //    var bytesDecrypted = Cipher.Decrypt(bytesToBeDecrypted, passwordBytes);

        //    return Encoding.UTF8.GetString(bytesDecrypted);
        //}
    }
}
