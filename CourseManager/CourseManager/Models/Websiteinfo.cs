﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class ActionLink
    {
        public string Name{get;set; }

        public string Controller{ get;set;}

        public string Action{ get;set;}
    }



    public class  Websiteinfo
    {

        public const string SiteName = "课程管理系统";
        public object CopyRight;

        public List<ActionLink>ActionLinks{get;set;}

         public  Websiteinfo()
         {
             ActionLinks=new List<ActionLink>
             {
             new ActionLink{Name="主页" ,Controller="Home", Action="Index"},
              new ActionLink{Name="关于" ,Controller="Home", Action="About"},
               new ActionLink{Name="联系方式" ,Controller="Home", Action="Contact"}

             };
         }

    }
}