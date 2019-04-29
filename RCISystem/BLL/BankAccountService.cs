using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCISystem.DAL;
using System.Data;

namespace RCISystem.BLL
{
    public class BankAccountService : IBankAccountService
    {
        private IBankAccountDAL bankAccountDAL;

        public BankAccountService()
        {
            this.bankAccountDAL = new BankAccountDAL();
        }
        public DataTable GetAllBankAccount()
        {
            return this.bankAccountDAL.GetAllBankAccount ();
        }

        public DataTable SearchBankAccountByBankID(int BankID)
        {
            return this.bankAccountDAL.SearchBankAccountByBankID(BankID);
        }


        public DataTable SearchBankAccountByBankAccountID(int BankAccountID)
        {
           return this.bankAccountDAL.SearchBankAccountByBankAccountID(BankAccountID);
        }
    }
}
