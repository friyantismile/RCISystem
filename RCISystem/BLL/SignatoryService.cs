using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCISystem.DAL;
using System.Data;

namespace RCISystem.BLL
{
    public class SignatoryService : ISignatoryService
    {
        private ISignatoryDAL signatoryDAL;

        public SignatoryService()
        {
            this.signatoryDAL = new SignatoryDAL();
        }
        public DataTable GetAllSignatory()
        {
            return this.signatoryDAL.GetAllSignatory();
        }

    }
}
