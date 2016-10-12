using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Properties;
using System.Collections.Specialized;

namespace WebApp.AppLevel
{
    public class AppLvl
    {
        string level = Properties.Settings.Default.AppLevel;
        public string setConnectionString(string Database)
        {
        string connect="";
        switch (level)
        {
        case "D": 
        connect = "data source=engdevsql.nscorp.com;initial catalog="+ Database +";integrated security=True;MultipleActiveResultSets=True;";
        break; 
        case "Q":
        connect = "data source=engqasql.nscorp.com;initial catalog="+ Database +";integrated security=True;MultipleActiveResultSets=True;";
        break;
        case "P":
        connect = "data source=engsql.nscorp.com;initial catalog="+ Database +";integrated security=True;MultipleActiveResultSets=True;";
        break; 
    }
        return connect;
        
        }
        
    }
}