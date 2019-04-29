using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RCISystem.Model;
namespace RCISystem.DAL
{
    public interface IBankAccountDAL
    {
        DataTable GetAllBankAccount();
        //bool AddBank(BankModel bankModel);
        //bool UpdateBank(BankModel bankModel);
        //bool DeleteBank(int Id);
        //DataRow GetBankById(int Id);
        DataTable SearchBankAccountByBankID(int BankID);
        DataTable SearchBankAccountByBankAccountID(int BankAccountID);
    }
}
