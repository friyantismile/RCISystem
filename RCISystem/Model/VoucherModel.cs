using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class VoucherModel
    {
        public int VoucherID { get; set; }
        public string VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public string VoucherPayee { get; set; }
        public float VoucherAmount{ get; set; }
    }
}
