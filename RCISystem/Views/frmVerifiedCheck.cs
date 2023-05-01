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
using RCISystem.Model;
using RCISystem.Helper;

namespace RCISystem.Views
{
    public partial class frmVerifiedCheck : Form
    {
        private int CurrentUserID;
        Validation validation = new Validation();

        public frmVerifiedCheck(int CurrentUserID)
        {
            InitializeComponent();
            this.CurrentUserID = CurrentUserID;
        }

        private void frmVerifiedCheck_Load(object sender, EventArgs e)
        {
            Fill_cboView();
            GetAllSignatory();
        }

        public void Fill_cboView()
        {
            cboView.Items.Clear();
            cboView.Items.Add("Checks with out Advise");
            cboView.Items.Add("Checks with Advise");
            cboView.SelectedIndex = 0;
        }
        
        public void FillCheckIssueData(SearchField searchField)
        {
            CheckIssuedService newCheckIssuedService = new CheckIssuedService();
            DataTable dt = new DataTable();
            dt = newCheckIssuedService.GetAllCheckIssued(searchField);
            dgvCheckIssuedList.Rows.Clear();
            string Check_ID = "";
            int CurrentRow = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (searchField.IsAdviced && (int.Parse(dr["AccountantsAdviceID"].ToString()) > 0) && (dr["CheckID"].ToString() != Check_ID))
                {

                    dgvCheckIssuedList.Rows.Add(false,
                        dr["CheckIssuedID"].ToString(),
                        "WITH ADVICED",
                        dr["AccountantsAdviceID"].ToString(),
                        dr["DateVerified"].ToString(),
                        dr["BankCode"].ToString(),
                        dr["BankAccountNo"].ToString(),
                        dr["BankAccountDescription"].ToString(),
                        dr["CheckID"].ToString(),
                        dr["CheckNo"].ToString(),
                        string.Format("{0:M/d/yyyy}", dr["CheckDate"]),
                        dr["CheckPayee"].ToString(),
                        string.Format("{0:#,###.00}", dr["CheckAmount"]),
                        dr["VoucherNo"].ToString(),
                        string.Format("{0:M/d/yyyy}", dr["VoucherDate"]),
                        dr["VoucherAmount"].ToString(),
                        dr["EncodedByFullname"].ToString(),
                        dr["DateEncoded"].ToString(),
                        dr["VerifiedByFullname"].ToString(),
                        dr["BankAccountID"].ToString(),
                        dr["VoucherID"].ToString()
                        );
                    dgvCheckIssuedList.Rows[CurrentRow].DefaultCellStyle.BackColor = Color.Honeydew;
                    dgvCheckIssuedList.Rows[CurrentRow].Cells[0].Style.BackColor = Color.SeaGreen;
                    CurrentRow = CurrentRow + 1;
                }
                else if (!searchField.IsAdviced && (int.Parse(dr["AccountantsAdviceID"].ToString()) <= 0) && (dr["CheckID"].ToString() != Check_ID))
                {
                    dgvCheckIssuedList.Rows.Add(false,
                       dr["CheckIssuedID"].ToString(),
                       "NO ADVICED",
                       dr["AccountantsAdviceID"].ToString(),
                       dr["DateVerified"].ToString(),
                       dr["BankCode"].ToString(),
                       dr["BankAccountNo"].ToString(),
                       dr["BankAccountDescription"].ToString(),
                       dr["CheckID"].ToString(),
                       dr["CheckNo"].ToString(),
                       string.Format("{0:M/d/yyyy}", dr["CheckDate"]),
                       dr["CheckPayee"].ToString(),
                       string.Format("{0:#,###.00}", dr["CheckAmount"]),
                       dr["VoucherNo"].ToString(),
                       string.Format("{0:M/d/yyyy}", dr["VoucherDate"]),
                       dr["VoucherAmount"].ToString(),
                       dr["EncodedByFullname"].ToString(),
                       dr["DateEncoded"].ToString(),
                       dr["VerifiedByFullname"].ToString(),
                       dr["BankAccountID"].ToString(),
                       dr["VoucherID"].ToString()
                       );
                    dgvCheckIssuedList.Rows[CurrentRow].DefaultCellStyle.BackColor = Color.Pink;
                    dgvCheckIssuedList.Rows[CurrentRow].Cells[0].Style.BackColor = Color.Crimson;

                    CurrentRow = CurrentRow + 1;
                }
                Check_ID = dr["CheckID"].ToString();
            }
        }

        public void GetAllSignatory()
        {
            SignatoryService newSignatoryService = new SignatoryService();
            DataTable dt = new DataTable();
            dt = newSignatoryService.GetAllSignatory();
            cboSignatory.DisplayMember = "Fullname";
            cboSignatory.ValueMember = "SignatoryID";
            cboSignatory.DataSource = dt;
            cboSignatory.SelectedIndex = -1;
        }


        public void SaveAdvice()
        {
            try
            {
                AccountantsAdviceModel newAccountantsAdviceModel = new AccountantsAdviceModel()
                {
                    AdviceDate = DateTime.Now,
                    CertifiedByID = int.Parse(cboSignatory.SelectedValue.ToString()),
                    GeneratedByID = CurrentUserID,
                    GeneratedDate = DateTime.Now,

                };

                List<AccountantsAdviceDetailModel> accountantsAdviceDetailModel = new List<AccountantsAdviceDetailModel>();

                foreach (DataGridViewRow row in dgvCheckIssuedList.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    //chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                    if ((bool)chk.Value == true)
                    {

                        accountantsAdviceDetailModel.Add(new AccountantsAdviceDetailModel
                        {
                            CheckIssuedID = decimal.Parse(row.Cells[1].Value.ToString()),
                            CheckID = decimal.Parse(row.Cells[8].Value.ToString()),
                            VoucherNo = row.Cells[13].Value.ToString(),
                            VoucherAmount = decimal.Parse(row.Cells[15].Value.ToString()),
                            CheckNo = row.Cells[9].Value.ToString(),
                            CheckDate = DateTime.Parse(row.Cells[10].Value.ToString()),
                            CheckPayee = row.Cells[11].Value.ToString(),
                            CheckAmount = decimal.Parse(row.Cells[12].Value.ToString()),
                            BankAccountID = int.Parse(row.Cells[19].Value.ToString()),
                            VoucherID = decimal.Parse(row.Cells[20].Value.ToString())
                        });

                    }


                }

                if (accountantsAdviceDetailModel.Count == 0)
                {
                    MessageBox.Show("No Item Selected");
                    return;
                }
                AccountantsAdviceService newAccountantsAdviceService = new AccountantsAdviceService();
                decimal New_AccountantsAdviceID = newAccountantsAdviceService.AddAccountantsAdviceTransaction(newAccountantsAdviceModel, accountantsAdviceDetailModel); ;

                if (New_AccountantsAdviceID > 0)
                {
                    MessageBox.Show("SUCCESS = " + New_AccountantsAdviceID);
                    frmPrintAccountantsAdvice newfrmPrintAccountantsAdvice = new frmPrintAccountantsAdvice(New_AccountantsAdviceID);
                    newfrmPrintAccountantsAdvice.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

 
     

        private void txtCheckNumber_TextChanged(object sender, EventArgs e)
        {
            validation.isNumber(txtCheckNumber);
        }

        private void btnPrintAdvice_Click(object sender, EventArgs e)
        {
            int New_AccountantsAdviceID = int.Parse(dgvCheckIssuedList.CurrentRow.Cells[3].Value.ToString());
            frmPrintAccountantsAdvice newfrmPrintAccountantsAdvice = new frmPrintAccountantsAdvice(New_AccountantsAdviceID);
            newfrmPrintAccountantsAdvice.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string getValueOfVerficationStatus = "0";
            if (cboView.SelectedIndex == 0)
            {
                getValueOfVerficationStatus = "1";
            }
            SearchField reassignValueofSearchField = new SearchField()// Assign the values to the model
            {
                VerificationStatus = getValueOfVerficationStatus,
                CheckNumber = txtCheckNumber.Text,
                VoucherNumber = txtVoucherNumber.Text
            };
            FillCheckIssueData(reassignValueofSearchField);
        }

        private void txtVoucherNumber_TextChanged(object sender, EventArgs e)
        {
            validation.isNumber(txtVoucherNumber);
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool advicedStatus = true;
            btnGenerateAdvised.Enabled = false;
            btnPrintAdvice.Enabled = true;

            if (cboView.SelectedIndex == 0)
            {
                btnGenerateAdvised.Enabled = true;
                btnPrintAdvice.Enabled = false;
                advicedStatus = false;
            }
            SearchField reassignValueofSearchField = new SearchField()// Assign the values to the model
            {
                VerificationStatus = "1",
                CheckNumber = txtCheckNumber.Text,
                VoucherNumber = txtVoucherNumber.Text,
                IsAdviced = advicedStatus
            };
            FillCheckIssueData(reassignValueofSearchField);
        }

        private void dgvCheckIssuedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheckIssuedList.CurrentCell.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)dgvCheckIssuedList.Rows[dgvCheckIssuedList.CurrentRow.Index].Cells[0];

                if (ch1.Value == null)
                    ch1.Value = false;
                switch (ch1.Value.ToString())
                {
                    case "True":
                        ch1.Value = false;
                        //dgvCheckIssuedList.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                        break;
                    case "False":
                        ch1.Value = true;
                        // dgvCheckIssuedList.SelectedRows[0].DefaultCellStyle.BackColor = Color.Pink;
                        break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerateAdvised_Click(object sender, EventArgs e)
        {
            if (cboSignatory.Text == "")
            {
                MessageBox.Show("Please Select City Account for Signatory");
                return;
            }
            SaveAdvice();
        }
    }
}
