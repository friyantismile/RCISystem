using System.Data;
using System.Data.SqlClient;
using RCISystem.Model;

namespace RCISystem.DAL
{
    public class VoucherDAL : RCISQLConnection, IVoucherDAL
    {
        public bool AddVoucher(VoucherModel voucherModel)
        {
            using (SqlCommand sqlDbCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlDbCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbCommand.CommandType = CommandType.Text;
                string sql = "";
                sql = "INSERT INTO [tblVoucher] ([VoucherNo] ,[VoucherDate],[VoucherPayee],[VoucherAmount]) VALUES (@VoucherNo,@VoucherDate,@VoucherPayee,@VoucherAmount)";
                sqlDbCommand.CommandText = sql;

                // Add the input parameters to the parameter collection
                sqlDbCommand.Parameters.AddWithValue("@VoucherNo", voucherModel.VoucherNo);
                sqlDbCommand.Parameters.AddWithValue("@VoucherDate", voucherModel.VoucherDate);
                sqlDbCommand.Parameters.AddWithValue("@VoucherPayee", voucherModel.VoucherPayee);
                sqlDbCommand.Parameters.AddWithValue("@VoucherAmount", voucherModel.VoucherAmount);

                // Open the connection, execute the query and close the connection
                sqlDbCommand.Connection.Open();
                var rowsAffected = sqlDbCommand.ExecuteNonQuery();
                sqlDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }


        public DataTable SearchVoucherByCheckID(decimal CheckId)
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
                sql = "SELECT a.CheckID,b.VoucherNo,a.VoucherID,a.CheckIssuedID FROM  tblCheckIssued a inner join tblVoucher b on a.VoucherID=b.VoucherID Where a.CheckID=" + CheckId + "";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

    }
}
