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
    public class UserService : IUserService
    {
        private IUserDAL userDAL;

        public UserService()
        {
            this.userDAL = new UserDAL();
        }


        public DataTable SearchUserByUsernamePassword(UserModel userModel)
        {
            return this.userDAL.SearchUserByUserNamePassword(userModel);
        }
    }
}
