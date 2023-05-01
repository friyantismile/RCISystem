using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RCISystem.Model;

namespace RCISystem.DAL
{
    public class CheckIssuedDAL : RCISQLConnection, ICheckIssuedDAL
    {
        public bool AddCheckIssued(CheckIssuedModel checkIssuedModel)
        {
            using (SqlCommand sqlDbCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlDbCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbCommand.CommandType = CommandType.Text;
                string sql = "";
                sql = "INSERT INTO [tblCheckIssued] ([CheckID] ,[VoucherID]) VALUES (@CheckID,@VoucherID)";
                sqlDbCommand.CommandText = sql;

                // Add the input parameters to the parameter collection
                sqlDbCommand.Parameters.AddWithValue("@CheckID", checkIssuedModel.CheckID);
                sqlDbCommand.Parameters.AddWithValue("@VoucherID", checkIssuedModel.VoucherID);

                // Open the connection, execute the query and close the connection
                sqlDbCommand.Connection.Open();
                var rowsAffected = sqlDbCommand.ExecuteNonQuery();
                sqlDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }


        public DataTable GetAllCheckIssued(SearchField searchField)
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                // Create the command and set its properties
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                string sql = "";
                sql = "SELECT tblCheckIssued.CheckIssuedID";
                sql = sql + ", tblCheckIssued.CheckID";
                sql = sql + ", tblCheckIssued.VoucherID";
                sql = sql + ", tblCheckIssued.DateEncoded";
                sql = sql + ", tblCheckIssued.EncodedBy";
                sql = sql + ", (Select tblUser.Fullname from tblUser Where tblUser.UserID=tblCheckIssued.EncodedBy) as EncodedByFullname";
                sql = sql + ", tblCheckIssued.DateVerified";
                sql = sql + ", tblCheckIssued.VerifiedBy";
                sql = sql + ", (Select tblUser.Fullname from tblUser Where tblUser.UserID=tblCheckIssued.VerifiedBy) as VerifiedByFullname";
                sql = sql + ", tblCheckIssued.IsVerified";
                sql = sql + ", isnull(tblCheckIssued.AccountantsAdviceID,0) as AccountantsAdviceID";
                sql = sql + ", tblCheck.BankAccountID";
                sql = sql + ", tblCheck.CheckNo";
                sql = sql + ", tblCheck.CheckDate";
                sql = sql + ", tblCheck.CheckAmount";
                sql = sql + ", tblCheck.CheckPayee";
                sql = sql + ", tblVoucher.VoucherNo";
                sql = sql + ", tblVoucher.VoucherDate";
                sql = sql + ", tblVoucher.VoucherPayee";
                sql = sql + ", tblVoucher.VoucherAmount";
                sql = sql + ", tblBankAccount.BankID";
                sql = sql + ", tblBankAccount.BankAccountNo";
                sql = sql + ", tblBankAccount.BankAccountDescription";
                sql = sql + ", tblBank.BankCode";
                sql = sql + ", tblBank.BankName";
                sql = sql + " FROM tblCheckIssued";
                sql = sql + " INNER JOIN tblCheck";
                sql = sql + " ON tblCheckIssued.CheckID = tblCheck.CheckID";
                sql = sql + " INNER JOIN tblVoucher";
                sql = sql + " ON tblCheckIssued.VoucherID = tblVoucher.VoucherID";
                sql = sql + " INNER JOIN tblBankAccount";
                sql = sql + " ON tblCheck.BankAccountID = tblBankAccount.BankAccountID";
                sql = sql + " INNER JOIN tblBank";
                sql = sql + " ON tblBankAccount.BankID = tblBank.BankID";

                if (!string.IsNullOrWhiteSpace(searchField.VerificationStatus))
                {
                    sql = sql + " WHERE tblCheckIssued.IsVerified = " + searchField.VerificationStatus;
                }

                if (!string.IsNullOrWhiteSpace(searchField.CheckNumber))
                {
                    if (!string.IsNullOrWhiteSpace(searchField.VerificationStatus))
                    {
                        sql = sql + " AND ";
                    } else
                    {
                        sql = sql + " WHERE ";
                    }

                    sql = sql + " tblCheck.CheckNo = '" + searchField.CheckNumber + "'";
                }

                if (!string.IsNullOrWhiteSpace(searchField.VoucherNumber))
                {
                    if (!(string.IsNullOrWhiteSpace(searchField.VerificationStatus) && string.IsNullOrWhiteSpace(searchField.CheckNumber)))
                    {
                        sql = sql + " AND ";
                    }
                    else
                    {
                        sql = sql + " WHERE ";
                    }

                    sql = sql + " tblVoucher.VoucherNo = '" + searchField.VoucherNumber + "'";
                }

                sql = sql + " order by tblCheckIssued.DateEncoded DESC"; 
                sql = sql + ",tblBankAccount.BankID ASC";
                sql = sql + ",tblCheck.BankAccountID ASC";
                sql = sql + ",tblCheck.CheckNo DESC";
                sql = sql + ",tblVoucher.VoucherNo ASC";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


        public decimal AddCheckIssuedTransaction(CheckModel checkModel, List<VoucherModel> voucherModel, int UserID)
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            {
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction = null;
                decimal New_CheckID = 0;
                decimal Result = 0;

                try
                {
                    // BeginTransaction() Requires Open Connection
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    command.CommandText = "INSERT INTO [tblCheck] ([BankAccountID] ,[CheckNo],[CheckDate],[CheckAmount],[CheckPayee]) VALUES (@BankAccountID,@CheckNo,@CheckDate,@CheckAmount,@CheckPayee)";
                    command.Parameters.AddWithValue("@BankAccountID", checkModel.BankAccountID);
                    command.Parameters.AddWithValue("@CheckNo", checkModel.CheckNo);
                    command.Parameters.AddWithValue("@CheckDate", checkModel.CheckDate);
                    command.Parameters.AddWithValue("@CheckAmount", checkModel.CheckAmount);
                    command.Parameters.AddWithValue("@CheckPayee", checkModel.CheckPayee);
                    command.ExecuteNonQuery();

                    command.CommandText = "Select @@Identity";
                    New_CheckID = decimal.Parse(command.ExecuteScalar().ToString());

                    //   LBound(arDetails, 2) To UBound(arDetails, 2)
                    foreach (var item in voucherModel)
                    {
                        command.CommandText = "INSERT INTO [tblVoucher] ([VoucherNo] ,[VoucherDate],[VoucherPayee],[VoucherAmount]) VALUES ('" + item.VoucherNo + "','" + item.VoucherDate + "','" + item.VoucherPayee + "'," + item.VoucherAmount + ")";                        
                        command.ExecuteNonQuery();
                        command.CommandText = "Select @@Identity";
                        decimal New_VoucherID = decimal.Parse(command.ExecuteScalar().ToString());


                        command.CommandText = "INSERT INTO [tblCheckIssued] ([CheckID] ,[VoucherID],[DateEncoded],[EncodedBy]) VALUES (" + New_CheckID + "," + New_VoucherID + ",'" + DateTime.Now + "'," + UserID + ")";
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    Result = New_CheckID;
                }
                catch
                {
                    transaction.Rollback();
                    Result = 0;
                }

                finally
                {
                    connection.Close();
                }

                return Result;
            }
        }

        public int UpdateVerification(CheckIssuedModel checkIssuedModel)
        {
            using (SqlCommand sqlDbCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlDbCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbCommand.CommandType = CommandType.Text;
                string sql = "";
                sql = "UPDATE [tblCheckIssued]";
                sql = sql + " SET DateVerified=@DateVerified";
                sql = sql + " ,VerifiedBy=@VerifiedBy";
                sql = sql + " ,IsVerified=@IsVerified";
                sql = sql + " WHERE CheckID=@CheckID";
                sqlDbCommand.CommandText = sql;

                // Add the input parameters to the parameter collection
                sqlDbCommand.Parameters.AddWithValue("@DateVerified", checkIssuedModel.DateVerified);
                sqlDbCommand.Parameters.AddWithValue("@VerifiedBy", checkIssuedModel.VerifiedBy);
                sqlDbCommand.Parameters.AddWithValue("@IsVerified", checkIssuedModel.IsVerified);
                sqlDbCommand.Parameters.AddWithValue("@CheckID", checkIssuedModel.CheckID);


                // Open the connection, execute the query and close the connection
                sqlDbCommand.Connection.Open();
                var rowsAffected = sqlDbCommand.ExecuteNonQuery();
                sqlDbCommand.Connection.Close();
                return rowsAffected;
            }
        }
        public int UpdateIsPrinted(CheckIssuedModel checkIssuedModel)
        {
            using (SqlCommand sqlDbCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlDbCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbCommand.CommandType = CommandType.Text;
                string sql = "";
                sql = "UPDATE [tblCheckIssued]";
                sql = sql + " SET DateCheckPrinted=@DateCheckPrinted";
                sql = sql + " ,CheckPrintedBy=@CheckPrintedBy";
                sql = sql + " ,IsCheckPrinted=@IsCheckPrinted";
                sql = sql + " WHERE CheckID=@CheckID";
                sqlDbCommand.CommandText = sql;

                // Add the input parameters to the parameter collection
                sqlDbCommand.Parameters.AddWithValue("@DateCheckPrinted", checkIssuedModel.DateCheckPrinted);
                sqlDbCommand.Parameters.AddWithValue("@CheckPrintedBy", checkIssuedModel.CheckPrintedBy);
                sqlDbCommand.Parameters.AddWithValue("@IsCheckPrinted", checkIssuedModel.IsCheckPrinted);
                sqlDbCommand.Parameters.AddWithValue("@CheckID", checkIssuedModel.CheckID);


                // Open the connection, execute the query and close the connection
                sqlDbCommand.Connection.Open();
                var rowsAffected = sqlDbCommand.ExecuteNonQuery();
                sqlDbCommand.Connection.Close();
                return rowsAffected;
            }
        }
        public int UpdateIsCheckCanceled(CheckIssuedModel checkIssuedModel)
        {
            using (SqlCommand sqlDbCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlDbCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbCommand.CommandType = CommandType.Text;
                string sql = "";
                sql = "UPDATE [tblCheckIssued]";
                sql = sql + " SET DateCheckCanceled=@DateCheckCanceled";
                sql = sql + " ,CheckCanceledBy=@CheckCanceledBy";
                sql = sql + " ,IsCheckCanceled=@IsCheckCanceled";
                sql = sql + " WHERE CheckID=@CheckID";
                sqlDbCommand.CommandText = sql;

                // Add the input parameters to the parameter collection
                sqlDbCommand.Parameters.AddWithValue("@DateCheckCanceled", checkIssuedModel.DateCheckCanceled);
                sqlDbCommand.Parameters.AddWithValue("@CheckCanceledBy", checkIssuedModel.CheckCanceledBy);
                sqlDbCommand.Parameters.AddWithValue("@IsCheckCanceled", checkIssuedModel.IsCheckCanceled);
                sqlDbCommand.Parameters.AddWithValue("@CheckID", checkIssuedModel.CheckID);


                // Open the connection, execute the query and close the connection
                sqlDbCommand.Connection.Open();
                var rowsAffected = sqlDbCommand.ExecuteNonQuery();
                sqlDbCommand.Connection.Close();
                return rowsAffected;
            }
        }
    }
}
