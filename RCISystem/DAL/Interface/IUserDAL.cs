using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RCISystem.Model;
namespace RCISystem.DAL
{
    public interface IUserDAL
    {
        //DataTable GetAllCheck();
        //int  AddCheck(CheckModel checkModel);
        //bool UpdateBank(BankModel bankModel);
        //bool DeleteBank(int Id);
        //DataRow GetBankById(int Id);
        DataTable SearchUserByUserNamePassword(UserModel userModel);
    }
}
