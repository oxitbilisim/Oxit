
using Microsoft.Data.SqlClient;
using Oxit.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Core
{
    public class QuartzHelper
    {

        public static void CheckDatabase()
        {

            using (SqlConnection sqlConnection = new SqlConnection(Settings.Database.ConnectionString))
            {
                List<string> tables = new List<string>();
                string oString = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'quartz' ";
                SqlCommand oCmd = new SqlCommand(oString, sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        tables.Add(oReader["TABLE_NAME"].ToString());
                    }

                }
                if (tables.Count < 11)
                {
                    oString = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Sql/Quartz.sql");
                    oString = oString.Replace("dbname", sqlConnection.Database);
                    var baches = oString.Split("GO");
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        foreach (var item in baches)
                        {

                            cmd.CommandText = item;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                sqlConnection.Close();
            }
        }
    }
}
