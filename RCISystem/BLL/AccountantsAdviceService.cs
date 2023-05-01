using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCISystem.DAL;
using System.Data;

namespace RCISystem.BLL
{
    public class AccountantsAdviceService : IAccountantsAdviceService
    {
        private IAccountantsAdviceDAL accountantsAdviceDAL;

        public AccountantsAdviceService()
        {
            this.accountantsAdviceDAL = new AccountantsAdviceDAL();
        }


        public DataTable SearchByAccountantsAdviceID(decimal Id)
        {
            return this.accountantsAdviceDAL.SearchByAccountantsAdviceID(Id);
        }


        public decimal AddAccountantsAdviceTransaction(Model.AccountantsAdviceModel accountantsAdviceModel, List<Model.AccountantsAdviceDetailModel> accountantsAdviceDetailModel)
        {
            return this.accountantsAdviceDAL.AddAccountantsAdviceTransaction(accountantsAdviceModel,accountantsAdviceDetailModel);
        }
    }
}
