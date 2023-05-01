using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class CheckIssuedModel
    {
        public decimal CheckIssuedID { get; set; }
        public decimal CheckID { get; set; }
        public decimal VoucherID { get; set; }
        //public IList<CheckModel> checkModel { get; set; }
        //public IList<VoucherModel> voucherModel { get; set; }
        public DateTime DateEncoded { get; set; }
        public int EncodedBy { get; set; }
        public Nullable<DateTime> DateVerified { get; set; }
        public int VerifiedBy { get; set; }
        public int IsVerified { get; set; }
        public int IsCheckPrinted { get; set; }
        public int CheckPrintedBy { get; set; }
        public Nullable<DateTime> DateCheckPrinted { get; set; }
        public int IsCheckCanceled { get; set; }
        public int CheckCanceledBy { get; set; }
        public Nullable<DateTime> DateCheckCanceled { get; set; }
        public decimal AccountantsAdviceID { get; set; }
    }
}
