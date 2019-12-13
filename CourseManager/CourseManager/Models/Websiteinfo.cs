﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class Websiteinfo
    {
        
        public Websiteinfo(string siteName, string copyRight)
        {
            SiteName = siteName;
            CopyRight = copyRight;
        }

        public string SiteName { get; set; }

        public string CopyRight { get; set; }

        public object Message { get; set; }
    }
}