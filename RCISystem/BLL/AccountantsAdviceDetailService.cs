using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCISystem.DAL;
using System.Data;

namespace RCISystem.BLL
{
    public class AccountantsAdviceDetailService : IAccountantsAdviceDetailService
    {
        private IAccountantsAdviceDetailDAL accountantsAdviceDetaileDAL;

        public AccountantsAdviceDetailService()
        {
            this.accountantsAdviceDetaileDAL = new AccountantsAdviceDetailDAL();
        }


        public DataTable SearchByAccountantsAdviceID(int Id)
        {
            return this.accountantsAdviceDetaileDAL.SearchByAccountantsAdviceID(Id);
        }


        public DataTable SearchByCheckID(int Id)
        {
            return this.accountantsAdviceDetaileDAL.SearchByCheckID(Id);
        }
    }
}
