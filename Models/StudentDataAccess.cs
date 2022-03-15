using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace SonalCRUD_ADO.Models
{
    public class StudentDataAccess
    {

        DbConnection DbConnection;
       public StudentDataAccess()
        {
            DbConnection = new DbConnection();
        }
        public List<Student>GetStudents()
        {
            string SP = "SP_Students";
            SqlCommand sql = new SqlCommand(SP, DbConnection.Connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@action", "SELECT_JOIN");
            
            if (DbConnection.Connection.State == ConnectionState.Closed)
            {
                DbConnection.Connection.Open();
            }
            SqlDataReader dr = sql.ExecuteReader();
            List<Student> students = new List<Student>();
            while (dr.Read())
            {
                Student std = new Student();
                std.Rollno = (int)dr["Rollno"];
                std.Name = dr["Name"].ToString();
                std.Stnd = dr["Stnd"].ToString();
                std.City = dr["City"].ToString();
                std.Stream = dr["Stream"].ToString();
                students.Add(std);
            }

            DbConnection.Connection.Close();
            return students;
        }
    }
}
