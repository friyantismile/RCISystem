using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RCISystem.Model;

namespace RCISystem.BLL
{
    public interface IAccountantsAdviceDetailService
    {
        //DataTable GetAllBank();
        DataTable SearchByAccountantsAdviceID(decimal Id);
        DataTable SearchByCheckID(decimal Id);
        //bool UpdateBank(BankModel bankModel);
        //bool DeleteBank(int Id);
        //DataRow GetBankById(int Id);
        //DataTable SearchBankByID(int ID);
    }
}
