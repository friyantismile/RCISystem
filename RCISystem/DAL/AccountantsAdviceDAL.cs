using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RCISystem.Model;

namespace RCISystem.DAL
{
    public class AccountantsAdviceDAL : RCISQLConnection, IAccountantsAdviceDAL
    {
        public DataTable SearchByAccountantsAdviceID(decimal Id)
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
                sql = "SELECT AccountantsAdviceID";
                sql = sql + ",AdviceDate,GeneratedByID";
                sql = sql + ",GeneratedDate";
                sql = sql + ",CertifiedByID";
                sql = sql + " from tblAccountantsAdvice";
                sql = sql + " WHERE AccountantsAdviceID=" + Id + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


        public decimal AddAccountantsAdviceTransaction(AccountantsAdviceModel accountantsAdviceModel, List<AccountantsAdviceDetailModel> accountantsAdviceDetailModel)
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            {
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction = null;
                decimal New_AccountantsAdviceID = 0;
                decimal Result = 0;
                string sql = "";

                try
                {
                    // BeginTransaction() Requires Open Connection
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    sql="INSERT INTO [tblAccountantsAdvice](";
                    sql = sql + "[AdviceDate]";
                    sql = sql + ",[GeneratedByID]";
                    sql = sql + ",[GeneratedDate]";
                    sql = sql + ",[CertifiedByID]";
                    sql = sql + ") VALUES (";
                    sql = sql + "'" + accountantsAdviceModel.AdviceDate + "'";
                    sql = sql + ","+ accountantsAdviceModel.GeneratedByID +"";
                    sql = sql + ",'" + accountantsAdviceModel.GeneratedDate + "'";
                    sql = sql + "," + accountantsAdviceModel.CertifiedByID + ")";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    command.CommandText = "Select @@Identity";
                    New_AccountantsAdviceID = int.Parse(command.ExecuteScalar().ToString());

                    //   LBound(arDetails, 2) To UBound(arDetails, 2)
                    foreach (var item in accountantsAdviceDetailModel)
                    {
                        sql = "INSERT INTO [tblAccountantsAdviceDetail]";
                        sql = sql + "([AccountantsAdviceID]";
                        sql = sql + ",[CheckIssuedID]";
                        sql = sql + ",[CheckID]";
                        sql = sql + ",[VoucherID]";
                        sql = sql + ",[VoucherNo]";
                        sql = sql + ",[VoucherAmount]";
                        sql = sql + ",[CheckNo]";
                        sql = sql + ",[CheckDate]";
                        sql = sql + ",[CheckPayee]";
                        sql = sql + ",[CheckAmount]";
                        sql = sql + ",[BankAccountID])";
                        sql = sql + "VALUES";
                        sql = sql + "("+ New_AccountantsAdviceID +"";
                        sql = sql + "," + item.CheckIssuedID + "";
                        sql = sql + "," + item.CheckID + "";
                        sql = sql + "," + item.VoucherID + "";
                        sql = sql + ",'" + item.VoucherNo + "'";
                        sql = sql + "," + item.VoucherAmount + "";
                        sql = sql + ",'" + item.CheckNo + "'";
                        sql = sql + ",'" + item.CheckDate + "'";
                        sql = sql + ",'" + item.CheckPayee + "'";
                        sql = sql + "," + item.CheckAmount + "";
                        sql = sql + "," + item.BankAccountID + ")";
                        command.CommandText = sql;
                        command.ExecuteNonQuery();

                        command.CommandText = "Update tblCheckIssued Set AccountantsAdviceID=" + New_AccountantsAdviceID + " Where CheckID=" + item.CheckID + "";
                        command.ExecuteNonQuery();
                    }



                    // Execute 2nd Command
                    //command.CommandText = "delete from UserDetail where UserId='100'";
                    //command.CommandText = "Insert into UserDetail (UserId, UserName) VALUES (101, 'Manoj')";
                    //command.ExecuteNonQuery();
                    transaction.Commit();
                    Result = New_AccountantsAdviceID;
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
    }
}
