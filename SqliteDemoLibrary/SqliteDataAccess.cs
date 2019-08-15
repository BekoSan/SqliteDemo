using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteDemoLibrary
{
   public static  class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) {
                var output = cnn.Query<PersonModel>("select * from people", new DynamicParameters());
                return output.ToList();
            }

        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into people(FirstName,LastName) Values(@FirstName,@LastName)", person);
            }

        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
