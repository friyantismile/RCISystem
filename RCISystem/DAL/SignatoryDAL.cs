using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RCISystem.DAL
{
    public class SignatoryDAL : RCISQLConnection, ISignatoryDAL
    {

        public DataTable GetAllSignatory()
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
                sql = "SELECT [SignatoryID]";
                sql = sql + ",[Fullname]";
                sql = sql + ",[Position]";
                sql = sql + ",[OfficeID]";
                sql = sql + " FROM [tblSignatory]";
                sql = sql + " ORDER By [Fullname] Asc";
                sqlDataAdapter.SelectCommand.CommandText = sql;

                // Fill the datatable from adapter
                sqlDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


    }
}
