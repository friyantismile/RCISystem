using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RCISystem.BLL
{
    public interface IBankService
    {
        DataTable GetAllBank();
        //bool AddBank(BankModel bankModel);
        //bool UpdateBank(BankModel bankModel);
        //bool DeleteBank(int Id);
        //DataRow GetBankById(int Id);
        DataTable SearchBankByID(int ID);
    }
}
