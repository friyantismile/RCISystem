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
    public class UserDAL : RCISQLConnection, IUserDAL
    {

        public DataTable SearchUserByUserNamePassword(UserModel userModel)
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
                sql = "SELECT [UserID]";
                sql = sql + ",[Username]";
                sql = sql + ",[Password]";
                sql = sql + ",[Fullname]";
                sql = sql + ",[Designation]";
                sql = sql + ",[AccessLevel]";
                sql = sql + ",[OfficeID]";
                sql = sql + " FROM [tblUser]";
                sql = sql + " WHERE ([Username]=@Username)";
                sql = sql + " AND ([Password]=@Password)";
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Username", userModel.Username);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Password", userModel.Password);
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
