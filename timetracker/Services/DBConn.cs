﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Services
{
    class DBConn
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

        public SqlCommand MkSqlCommand(string str)
        {
            cmd = new SqlCommand(str, conn);
            return cmd;
        }
        public SqlCommand MkSqlCommand()
        {
            cmd = new SqlCommand();
            cmd.Connection = conn;
            return cmd;
        }

        public DataTable DumpCommandData(SqlCommand _cmd)
        {
            DataTable dt = new DataTable();

            rdr = _cmd.ExecuteReader();
            dt.Load(rdr);
            rdr.Close();
            return dt;
        }

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


        public bool Delete(string table, string pkname, int id)
        {
            cmd.CommandText = "DELETE FROM [" + table + "] WHERE [" + pkname + "]=" + id.ToString();

            return (cmd.ExecuteNonQuery() == 1);
        }

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

        public DataTable GetAllFromTable(string table)
        {
            cmd = MkSqlCommand("SELECT * FROM " + table);

            return DumpCommandData(cmd);
        }

        public DataRow GetOneFromTable(string table, string keyName, int key)
        {
            cmd = MkSqlCommand("SELECT * FROM [" + table + "] WHERE [" + keyName + "]=" + key.ToString());

            return DumpFirstRow(cmd);
        }

        public int SaveRecord(Dictionary<string, object> dict)
        {
            return 0;
        }

        private void Connect()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
        }

        private void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e) { }
        }

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