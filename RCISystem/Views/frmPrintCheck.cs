﻿using System;
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
        private string newBankAccountCode;
        private string newCheckRemarks;
        private string newBankAccountRemarks;
        public frmPrintCheck(int newCheckID, string newBankAccountCode, string newCheckRemarks, string newBankAccountRemarks)
        {
            InitializeComponent();
            this.newCheckID = newCheckID;
            this.newBankAccountCode = newBankAccountCode;
            this.newCheckRemarks = newCheckRemarks;
            this.newBankAccountRemarks = newBankAccountRemarks;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void demPrintCheck_Load(object sender, EventArgs e)
        {
            string sVoucherNo = "";
            
            DataTable dt = new DataTable();

            crCheck newcrCheck = new crCheck();
            CheckService newCheckService = new CheckService();
            VoucherService newVoucherService = new VoucherService();
            BankAccountService newBankAccountService = new BankAccountService();
            dt = newVoucherService.SearchVoucherByCheckID(newCheckID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                sVoucherNo = sVoucherNo + dr["VoucherNo"].ToString() + ";";
            }

            sVoucherNo=this.newBankAccountCode + " " + sVoucherNo + "     " + this.newBankAccountRemarks;
            newcrCheck.Load();
            newcrCheck.Database.Tables[0].SetDataSource(newCheckService.SearchCheckByCheckID(newCheckID));
            newcrCheck.Database.Tables[1].SetDataSource(newBankAccountService.GetAllBankAccount());
            newcrCheck.SetParameterValue("VoucherNo", sVoucherNo);
            newcrCheck.SetParameterValue("Remarks", this.newCheckRemarks);
            crystalReportViewer1.ReportSource = newcrCheck;
        }
    }
}
