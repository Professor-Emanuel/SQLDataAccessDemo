using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLDataAccessDemo2
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            //allow to compile the application while working on it
            //throw new NotImplementedException();

            //creat connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output = return connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                //stored procedure for looking up people = People_GetByLastName
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output
            }
        }
    }
}
