﻿using System.Web;
using System.Web.Mvc;

namespace BaiTap6_61131788
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
