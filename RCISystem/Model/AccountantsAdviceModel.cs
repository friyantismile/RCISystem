using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCISystem.Model
{
    public class AccountantsAdviceModel
    {
        public int AccountantsAdviceID { get; set; }
        public DateTime AdviceDate { get; set; }
        public int GeneratedByID { get; set; }
        public DateTime GeneratedDate { get; set; }
        public int CertifiedByID { get; set; }
    }
}
