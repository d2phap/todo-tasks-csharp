using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DAO
{
    public class PhuongThuc
    {
        /// <summary>
        /// Kiểm tra tính hợp lệ của email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(email))
                return false;

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(email,
                      @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$",
                      RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Mã hoá chuỗi ký tự bằng thuật toán SHA1
        /// </summary>
        /// <param name="inputString">Chuỗi cần mã hoá</param>
        /// <returns></returns>
        public static string SHA1(string inputString)
        {
            //Mã hoá bằng SHA1
            SHA1Managed sha1 = new SHA1Managed();

            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            var hashedBytes = sha1.ComputeHash(bytes);

            StringBuilder hashedBuilder = new StringBuilder(40);
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                hashedBuilder.Append(hashedBytes[i].ToString("x2"));
            }

            //Chuỗi sau khi mã hoá
            return hashedBuilder.ToString();
        }
    }
}
