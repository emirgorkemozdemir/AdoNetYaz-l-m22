﻿using System.Web;
using System.Web.Mvc;

namespace AdoNetYazılım22
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
