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
    public class CheckIssuedService : ICheckIssuedService
    {
        private ICheckIssuedDAL checkIssuedDAL;

        public CheckIssuedService()
        {
            this.checkIssuedDAL = new CheckIssuedDAL();
        }


        public bool AddCheckIssued(CheckIssuedModel checkIssuedModel)
        {
            return this.checkIssuedDAL.AddCheckIssued(checkIssuedModel);
        }

        public DataTable GetAllCheckIssued(SearchField searchField)
        {
            return this.checkIssuedDAL.GetAllCheckIssued(searchField);
        }


        public int AddCheckIssuedTransaction(CheckModel checkModel, List<VoucherModel> voucherModel, int UserID)
        {
            return this.checkIssuedDAL.AddCheckIssuedTransaction(checkModel, voucherModel,UserID);
        }


        public int UpdateVerification(CheckIssuedModel checkIssuedModel)
        {
            return this.checkIssuedDAL.UpdateVerification(checkIssuedModel);
        }


        public int UpdateIsPrinted(CheckIssuedModel checkIssuedModel)
        {
            return this.checkIssuedDAL.UpdateIsPrinted(checkIssuedModel);
        }

        public int UpdateIsCheckCanceled(CheckIssuedModel checkIssuedModel)
        {
            return this.checkIssuedDAL.UpdateIsCheckCanceled(checkIssuedModel);
        }
    }
}
