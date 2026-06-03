using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace Metro_Operation
{

    /// <summary>
    /// DatabaseHelper: کلاس مرکزی دسترسی به دیتابیس برای OleDb (Access)
    /// - همه‌ی Query ها اینجا اجرا می‌شوند.
    /// - از Using برای آزادسازی منابع استفاده می‌شود.
    /// - تابع‌های sync و async وجود دارند.
    /// </summary>
    public class DatabaseHelper
    {
        private readonly string _connStr;

        public DatabaseHelper(string connStr)
        {
            if (string.IsNullOrWhiteSpace(connStr))
            {
                throw new ArgumentException("Connection string is empty.");
            }
            _connStr = connStr;
        }

        // اجرا و بازگشت DataTable (همزمان / sync)
        public DataTable GetDataTable(string query, object[] @params = null)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection StrConnec = new OleDbConnection(_connStr))
            {
                StrConnec.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, StrConnec))
                {
                    if (@params != null)
                    {
                        foreach (object p in @params)
                        {
                            // OleDb uses positional parameters (?)
                            cmd.Parameters.AddWithValue("?", p != null ? p : DBNull.Value);
                        }
                    }
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        dt.Load(rdr);
                    }

                }

            }

            return dt;
        }

        // ---------- Database helpers (parameterized) ----------
        public static DataTable QueryToDataTable(string sql, OleDbConnection conn, Dictionary<string, object> parameters = null)
        {
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                if (parameters != null)
                {
                    // OleDb uses positional parameters, but AddWithValue with named keys is fine
                    foreach (KeyValuePair<string, object> kv in parameters)
                    {
                        cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                    }
                }
                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static int ExecuteNonQuery(string sql, OleDbConnection conn, Dictionary<string, object> parameters = null)
        {
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> kv in parameters)
                    {
                        cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                    }
                }
                return cmd.ExecuteNonQuery();
            }
        }

        // نسخه‌ی async مناسب برای استفاده با Await
        public Task<DataTable> GetDataTableAsync(string query, object[] @params = null)
        {
            return Task.Run(() => GetDataTable(query, @params));
        }

        // ExecuteNonQuery sync
        public int ExecuteNonQuery(string query, object[] @params = null)
        {
            using (OleDbConnection StrConnec = new OleDbConnection(_connStr))
            {
                StrConnec.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, StrConnec))
                {
                    if (@params != null)
                    {
                        foreach (object p in @params)
                        {
                            cmd.Parameters.AddWithValue("?", p != null ? p : DBNull.Value);
                        }
                    }
                    return cmd.ExecuteNonQuery();
                }

            }

        }

        // ExecuteNonQuery async
        public Task<int> ExecuteNonQueryAsync(string query, object[] @params = null)
        {
            return Task.Run(() => ExecuteNonQuery(query, @params));
        }

        // ExecuteScalar sync
        public dynamic ExecuteScalar(string query, object[] @params = null)
        {
            using (OleDbConnection StrConnec = new OleDbConnection(_connStr))
            {
                StrConnec.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, StrConnec))
                {
                    if (@params != null)
                    {
                        foreach (object p in @params)
                        {
                            cmd.Parameters.AddWithValue("?", p != null ? p : DBNull.Value);
                        }
                    }
                    return cmd.ExecuteScalar();
                }

            }

        }

        // ExecuteScalar async
        public Task<object> ExecuteScalarAsync(string query, object[] @params = null)
        {
            return Task.Run(() => ExecuteScalar(query, @params));
        }
    }

}
