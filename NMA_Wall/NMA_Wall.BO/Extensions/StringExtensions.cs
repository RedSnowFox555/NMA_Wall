﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NMA_Wall.BO.Extensions
{
    public static class StringExtensions
    {
        public enum eHashType
        {
            HMAC, HMACMD5, HMACSHA1, HMACSHA256, HMACSHA384, HMACSHA512,
            MACTripleDES, MD5, RIPEMD160, SHA1, SHA256, SHA384, SHA512
        }

        private static byte[] GetHash(string input, eHashType hash = eHashType.MD5)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);

            switch (hash)
            {
                case eHashType.HMAC:
                    return HMAC.Create().ComputeHash(inputBytes);

                case eHashType.HMACMD5:
                    return HMACMD5.Create().ComputeHash(inputBytes);

                case eHashType.HMACSHA1:
                    return HMACSHA1.Create().ComputeHash(inputBytes);

                case eHashType.HMACSHA256:
                    return HMACSHA256.Create().ComputeHash(inputBytes);

                case eHashType.HMACSHA384:
                    return HMACSHA384.Create().ComputeHash(inputBytes);

                case eHashType.HMACSHA512:
                    return HMACSHA512.Create().ComputeHash(inputBytes);

                case eHashType.MACTripleDES:
                    return MACTripleDES.Create().ComputeHash(inputBytes);

                case eHashType.MD5:
                    return MD5.Create().ComputeHash(inputBytes);

                case eHashType.RIPEMD160:
                    return RIPEMD160.Create().ComputeHash(inputBytes);

                case eHashType.SHA1:
                    return SHA1.Create().ComputeHash(inputBytes);

                case eHashType.SHA256:
                    return SHA256.Create().ComputeHash(inputBytes);

                case eHashType.SHA384:
                    return SHA384.Create().ComputeHash(inputBytes);

                case eHashType.SHA512:
                    return SHA512.Create().ComputeHash(inputBytes);

                default:
                    return inputBytes;
            }
        }

        /// <summary>
        /// Computes the hash of the string using a specified hash algorithm
        /// </summary>
        /// <param name="input">The string to hash</param>
        /// <param name="hashType">The hash algorithm to use</param>
        /// <returns>The resulting hash or an empty string on error</returns>
        public static string ComputeHash(this string input, eHashType hashType = eHashType.MD5)
        {
            try
            {
                byte[] hash = GetHash(input, hashType);
                StringBuilder ret = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                    ret.Append(hash[i].ToString("x2"));

                return ret.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }

    public static class DateTimeExtensions
    {
        public static string DayExtestion(this DateTime datetime)
        {
            return (datetime.Day % 10 == 1 && datetime.Day != 11) ? "st" : (datetime.Day % 10 == 2 && datetime.Day != 12) ? "nd" :
                        (datetime.Day % 10 == 3 && datetime.Day != 13) ? "rd" : "th";
        }
        public static string DayExtestion(this int day)
        {
            return
                (day % 10 == 1 && day != 11) ? "st" :
                (day % 10 == 2 && day != 12) ? "nd" :
                (day % 10 == 3 && day != 13) ? "rd" : "th";
        }

        public static string ToString(this DateTime dateTime, string format, bool useExtendedSpecifiers)
        {
            return dateTime.ToString(format)
                .Replace("nn", dateTime.Day.DayExtestion().ToLower());
        }
    }
}
