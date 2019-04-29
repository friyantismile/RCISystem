using RCISystem.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCISystem.View
{
    public partial class frmVoucherAdd : Form
    {
        private DataGridView dgView;
        private TextBox txtCheckAmount;
        private Validation validation = new Validation();

        public frmVoucherAdd(DataGridView dgView ,TextBox txtCheckAmount)
        {
            InitializeComponent();
            this.dgView = dgView;
            this.txtCheckAmount = txtCheckAmount;
        }

 
        public void AddVoucher(string VoucherNo, DateTime VoucherDate, float VoucherAmount)
        {
            dgView.Rows.Add(VoucherNo, VoucherDate, string.Format("{0:#,###.00}", VoucherAmount));            
        }

        public void Get_Total_Amount()
        {
            float temp_TotalAmount = 0;
            for (int i = 0; i < dgView.Rows.Count; i++)
            {
                temp_TotalAmount = temp_TotalAmount + float.Parse(dgView.Rows[i].Cells[2].Value.ToString());
            }
            txtCheckAmount.Text = string.Format("{0:#,###.00}", temp_TotalAmount);
        }

        private void btnSaveVoucher_Click(object sender, EventArgs e)
        {
            bool isVoucherAmountNotEmpty = validation.checkTextboxIfEmpty(txtVoucherAmount);
            bool isVoucherNoNotEmpty = validation.checkTextboxIfEmpty(txtVoucherNo);

            if (isVoucherAmountNotEmpty && isVoucherNoNotEmpty)
            {
                AddVoucher(txtVoucherNo.Text, dtpVoucherDate.Value,  float.Parse(txtVoucherAmount.Text));
                txtVoucherNo.Clear();
                txtVoucherAmount.Clear();
                Get_Total_Amount();
                this.Dispose();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtVoucherNo_TextChanged(object sender, EventArgs e)
        {
            validation.isNumber(txtVoucherNo);
        }

        private void txtVoucherAmount_TextChanged(object sender, EventArgs e)
        {
            validation.isNumber(txtVoucherNo);
        }
    }
}
