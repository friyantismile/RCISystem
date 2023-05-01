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
    public partial class frmCheckIssuedList : Form
    {
        private int CurrentUserID;
        private int CurrentOfficeID;
        SearchField searchField = new SearchField();
        Validation validation = new Validation();

        public frmCheckIssuedList(int CurrentUserID, int CurrentOfficeID)
        {
            InitializeComponent();
            this.CurrentOfficeID = CurrentOfficeID;
            this.CurrentUserID = CurrentUserID;
        }

        private void frmCheckIssuedList_Load(object sender, EventArgs e)
        {
            FillCboStatusVerification();
            // Fill_Verified_Data();
            Authorized(CurrentOfficeID);
        }

        private void btnGenerateAdvise_Click(object sender, EventArgs e)
        {
            frmVerifiedCheck newfrmVerifiedCheck = new frmVerifiedCheck(CurrentUserID);
            newfrmVerifiedCheck.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNewCheckIssued_Click(object sender, EventArgs e)
        {
            frmCheckIssued newfrmCheckIssued = new frmCheckIssued(this.CurrentUserID);
            newfrmCheckIssued.ShowDialog();
        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            decimal CheckID = int.Parse(dgvCheckIssuedList.SelectedRows[0].Cells[6].Value.ToString());
            UpdateVerification(CheckID, this.CurrentUserID, DateTime.Now, 1);
        }

        private void btnUnverified_Click(object sender, EventArgs e)
        {
            decimal AccountantsAdviceID = int.Parse(dgvCheckIssuedList.SelectedRows[0].Cells[17].Value.ToString());
            if (AccountantsAdviceID > 0)
            {
                string message = "Check Already Issued An Advice!";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            }
            else
            {
                decimal CheckID = int.Parse(dgvCheckIssuedList.SelectedRows[0].Cells[6].Value.ToString());
                UpdateVerification(CheckID, this.CurrentUserID, DateTime.Now, 0);
            }
        }

        private void dgvCheckIssuedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string VerifiedStatus = dgvCheckIssuedList.SelectedRows[0].Cells[1].Value.ToString();

            if (VerifiedStatus == "UNVERIFIED")
            {
                btnVerified.Enabled = true;
                btnUnverified.Enabled = false;
            }
            else if (VerifiedStatus == "VERIFIED")
            {
                btnVerified.Enabled = false;
                btnUnverified.Enabled = true;
            }
            else
            {
                btnVerified.Enabled = false;
                btnUnverified.Enabled = false;
            }

        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCheckIssueData(getSearchValue());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            FillCheckIssueData(getSearchValue());
        }

        public void FillCboStatusVerification()
        {
            cboView.Items.Clear();
            cboView.Items.Add("VERIFIED");
            cboView.Items.Add("UNVERIFIED");
            cboView.SelectedIndex = 1;
        }

        public void UpdateVerification(decimal CheckID, int UserID, Nullable<DateTime> DateVerified, int IsVerified)
        {
            try
            {
                //Check Table
                CheckIssuedModel newCheckIssuedModel = new CheckIssuedModel()// Assign the values to the model
                {
                    CheckID = CheckID,
                    VerifiedBy = UserID,
                    DateVerified = DateVerified,
                    IsVerified = IsVerified
                };

                CheckIssuedService newCheckIssuedService = new CheckIssuedService();
                int Rows_Affected = newCheckIssuedService.UpdateVerification(newCheckIssuedModel);

                if (Rows_Affected > 0)
                {
                    //Fill_Verified_Data();
                    FillCheckIssueData(getSearchValue());
                    btnVerified.Enabled = false;
                    MessageBox.Show("Verified");
                }
                else
                {
                    //btnVerified.Enabled = false;
                    MessageBox.Show("FAILed");
                }

            }
            catch (Exception ex)
            {
                btnVerified.Enabled = false;
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        public void Authorized(int OfficeID)
        {
            if (OfficeID == 1)  //City treasurer
            {

                pnlCTO.Show();
                pnlCAccO.Hide();
            }
            else if (OfficeID == 2)  //City Accountant
            {
                pnlCTO.Hide();
                pnlCAccO.Show();
            }
        }

        public void FillCheckIssueData(SearchField searchField)
        {
            CheckIssuedService newCheckIssuedService = new CheckIssuedService();
            DataTable dt = new DataTable();
            dt = newCheckIssuedService.GetAllCheckIssued(searchField);
            dgvCheckIssuedList.Rows.Clear();
            string Check_ID = "";
            int CurrentRow = 0;
            string verificationStatus = "VERIFIED";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                if ((dr["IsVerified"].ToString() != "1"))
                {
                    verificationStatus = "UNVERIFIED";
                }

                if (Check_ID != dr["CheckID"].ToString())
                {
                    dgvCheckIssuedList.Rows.Add(
                        dr["CheckIssuedID"].ToString(),
                        verificationStatus,
                        dr["DateEncoded"].ToString(),
                        dr["BankCode"].ToString(),
                        dr["BankAccountNo"].ToString(),
                        dr["BankAccountDescription"].ToString(),
                        dr["CheckID"].ToString(),
                        dr["CheckNo"].ToString(),
                        string.Format("{0:d/M/yyyy}", dr["CheckDate"]),
                        dr["CheckPayee"].ToString(),
                        string.Format("{0:#,###.00}", dr["CheckAmount"]),
                        dr["VoucherNo"].ToString(),
                        string.Format("{0:d/M/yyyy}", dr["VoucherDate"]),
                        dr["VoucherAmount"].ToString(),
                        dr["EncodedByFullname"].ToString(),
                        dr["VerifiedByFullname"].ToString(),
                        dr["DateVerified"].ToString(),
                        dr["AccountantsAdviceID"].ToString()
                        );
                    Check_ID = dr["CheckID"].ToString();

                }
                else
                {
                    dgvCheckIssuedList.Rows.Add(
                    dr["CheckIssuedID"].ToString(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    dr["VoucherNo"].ToString(),
                    string.Format("{0:d/M/yyyy}", dr["VoucherDate"]),
                        dr["VoucherAmount"].ToString(),
                        dr["EncodedByFullname"].ToString(),
                        dr["VerifiedByFullname"].ToString(),
                        dr["DateVerified"].ToString()
                    );
                }
                if ((dr["IsVerified"].ToString() != "1"))
                {
                    dgvCheckIssuedList.Rows[CurrentRow].DefaultCellStyle.BackColor = Color.Pink;
                    dgvCheckIssuedList.Rows[CurrentRow].Cells[1].Style.BackColor = Color.Crimson;
                }
                else
                {
                    dgvCheckIssuedList.Rows[CurrentRow].DefaultCellStyle.BackColor = Color.Honeydew;
                    dgvCheckIssuedList.Rows[CurrentRow].Cells[1].Style.BackColor = Color.SeaGreen;
                }
                CurrentRow = CurrentRow + 1;
            }
        }

        private SearchField getSearchValue()
        {
            string getValueOfVerficationStatus = "0";
            if (cboView.SelectedIndex == 0)
            {
                getValueOfVerficationStatus = "1";
            }

            btnVerified.Enabled = false;
            btnUnverified.Enabled = false;

            SearchField reassignValueofSearchField = new SearchField()// Assign the values to the model
            {
                VerificationStatus = getValueOfVerficationStatus,
                CheckNumber = txtCheckNumber.Text,
                VoucherNumber = txtVoucherNumber.Text
            };
            return reassignValueofSearchField;
        }

        private void txtVoucherNumber_TextChanged(object sender, EventArgs e)
        {
            validation.isNumber(txtVoucherNumber);
        }
 
        private void txtCheckNumber_TextChanged(object sender, EventArgs e)
        {
            validation.isNumber(txtCheckNumber);
        }


    }
}
