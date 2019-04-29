using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCISystem.DAL;
using System.Data;
using RCISystem.Model;

namespace RCISystem.BLL
{
    public class CheckService : ICheckService
    {
        private ICheckDAL checkDAL;

        public CheckService()
        {
            this.checkDAL = new CheckDAL();
        }


        public int AddCheck(CheckModel checkModel)
        {
            return this.checkDAL.AddCheck(checkModel);
        }

        public DataTable GetAllCheck()
        {
            return this.checkDAL.GetAllCheck();
        }


        public DataTable SearchCheckByCheckID(int CheckId)
        {
            return this.checkDAL.SearchCheckByCheckID(CheckId);
        }
    }
}
