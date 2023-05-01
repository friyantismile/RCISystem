using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class AccountantsAdviceDetailModel
    {
        public decimal AccountantsAdviceID { get; set; }
        public decimal AccountantsAdviceDetailID { get; set; }
        public decimal CheckIssuedID { get; set; }
        public decimal CheckID { get; set; }
        public decimal VoucherID { get; set; }
        public string VoucherNo { get; set; }
        public decimal VoucherAmount { get; set; }
        public string CheckNo { get; set; }
        public DateTime CheckDate { get; set; }
        public string CheckPayee { get; set; }
        public decimal CheckAmount { get; set; }
        public int BankAccountID { get; set; }
    }
}
