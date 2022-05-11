using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class favnews
    {
        public int agent_id { set; get; }

        public string news_name { set; get; }
        public string text_news { set; get; }

        public int news_id { set; get; }

        public int fav_id { set; get; }
        public string url_picture { set; get; }
        public string agent_name { set; get; }
    }
}