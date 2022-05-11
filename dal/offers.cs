using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class offers
    {
        public int offer_id { set; get; }

        public int agent_id { set; get; }
        public string offer_name { set; get; }

        public string descr { set; get; }

        //  public int time { set; get; }
        //  public DateTime start_time { set; get; }

        //    public DateTime end_time { set; get; }
        public string url { set; get; }
        public string agent_name { set; get; }
    }
}