﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class agentloc
    {
        public int agent_id { set; get; }

        public string name { set; get; }
        public decimal latitude { set; get; }
        public decimal longitude { set; get; }
    }
}