using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Services
{
    public class DBConn
    {
        private DBConn()
        {
            Connect();
        }
        ~DBConn()
        {
            Disconnect();
        }

        private static DBConn _instance = null;
        /// <summary>
        /// Provides access to a singleton instance
        /// </summary>
        public static DBConn Instance { get => _instance ?? (_instance = new DBConn()); }

        private readonly string connstr = Properties.Settings.Default.databaseConnectionString;

        private SqlConnection conn = null;
        private SqlCommand cmd;
        private SqlDataReader rdr;

        /// <summary>
        /// Helper function for new SqlCommand(string).
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public SqlCommand MkSqlCommand(string str)
        {
            cmd = new SqlCommand(str, conn);
            return cmd;
        }

        /// <summary>
        /// Helper function for new SqlCommand().
        /// </summary>
        /// <returns></returns>
        public SqlCommand MkSqlCommand()
        {
            cmd = new SqlCommand();
            cmd.Connection = conn;
            return cmd;
        }

        /// <summary>
        /// Create DataTable and fill it with the command's result.
        /// </summary>
        /// <param name="_cmd"></param>
        /// <returns></returns>
        public DataTable DumpCommandData(SqlCommand _cmd)
        {
            DataTable dt = new DataTable();

            rdr = _cmd.ExecuteReader();
            dt.Load(rdr);
            rdr.Close();
            return dt;
        }

        /// <summary>
        /// Return DataRow filled it with the command result's first row.
        /// </summary>
        /// <param name="_cmd"></param>
        /// <returns></returns>
        public DataRow DumpFirstRow(SqlCommand _cmd)
        {
            DataTable dt = new DataTable();

            rdr = _cmd.ExecuteReader();
            dt.Load(rdr);
            rdr.Close();

            foreach (DataRow row in dt.Rows)
            {
                return row;
            }
            return null;
        }


        /// <summary>
        /// Deletes record in the @table represented by a "@pkname=@id" condition
        /// </summary>
        /// <param name="table"></param>
        /// <param name="pkname"></param>
        /// <param name="id"></param>
        /// <returns>
        /// True on success, false if row was not found.
        /// </returns>
        public bool Delete(string table, string pkname, int id)
        {
            cmd.CommandText = "DELETE FROM [" + table + "] WHERE [" + pkname + "]=" + id.ToString();

            return (cmd.ExecuteNonQuery() == 1);
        }

        /// <summary>
        /// Executes a SQL UPDATE query on the @table.  
        /// </summary>
        /// <param name="table">Table to execute UPDATE on.</param>
        /// <param name="pkname">Name of the privvate key field in the @dict</param>
        /// <param name="dict">List of fields to alter. Must contain key mentioned in @dict</param>
        /// <returns></returns>
        public bool Update(string table, string pkname, Dictionary<string, object> dict)
        {
            string setters = "";
            cmd = MkSqlCommand();
            foreach (string k in dict.Keys)
            {
                if (k != pkname)
                {
                    if (setters.Length > 0) setters += ", ";
                    setters += "[" + k + "]" + "=@" + k;
                }
                cmd.Parameters.AddWithValue("@"+k, dict[k]);
            }
            cmd.CommandText = "UPDATE [" +table+ "] SET " +setters+ " WHERE [" + pkname + "]=@"+ pkname;
            
            return (cmd.ExecuteNonQuery() == 1);
        }

        /// <summary>
        /// Executes SQL INSERT statement on the @table.
        /// </summary>
        /// <param name="table">Table to execute UPDATE on.</param>
        /// <param name="dict">List of fields to insert.</param>
        /// <returns>ID of the newly inserted row.</returns>
        public int Insert(string table, Dictionary<string, object> dict)
        {
            string keyList = "";
            string valList = "";
            cmd = MkSqlCommand();
            
            foreach (string k in dict.Keys)
            {
                if (keyList.Length > 0)
                {
                    keyList += ", ";
                    valList += ", ";
                }
                keyList += "["+k+"]"; //make names safe
                valList += "@" + k;
                cmd.Parameters.AddWithValue("@" + k, dict[k]);
            }
            cmd.CommandText = "INSERT INTO [" + table + "] (" + keyList+ ") OUTPUT INSERTED.ID VALUES (" + valList + ")" ;

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Fetch all records from @table
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public DataTable GetAllFromTable(string table) => GetAllFromTable(table, null);

        /// <summary>
        /// Fetch all records filtered with @whereConditions
        /// </summary>
        /// <param name="table">Table to execute SELECT on.</param>
        /// <param name="whereConditions">WhereGroup or null</param>
        /// <returns></returns>
        public DataTable GetAllFromTable(string table, WhereGroup whereConditions)
        {
            string sql = "SELECT * FROM " + table;
            if (whereConditions != null)
            {
                sql += " WHERE " + whereConditions.Build();
            }
            cmd = MkSqlCommand(sql);

            return DumpCommandData(cmd);
        }

        /// <summary>
        /// Fetch one row from @table that matches @keyName=@key condition.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="keyName"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataRow GetOneFromTable(string table, string keyName, int key)
        {
            cmd = MkSqlCommand("SELECT * FROM [" + table + "] WHERE [" + keyName + "]=" + key.ToString());

            return DumpFirstRow(cmd);
        }

        /// <summary>
        /// Fetch one row from @table that matches @whereConditions
        /// </summary>
        /// <param name="table"></param>
        /// <param name="whereConditions">WhereGroup or null</param>
        /// <returns></returns>
        public DataRow GetOneFromTable(string table, WhereGroup whereConditions)
        {
            string sql = "SELECT * FROM [" + table + "]";
            if (whereConditions != null)
            {
                sql += " WHERE " + whereConditions.Build();
            }
            cmd = MkSqlCommand(sql);

            return DumpFirstRow(cmd);
        }

        /// <summary>
        /// Perform database connection
        /// </summary>
        private void Connect()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
        }

        /// <summary>
        /// Disconnect from the database
        /// </summary>
        private void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e) { }
        }

        /// <summary>
        /// Helper function to SqlCommand.ExecuteScalar()
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static int GetIntResult(SqlCommand cmd)
        {
            try
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
