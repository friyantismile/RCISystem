using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCISystem.Reports;
using RCISystem.BLL;

namespace RCISystem.Views
{
    public partial class frmPrintAccountantsAdvice : Form
    {
        private decimal AccountantsAdviceID;
        public frmPrintAccountantsAdvice(decimal AccountantsAdviceID)
        {
            InitializeComponent();
            this.AccountantsAdviceID = AccountantsAdviceID;
        }

        private void frmPrintAccountantsAdvice_Load(object sender, EventArgs e)
        {
            crAccountantsAdvice newcrAccountantsAdvice = new crAccountantsAdvice();
            AccountantsAdviceService newAccountantsAdviceService = new AccountantsAdviceService();
            AccountantsAdviceDetailService newAccountantsAdviceDetailService = new AccountantsAdviceDetailService();
            BankAccountService newBankAccountService = new BankAccountService();
            BankService newBankService = new BankService();
            SignatoryService newSignatoryService = new SignatoryService();
            newcrAccountantsAdvice.Load();
            newcrAccountantsAdvice.Database.Tables[0].SetDataSource(newAccountantsAdviceService.SearchByAccountantsAdviceID(AccountantsAdviceID));
            newcrAccountantsAdvice.Database.Tables[1].SetDataSource(newAccountantsAdviceDetailService.SearchByAccountantsAdviceID(AccountantsAdviceID));
            newcrAccountantsAdvice.Database.Tables[2].SetDataSource(newBankAccountService.GetAllBankAccount());
            newcrAccountantsAdvice.Database.Tables[3].SetDataSource(newBankService.GetAllBank());
            newcrAccountantsAdvice.Database.Tables[4].SetDataSource(newSignatoryService.GetAllSignatory());
            crystalReportViewer1.ReportSource = newcrAccountantsAdvice;
        }
    }
}
