
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Oxit.Core.Utilities;
using Oxit.DataAccess.EntityFramework;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Core
{
    [DisallowConcurrentExecution, JobConfig("JobDatabaseBackup", "0 0 0/4 1/1 * ? *", true)]
    //her dort saatte bir yedek alir
    public class JobDatabaseBackup : IJob
    {
        private appDbContext appDbContext;

        public JobDatabaseBackup(
            appDbContext appDbContext
            )
        {
            this.appDbContext = appDbContext;

        }
        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                int backuoCount = 20;
                var dbcon = new SqlConnection(Oxit.Core.Settings.Database.ConnectionString);
                ServerConnection con = new ServerConnection(dbcon);
                Server server = new Server(con);
                string backupAdress = server.BackupDirectory;
                Backup source = new Backup();
                source.Action = BackupActionType.Database;
                source.Database = dbcon.Database;
                string fileName = dbcon.Database + "_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".BAK";
                BackupDeviceItem destination = new BackupDeviceItem(fileName, DeviceType.File);
                source.Devices.Add(destination);
                source.SqlBackup(server);
                con.Disconnect();

                Dictionary<string, DateTime> backupFiles = new();
                dbcon.Open();
                using (SqlCommand oCmd = new SqlCommand("EXEC xp_dirtree '" + backupAdress + "', 2, 1", dbcon))
                {
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            if (oReader["subdirectory"].ToString().StartsWith(dbcon.Database) && oReader["subdirectory"].ToString().EndsWith("BAK"))
                            {
                                string datestring = oReader["subdirectory"].ToString().Replace(dbcon.Database + "_", "").Replace(".BAK", "");
                                backupFiles.Add(oReader["subdirectory"].ToString(), DateTime.ParseExact(datestring, "yyyy_MM_dd_HH_mm_ss", null));
                            }

                        }

                    }
                }

                if (backupFiles.Count > backuoCount)
                {
                    backupFiles = backupFiles
                  .OrderByDescending(c => c.Value)
                  .ToList()
                  .Skip(3)
                  .Take(backupFiles.Count - backuoCount)
                  .ToList()
                  .ToDictionary(x => x.Key, x => x.Value);


                    foreach (var item in backupFiles)
                    {
                        var com = "EXECUTE master.dbo.xp_delete_file 0,N'" + backupAdress + "/" + item.Key + "'";
                        using (SqlCommand oCmd = new SqlCommand(com, dbcon))
                        {
                            oCmd.ExecuteNonQuery();
                        }
                    }
                }

                dbcon.Close();



                Console.WriteLine("JobDatabaseBackup: Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("JobDatabaseBackup: " + ex.GetInner());

            }
            return Task.CompletedTask;
        }
    }
}
