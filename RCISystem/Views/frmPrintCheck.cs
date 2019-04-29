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
    public partial class frmPrintCheck : Form
    {
        private int newCheckID;
        public frmPrintCheck(int newCheckID)
        {
            InitializeComponent();
            this.newCheckID = newCheckID;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void demPrintCheck_Load(object sender, EventArgs e)
        {

            crCheck newcrCheck = new crCheck();
            CheckService newCheckService = new CheckService();
            BankAccountService newBankAccountService = new BankAccountService();
            newcrCheck.Load();
            newcrCheck.Database.Tables[0].SetDataSource(newCheckService.SearchCheckByCheckID(newCheckID));
            newcrCheck.Database.Tables[1].SetDataSource(newBankAccountService.GetAllBankAccount());
            crystalReportViewer1.ReportSource = newcrCheck;
        }
    }
}
