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
    public class CheckDAL : RCISQLConnection, ICheckDAL
    {

        public int AddCheck(CheckModel checkModel)
        {
            using (SqlCommand sqlDbCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlDbCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbCommand.CommandType = CommandType.Text;
                string sql = "";
                sql = "INSERT INTO [tblCheck] ([BankAccountID] ,[CheckNo],[CheckDate],[CheckAmount],[CheckPayee]) VALUES (@BankAccountID,@CheckNo,@CheckDate,@CheckAmount,@CheckPayee)";
                sqlDbCommand.CommandText = sql;

                // Add the input parameters to the parameter collection
                sqlDbCommand.Parameters.AddWithValue("@BankAccountID", checkModel.BankAccountID);
                sqlDbCommand.Parameters.AddWithValue("@CheckNo", checkModel.CheckNo);
                sqlDbCommand.Parameters.AddWithValue("@CheckDate", checkModel.CheckDate);
                sqlDbCommand.Parameters.AddWithValue("@CheckAmount", checkModel.CheckAmount);
                sqlDbCommand.Parameters.AddWithValue("@CheckPayee", checkModel.CheckPayee);

                // Open the connection, execute the query and close the connection
                sqlDbCommand.Connection.Open();
                sqlDbCommand.ExecuteNonQuery();

                sqlDbCommand.CommandText = "select @@identity";
                var rowsAffected = int.Parse( sqlDbCommand.ExecuteScalar().ToString());
                sqlDbCommand.Connection.Close();

                return rowsAffected;
            }
        }

        public DataTable GetAllCheck()
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
                sql = "SELECT [CheckID],[BankAccountID],[CheckNo],[CheckDate],[CheckPayee],[CheckAmount] FROM  [tblCheck]";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;   
        }


        public DataTable SearchCheckByCheckID(int CheckId)
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
                sql = "SELECT [CheckID],[BankAccountID],[CheckNo],[CheckDate],[CheckPayee],[CheckAmount] FROM  [tblCheck] Where CheckID=" + CheckId + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
