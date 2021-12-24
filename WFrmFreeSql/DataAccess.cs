using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace WFrmFreeSql
{
    public class DataAccess
    {
        private static string strPath1 = @"E:\DetectResult\BGConfigDB\FileDB.DB";


        static IFreeSql _sqliteFreeSql;
        public static IFreeSql SqliteFreeSql
        {
            get
            {
                if (_sqliteFreeSql == null)
                {
                    string constr = $"Data Source={strPath1};Pooling=true;FailIfMissing=false";
                    _sqliteFreeSql = new FreeSql.FreeSqlBuilder().UseConnectionString(FreeSql.DataType.Sqlite, constr)
                        .UseAutoSyncStructure(true)
                        .Build();
                }
                return _sqliteFreeSql;
            }
        }

        public static void CreateDB()
        {
            if (!Directory.Exists(@"E:\DetectResult\"))
                Directory.CreateDirectory(@"E:\DetectResult\");
            if (!File.Exists(strPath1))
            {
                SQLiteConnection.CreateFile(strPath1);
            }
        }
    }
}
