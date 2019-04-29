using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class AccountantsAdviceDetailModel
    {
        public int AccountantsAdviceID { get; set; }
        public int AccountantsAdviceDetailID { get; set; }
        public int CheckIssuedID { get; set; }
        public int CheckID { get; set; }
        public int VoucherID { get; set; }
        public string VoucherNo { get; set; }
        public float VoucherAmount { get; set; }
        public string CheckNo { get; set; }
        public DateTime CheckDate { get; set; }
        public string CheckPayee { get; set; }
        public float CheckAmount { get; set; }
        public int BankAccountID { get; set; }
    }
}
