using System.Data.OleDb;
using System.IO;

namespace Metro_Operation
{
    public static class AppState
    {
        public static bool Exam;
        public static bool Test;
        public static bool AnsShould;
        public static bool Election;

        // ===== مسیر سرور =====
        private static string _serverSharePath;
        public static string ServerSharePath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_serverSharePath))
                {
                    _serverSharePath=DetectServerSharePath();
                }

                return _serverSharePath;
            }
        }

        // مسیرهای مهم
        public static string LogPath => Path.Combine(ServerSharePath, "Logs");
        public static string UpdatePath => Path.Combine(ServerSharePath, "Update");
        public static string DataPath => Path.Combine(ServerSharePath, "Data");
        public static string AppPath => Path.Combine(ServerSharePath);

        // پسورد دیتابیس
        private static readonly string DatabasePassword="Ali&/\\/\\@ry";

        // مسیر دیتابیس
        private static string _databasePath;
        public static string DatabasePath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_databasePath))
                {
                    _databasePath=DetectDatabasePath();
                }

                return _databasePath;
            }
        }

        // رشته اتصال
        private static string _connectionString;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_connectionString))
                {
                    _connectionString=$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(DatabasePath, "Metro.acc")};Jet OLEDB:Database Password={DatabasePassword};";
                }
                return _connectionString;
            }
        }

        // ===== بررسی وجود دیتابیس =====
        public static bool DbChecker()
        {
            return !string.IsNullOrWhiteSpace(DatabasePath) && File.Exists(Path.Combine(DatabasePath, "Metro.acc"));
        }

        // ===== ساخت کانکشن جدید =====
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }

        // ===== اطلاعات کاربر (پس از لاگین) =====
        public static string LogginName { get; set; }=string.Empty;
        public static string UserName { get; set; }=string.Empty;
        public static string UserPnum { get; set; }=string.Empty;
        public static string UserLnum { get; set; }=string.Empty;
        public static string UserPost { get; set; }=string.Empty;
        public static string UserStaff { get; set; }=string.Empty;
        public static string UserLocal { get; set; }=string.Empty;
        public static string UserShift { get; set; }=string.Empty;
        public static string UserTime { get; set; }=string.Empty;
        public static int UserLevel { get; set; }=-1;

        // ===== توابع private =====

        private static string DetectServerSharePath()
        {
            try
            {
                string[] candidatePaths=new string[]
                {
                    @"E:\Program Files\SOH",
                    @"\\10.180.62.62\SOH$2"
                };

                foreach (string path in candidatePaths)
                {
                    if (Directory.Exists(path))
                    {
                        return path;
                    }
                }

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        private static string DetectDatabasePath()
        {
            try
            {
                string dbFile=Path.Combine(ServerSharePath, "Metro.acc");
                string testMarker=Path.ChangeExtension(dbFile, ".acc");

                if (File.Exists(dbFile) && File.Exists(testMarker))
                {
                    return ServerSharePath;
                }

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
