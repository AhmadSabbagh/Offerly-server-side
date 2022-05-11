using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class product
    {
        public string name { set; get; }

        public int product_id { set; get; }
        public string text_information { set; get; }

        public decimal price { set; get; }
        public string url_picture { set; get; }
    }
}