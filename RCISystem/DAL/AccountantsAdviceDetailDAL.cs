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
    public class AccountantsAdviceDetailDAL : RCISQLConnection, IAccountantsAdviceDetailDAL
    {

        public DataTable SearchByAccountantsAdviceID(int Id)
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
                sql = "SELECT [AccountantsAdviceDetail]";
                sql = sql + ",[AccountantsAdviceID]";
                sql = sql + ",[CheckIssuedID]";
                sql = sql + ",[CheckID]";
                sql = sql + ",[VoucherID]";
                sql = sql + ",[VoucherNo]";
                sql = sql + ",[VoucherAmount]";
                sql = sql + ",[CheckNo]";
                sql = sql + ",[CheckDate]";
                sql = sql + ",[CheckPayee]";
                sql = sql + ",[CheckAmount]";
                sql = sql + ",[BankAccountID]";
                sql = sql + " FROM [dbo].[tblAccountantsAdviceDetail]";
                sql = sql + " WHERE AccountantsAdviceID=" + Id + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


        public DataTable SearchByCheckID(int Id)
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
                sql = "SELECT [AccountantsAdviceDetail]";
                sql = sql + ",[AccountantsAdviceID]";
                sql = sql + ",[CheckIssuedID]";
                sql = sql + ",[CheckID]";
                sql = sql + ",[VoucherID]";
                sql = sql + ",[VoucherNo]";
                sql = sql + ",[VoucherAmount]";
                sql = sql + ",[CheckNo]";
                sql = sql + ",[CheckDate]";
                sql = sql + ",[CheckPayee]";
                sql = sql + ",[CheckAmount]";
                sql = sql + ",[BankAccountID]";
                sql = sql + " FROM [dbo].[tblAccountantsAdviceDetail]";
                sql = sql + " WHERE CheckID=" + Id + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
