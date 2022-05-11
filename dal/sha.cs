using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace orgproject.dal
{
    public class sha
    {

        public string SHA512(string pass)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(pass);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }


        public string SHA510(int id)
        {
            string ID = id.ToString();
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(ID);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}