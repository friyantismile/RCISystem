using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class CheckModel
    {
        public int CheckID { get; set; }
        public int BankAccountID { get; set; }
        public string CheckNo { get; set; }
        public DateTime CheckDate { get; set; }
        public float CheckAmount { get; set; }
        public string CheckPayee { get; set; }
    }
}
