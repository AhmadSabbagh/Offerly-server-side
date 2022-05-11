using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.dal
{
    public class entityemployee
    {
        public int employeeid { get; set; }
        public decimal salary { get; set; }
        public string employeename { get; set; }
        public int deptid { get; set; }
        public string gender { get; set; }
        
    }
}