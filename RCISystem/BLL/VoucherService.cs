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
    public class VoucherService : IVoucherService
    {
        private IVoucherDAL voucherDAL;

        public VoucherService()
        {
            this.voucherDAL = new VoucherDAL();
        }



        public bool AddVoucher(VoucherModel voucherModel)
        {
            return this.voucherDAL.AddVoucher(voucherModel);
        }


        public DataTable SearchVoucherByCheckID(decimal CheckId)
        {
            return this.voucherDAL.SearchVoucherByCheckID(CheckId);
        }
    }
}
