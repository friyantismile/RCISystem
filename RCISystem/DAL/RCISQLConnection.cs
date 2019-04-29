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
                return "Data Source=desktop-jivsijp;Initial Catalog=RCIDatabase;User ID=sa;Password=admin1234";
            }
        }
    }
}
