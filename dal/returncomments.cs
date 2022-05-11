using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class returncomments
    {
        public int customer_id { set; get; }

        public int star { set; get; }

        public string comment { set; get; }

        public DateTime history { set; get; }

        public int agent_id { set; get; }

        public int offer_id { set; get; }

    }
}