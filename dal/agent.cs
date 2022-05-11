using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class  agent
    {
        public int agent_id { set; get; }

        public string name { set; get; }
        public string phone { set; get; }
        public string address { set; get; }

        public string city { set; get; }
        public string descr { set; get; }
        public string url { set; get; }

        public decimal latitude { set; get; }
        public decimal longitude { set; get; }
    }
}
