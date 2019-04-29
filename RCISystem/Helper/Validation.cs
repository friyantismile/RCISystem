using System.Drawing;
using System.Windows.Forms;

namespace RCISystem.Helper
{
    public  class Validation
    {
        public bool checkTextboxIfEmpty(TextBox txtbox)
        {
            if (string.IsNullOrWhiteSpace(txtbox.Text))
            {
                txtbox.BackColor = Color.Pink;
                return false;
            }
            txtbox.BackColor = Color.White;
            return true;
        }   

        
        public bool isNumber(TextBox txtbox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox.Text, "[^0-9-]"))
            {
                txtbox.Text = txtbox.Text.Remove(txtbox.Text.Length - 1);
                return false;
            }
            return true;
        }

        public bool isLetter(TextBox txtbox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbox.Text, @"^[a-zA-Z0-9_@.-/']*$"))
            {
                if (txtbox.Text.Length > 0) {
                    txtbox.Text = txtbox.Text.Remove(txtbox.Text.Length - 1);
                }
                return false;
            }
            return true;
        }
    }
}
