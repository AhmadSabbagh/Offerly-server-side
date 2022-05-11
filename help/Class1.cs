using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orgproject.help
{
    public class Class1
    {
        public void ggg(string pass)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int d = DateTime.Now.Day;
            int day = d-2;
            if(day<=0)
            {
                day = 30;
                month = month - 1;
            }

        }
    }
}