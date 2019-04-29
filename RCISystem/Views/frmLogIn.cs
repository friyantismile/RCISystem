using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCISystem.Model;
using RCISystem.BLL;
using RCISystem.Helper;

namespace RCISystem.Views
{
    public partial class frmLogIn : Form
    {
        private int CurrentUserID;
        private int CurrentOfficeID;
        private string CurrentUserFullname;

        private Validation validation = new Validation();

        public frmLogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool isUsernameNotEmpty = validation.checkTextboxIfEmpty(txtUsername);
            if (!isUsernameNotEmpty)
            {
                pnlUsername.BackColor = Color.Pink;
                return; 
            }
            pnlUsername.BackColor = Color.White;

            bool isPasswordNotEmpty = validation.checkTextboxIfEmpty(txtPassword);
            if (!isPasswordNotEmpty)
            {
                pnlPassword.BackColor = Color.Pink;
                return;
            }
            pnlPassword.BackColor = Color.White;

            Get_User_info();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        public void Get_User_info()
        {
            try
            {
                UserModel newUserModel = new UserModel()// Assign the values to the model
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                UserService newUserService = new UserService();
                DataTable dt = new DataTable();
                dt = newUserService.SearchUserByUsernamePassword(newUserModel);

                int Record_Count = dt.Rows.Count;
                if (Record_Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    CurrentUserID = int.Parse(dr["UserID"].ToString());
                    CurrentUserFullname = dr["Fullname"].ToString();
                    CurrentOfficeID = int.Parse(dr["OfficeID"].ToString());
                    //MessageBox.Show("Welcome " + CurrentUserFullname);
                    this.Hide();
                    frmCheckIssuedList newfrmCheckIssuedList = new frmCheckIssuedList(CurrentUserID, CurrentOfficeID);
                    newfrmCheckIssuedList.Show();

                }
                else
                {
                    MessageBox.Show("Invalid User");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            validation.isLetter(txtUsername);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            validation.isLetter(txtUsername);
        }
    }
}
