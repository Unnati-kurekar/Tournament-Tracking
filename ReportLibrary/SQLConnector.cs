using Dapper;
using ReportLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportLibrary
{
    public class SQLConnector : IDataConnection
    {
        public void createStudent(StudentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString("StudentReport")))
            {
                var p = new DynamicParameters();

                p.Add("@firstName", model.FirstName);
                p.Add("@lastName", model.LastName);
                p.Add("@dob", model.DateOfBirth);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudent_Insert", p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");

            }
        }
    }
}
/*[dbo].spStudent_Insert

    @firstName nvarchar(100),
	@lastName nvarchar(100),
	@dob date,
    @id int = 0 output*/