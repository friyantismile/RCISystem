using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class BankAccountModel
    {
        public int BankAccountID { get; set; }
        public int BankID { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountDescription { get; set; }
    }
}
