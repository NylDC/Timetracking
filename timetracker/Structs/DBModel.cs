using System;
using System.Collections.Generic;
using System.Data;
using timetracker.Services;

namespace timetracker.Structs
{
    class DBModel<T> where T : ModelType, new()
    {

        public static T Find(int pk)
        {
            T obj = new T();
            DataRow row = DBConn.Instance.GetOneFromTable(obj.Table(), obj.PK(), pk);
            if (row == null)
                throw new KeyNotFoundException();
            
            obj.Apply(row);
            return obj;
        }

        public static T Find(string pk) => Find(Int32.Parse(pk));

        public static Dictionary<int, T> All(){
            var result = new Dictionary<int, T>();
            DataTable dt = DBConn.Instance.GetAllFromTable((new T()).Table());
            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                obj.Apply(row);
                result[ Int32.Parse(row[obj.PK()].ToString()) ] = obj;
            }
            return result;
        }

        public static List<T> List()
        {
            var result = new List<T>();
            DataTable dt = DBConn.Instance.GetAllFromTable((new T()).Table());
            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                obj.Apply(row);
                result.Add(obj);
            }
            return result;
        }

        public static List<string> List(string field)
        {
            var result = new List<string>();
            DataTable dt = DBConn.Instance.GetAllFromTable((new T()).Table());
            foreach (DataRow row in dt.Rows)
            {
                result.Add(row[field].ToString());
            }
            return result;
        }

        public static Dictionary<int,string> ListIndexed(string field)
        {
            var result = new Dictionary<int, string>();
            T tpl = new T();
            DataTable dt = Services.DBConn.Instance.GetAllFromTable(tpl.Table());
            foreach (DataRow row in dt.Rows)
            {
                result[Int32.Parse(row[tpl.PK()].ToString())] = row[field].ToString();
            }
            return result;
        }
    }
}
