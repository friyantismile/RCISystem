using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCISystem.DAL;
using System.Data;

namespace RCISystem.BLL
{
    public class BankService : IBankService
    {
        private IBankDAL bankDAL;

        public BankService()
        {
            this.bankDAL = new BankDAL();
        }
        public DataTable GetAllBank()
        {
            return this.bankDAL.GetAllBank();
        }

        public DataTable SearchBankByID(int ID)
        {
            return this.bankDAL.SearchBankByID(ID);
        }
    }
}
