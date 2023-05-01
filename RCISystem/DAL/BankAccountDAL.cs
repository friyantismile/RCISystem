using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RCISystem.DAL
{
    public class BankAccountDAL : RCISQLConnection, IBankAccountDAL
    {

        public DataTable GetAllBankAccount()
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
                sql = "SELECT [BankAccountID],[BankID],[BankAccountNo],[BankAccountDescription],[BankAccountCode],[Remarks] FROM  [tblBankAccount]";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;            
        }

        public DataTable SearchBankAccountByBankID(int BankID)
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
                sql = "SELECT [BankAccountID],[BankID],[BankAccountNo],[BankAccountDescription],[BankAccountCode],[Remarks] FROM  [tblBankAccount] Where BankID=" + BankID + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


        public DataTable SearchBankAccountByBankAccountID(int BankAccountID)
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
                sql = "SELECT [BankAccountID],[BankID],[BankAccountNo],[BankAccountDescription],[BankAccountCode],[Remarks] FROM  [tblBankAccount] Where BankID=" + BankAccountID + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
