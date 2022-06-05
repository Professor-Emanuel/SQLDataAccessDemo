using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLDataAccessDemo2
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            //this will look-up the connection string just from the name
            var output =  ConfigurationManager.ConnectionString[name].ConnectionString;
            return output;
        }
    }
}
