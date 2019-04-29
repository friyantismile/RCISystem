using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class SearchField
    {
        public string VerificationStatus { get; set; } = null;
        public string CheckNumber { get; set; } = null;
        public string VoucherNumber { get; set; } = null;
        public bool IsAdviced { get; set; } = false;
    }
}
