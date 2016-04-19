﻿using System;
using System.Text;
using System.Security.Cryptography;


namespace Helper
{
    public static class Cryptography
    {


        public static string GenerateMD5(string value)
        {
            byte[] hash;
            if (!value.IsValidString())
            {
                return string.Empty;
            }
            using (var md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
            }
            return GetResult(hash);

        }

        public static string GenerateSHA1(string value)
        {
            byte[] hash;
            if (!value.IsValidString())
            {
                return string.Empty;
            }
            using (var sha1 = SHA1.Create())
            {
                hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(value));
            }


            return GetResult(hash);

        }

        public static string GenerateSHA256(string value)
        {
            byte[] hash;
            if (!value.IsValidString())
            {
                return string.Empty;
            }
            using (var sha1 = SHA256.Create())
            {
                hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(value));
            }
            return GetResult(hash);

        }


        public static string GenerateSHA384(string value)
        {
            byte[] hash;
            if (!value.IsValidString())
            {
                return string.Empty;
            }
            using (var sha1 = SHA384.Create())
            {
                hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(value));
            }
            return GetResult(hash);

        }


        public static string GenerateSHA512(string value)
        {
            byte[] hash;
            if (!value.IsValidString())
            {
                return string.Empty;
            }
            using (var sha1 = SHA512.Create())
            {
                hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(value));
            }
            return GetResult(hash);

        }

        //public static string GetRandomNumber()
        //{
        //    var d = new byte[10];
        //    System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(d);
        //    var result="";
        //    foreach(var i in d)
        //    {
        //        result += i.ToString("D");
        //    }         
        //    return result;
        //}

        private static string GetResult(byte[] hash)
        {
            var result = string.Empty;
            for (int i = 0; i < hash.Length; i++)
            {
                result += hash[i].ToString("x2");
            }
            return result;
        }
    }
}
