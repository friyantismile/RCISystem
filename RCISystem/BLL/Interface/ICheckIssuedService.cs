using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RCISystem.Model;

namespace RCISystem.BLL
{
    public interface ICheckIssuedService
    {
        DataTable GetAllCheckIssued(SearchField searchField);
        bool AddCheckIssued(CheckIssuedModel checkIssuedModel);
       // int AddCheckIssuedTransaction(CheckModel checkModel, string[,] voucherInfo);
        int AddCheckIssuedTransaction(CheckModel checkModel, List<VoucherModel> voucherModel,int UserID);
        //bool UpdateBank(BankModel bankModel);
        //bool DeleteBank(int Id);
        //DataRow GetBankById(int Id);
        //DataTable SearchBankByID(int ID);
        int UpdateVerification(CheckIssuedModel checkIssuedModel);
        int UpdateIsPrinted(CheckIssuedModel checkIssuedModel);
        int UpdateIsCheckCanceled(CheckIssuedModel checkIssuedModel);
    }
}
