using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCISystem.BLL;
using RCISystem.View;
using RCISystem.Model;
using RCISystem.Views;
using RCISystem.Reports;
using RCISystem.Helper;

namespace RCISystem
{
    public partial class frmCheckIssued : Form
    {
        private int CurrentUserID;
        private Validation validation = new Validation();

        public frmCheckIssued(int CurrentUserID)
        {
            InitializeComponent();
            this.CurrentUserID = CurrentUserID;
        }

        private void frmCheckIssued_Load(object sender, EventArgs e)
        {
            GetAllBank();
            //this.ActiveControl = cboBank;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            btnNewCheckIssuance.Enabled = true;
            btnSaveCheck.Enabled = false;
            btnPrintCheck.Enabled = false;
        }



        public void GetAllBank()
        {
            BankService newBankService = new BankService();
            DataTable dt = new DataTable();

            dt = newBankService.GetAllBank();
            cboBank.DisplayMember = "BankName";
            cboBank.ValueMember = "BankID";
            cboBank.DataSource = dt;
           // cboBank.SelectedIndex = -1;
        }


        public void GetAllCheckPayee()
        {
            CheckService newCheckService = new CheckService();
            DataTable dt = new DataTable();

            dt = newCheckService.GetAllCheckPayee();
            cboPayee.DisplayMember = "CheckPayee";
            cboPayee.ValueMember = "CheckPayee";
            cboPayee.DataSource = dt;
            cboPayee.SelectedIndex = -1;
        }


        private void cboBank_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboBank.SelectedIndex >= 0)
            {
                GetAllBankAccountByBankID(int.Parse(cboBank.SelectedValue.ToString()));
                txtCheckNo.Clear();
            }
        }

        public void GetAllBankAccountByBankID(int BankID)
        {
            cboBankAccountNo.DataSource = null;
            cboBankAccountCode.DataSource = null;
           // cboBankAccountNo.DisplayMember = "BankAccountNo";
           // cboBankAccountNo.ValueMember = "BankAccountID";

            BankAccountService newBankAccountService = new BankAccountService();
            DataTable dt = new DataTable();

            dt = newBankAccountService.SearchBankAccountByBankID(BankID);
            cboBankAccountNo.DataSource = null;
            cboBankAccountNo.DisplayMember = "BankAccountNo";
            cboBankAccountNo.ValueMember = "BankAccountID";
            cboBankAccountNo.DataSource = dt;
           // cboBankAccountNo.SelectedIndex = -1;


            cboBankAccountCode.DataSource = null;
            cboBankAccountCode.DisplayMember = "BankAccountCode";
            cboBankAccountCode.ValueMember = "Remarks";
            cboBankAccountCode.DataSource = dt;
            //cboBankAccountCode.SelectedIndex = -1;

        }



        public void SaveCheck()
        {
            try
            {
                //Check Table
                CheckModel checkModel = new CheckModel()// Assign the values to the model
                {
                    BankAccountID = int.Parse(cboBankAccountNo.SelectedValue.ToString()),
                    CheckAmount = decimal.Parse(txtCheckAmount.Text),
                    CheckDate = dtpCheckDate.Value,
                    CheckNo = txtCheckNo.Text,
                    CheckPayee = txtCheckPayee.Text
                };

                CheckService newCheckService = new CheckService();
                decimal New_CheckID = newCheckService.AddCheck(checkModel);

                if (New_CheckID > 0)
                {
                    MessageBox.Show("SUCCESS = " + New_CheckID);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror" + ex.Message);
            }

        }

        private void btnSaveCheck_Click(object sender, EventArgs e)
        {

            if (cboBank.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Bank!");
                return;
            }
            if (cboBankAccountNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Bank account!");
                return;
            }
            //if (cboPayee.Text =="")
            //{
            //    MessageBox.Show("Please input Check Payee!");
            //    return;
            //}
            bool isCheckNoNotEmpty = validation.checkTextboxIfEmpty(txtCheckNo);
            bool isCheckPayeeNotEmpty = validation.checkTextboxIfEmpty(txtCheckPayee);
            bool isCheckAmountNotEmpty = validation.checkTextboxIfEmpty(txtCheckAmount);

            // isCheckPayeeNotEmpty &&
            if (isCheckNoNotEmpty &&
                isCheckAmountNotEmpty)
            {
                SaveTransaction();
            }
        }
        public void SaveTransaction()
        {
            try
            {
                //Check Table
                CheckModel checkModel = new CheckModel()// Assign the values to the model
                {
                    BankAccountID = int.Parse(cboBankAccountNo.SelectedValue.ToString()),
                    CheckAmount = decimal.Parse(txtCheckAmount.Text),
                    CheckDate = dtpCheckDate.Value,
                    CheckNo = txtCheckNo.Text,
                    CheckPayee = txtCheckPayee.Text,
                    //CheckPayee= cboPayee.Text,
                    CheckRemarks=txtCheckRemarks.Text 
                };


                List<VoucherModel> voucherModel = new List<VoucherModel>();

                foreach (DataGridViewRow row in dgVouchers.Rows)
                {
                    voucherModel.Add(new VoucherModel
                    {
                        VoucherNo = row.Cells[0].Value.ToString(),
                        VoucherDate = DateTime.Parse(row.Cells[1].Value.ToString()),
                        VoucherAmount = decimal.Parse(row.Cells[2].Value.ToString())

                    });

                }



                CheckIssuedService newCheckIssuedService = new CheckIssuedService();
                decimal newCheckID = newCheckIssuedService.AddCheckIssuedTransaction(checkModel, voucherModel, CurrentUserID);

                if (newCheckID > 0)
                {
                    if (Application.OpenForms["frmCheckIssuedList"] != null)
                    {
                        SearchField reassignValueofSearchField = new SearchField()
                        {
                            VerificationStatus = "1"
                        };
                        (Application.OpenForms["frmCheckIssuedList"] as frmCheckIssuedList).FillCheckIssueData(reassignValueofSearchField);
                    }
                    txtCheckID.Text = newCheckID.ToString();
                    btnPrintCheck.Enabled = true;
                    btnSaveCheck.Enabled = false;
                    btnNewCheckIssuance.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;

                    MessageBox.Show("SUCCESS = " + newCheckID);
                   // btnSaveCheck.Text = "NEW CHECK ISSUEANCE";
                }
                else
                {
                    btnPrintCheck.Enabled = false;
                    MessageBox.Show("FAILED");
                }
            }
            catch (Exception ex)
            {
                btnPrintCheck.Enabled = false;
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            frmVoucherAdd newfrmVoucherAdd = new frmVoucherAdd(dgVouchers, txtCheckAmount);
            newfrmVoucherAdd.ShowDialog();
        }

        private void btnRemoveVoucher_Click(object sender, EventArgs e)
        {
            if (this.dgVouchers.SelectedRows.Count > 0)
            {
                dgVouchers.Rows.RemoveAt(dgVouchers.SelectedRows[0].Index);
                Get_Total_Amount();
                btnRemoveVoucher.Enabled = false;
            }
        }

        private void btnPrintCheck_Click(object sender, EventArgs e)
        {
            string message = "Do you want to print with CHECK NUMBER?";  
            string title = "Close Window";  
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;  
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);  
            if (result == DialogResult.Cancel ) {  
                //this.Close();  

            }
            else if (result == DialogResult.Yes)
            {
                frmPrintCheck newfrmPrintCheck = new frmPrintCheck(int.Parse(txtCheckID.Text), cboBankAccountCode.Text,txtCheckRemarks.Text,cboBankAccountCode.SelectedValue.ToString() );
                newfrmPrintCheck.ShowDialog(); 
            }
            else
            {
                frmPrintCheckNoCheckNo newfrmPrintCheckNoCheckNo = new frmPrintCheckNoCheckNo(int.Parse(txtCheckID.Text), cboBankAccountCode.Text, txtCheckRemarks.Text, cboBankAccountCode.SelectedValue.ToString());
                newfrmPrintCheckNoCheckNo.ShowDialog(); 
                // Do something  
            }  
            //frmPrintCheck newfrmPrintCheck = new frmPrintCheck(int.Parse(txtCheckID.Text));
            //newfrmPrintCheck.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgVouchers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgVouchers_Click(object sender, EventArgs e)
        {
            if (this.dgVouchers.Rows.Count > 0)
            {
                btnRemoveVoucher.Enabled = true;
            }
        }

        public void Get_Total_Amount()
        {
            decimal temp_TotalAmount = 0;
            for (int i = 0; i < dgVouchers.Rows.Count; i++)
            {
                temp_TotalAmount = temp_TotalAmount + decimal.Parse(dgVouchers.Rows[i].Cells[2].Value.ToString());
            }
            txtCheckAmount.Text = string.Format("{0:#,###.00}", temp_TotalAmount);
        }

        private void txtCheckNo_TextChanged(object sender, EventArgs e)
        {
            //validation.isNumber(txtCheckNo);
        }

        private void txtCheckPayee_TextChanged(object sender, EventArgs e)
        {
            //validation.isLetter(txtCheckPayee);
        }

        private void cboBankAccountNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBankAccountCode.SelectedIndex >= 0)
            {
                cboBankAccountCode.SelectedIndex = cboBankAccountNo.SelectedIndex;
            }

        }

        private void cboBankAccountNo_Click(object sender, EventArgs e)
        {

        }

        private void cboBankAccountNo_Leave(object sender, EventArgs e)
        {

        }

        private void cboBankAccountCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBankAccountCode.Text = "";
            if (cboBankAccountNo.DataSource !=null)
            {
                txtBankAccountCode.Text = cboBankAccountCode.SelectedValue.ToString();
            }
            else { txtBankAccountCode.Text = ""; }
        }

        private void btnNewCheckIssuance_Click(object sender, EventArgs e)
        {
            dgVouchers.Rows.Clear();
            dgVouchers.Refresh();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            btnNewCheckIssuance.Enabled = false;
            btnPrintCheck.Enabled = false;
            btnSaveCheck.Enabled = true;
            GetAllCheckPayee();
            decimal tmpCheckNo;
            if (txtCheckNo.Text != "")
            {
                if (decimal.Parse(txtCheckNo.Text) > 0)
                {
                    tmpCheckNo = decimal.Parse(txtCheckNo.Text) + 1;
                    txtCheckNo.Text = tmpCheckNo.ToString();
                }
            }
            txtCheckAmount.Text = "";
        }

        private void cboPayee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

