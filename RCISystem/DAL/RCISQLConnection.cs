using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.DAL
{
    public class RCISQLConnection
    {
        /// <summary>
        /// Gets connection string
        /// </summary>
        /// 
        protected string ConnectionString
        {
            get
            {
                return "Data Source=192.168.1.55;Initial Catalog=RCIDatabase;User ID=sa;Password=csd@dmin2017";
              //  return @"Data Source=DESKTOP-ON45COK\MSSQLSERVER2014;Initial Catalog=RCIDatabase;User ID=sa;Password=p@ssw0rd";
            }
        }
    }
}
