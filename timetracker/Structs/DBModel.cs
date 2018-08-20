using System;
using System.Collections.Generic;
using System.Data;
using timetracker.Services;

namespace timetracker.Structs
{
    /// <summary>
    /// Template class that wraps a T:ModelType with helper routines that make queries easy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DBModel<T> where T : ModelType, new()
    {

        /// <summary>
        /// Find one record with ID=@pk
        /// </summary>
        /// <param name="pk"></param>
        /// <returns></returns>
        public static T Find(int pk)
        {
            T obj = new T();
            DataRow row = DBConn.Instance.GetOneFromTable(obj.Table(), obj.PK(), pk);
            if (row == null)
                throw new KeyNotFoundException();
            
            obj.Apply(row);
            return obj;
        }

        /// <summary>
        /// Find one record that satisfies @whereConfitions
        /// </summary>
        /// <param name="whereConditions"></param>
        /// <returns></returns>
        public static T FindOne(WhereGroup whereConditions)
        {
            T obj = new T();
            DataRow row = DBConn.Instance.GetOneFromTable(obj.Table(), whereConditions);
            if (row == null)
                throw new KeyNotFoundException();

            obj.Apply(row);
            return obj;
        }

        public static T Find(string pk) => Find(Int32.Parse(pk));

        /// <summary>
        /// Fetch all records of the current type T
        /// </summary>
        /// <returns>
        /// Dictionary with unique IDs as keys and records as values 
        /// </returns>
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

        public static List<T> List() => List(null);

        /// <summary>
        /// Fetch all records of type T that satisfy @whereConfitions
        /// </summary>
        /// <param name="whereConditions"></param>
        /// <returns>List of records of type T</returns>
        public static List<T> List(WhereGroup whereConditions)
        {
            var result = new List<T>();
            DataTable dt = DBConn.Instance.GetAllFromTable((new T()).Table(), whereConditions);
            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                obj.Apply(row);
                result.Add(obj);
            }
            return result;
        }

        public static List<T> ListWithBlank(string blankName) => ListWithBlank(blankName, null);

        /// <summary>
        /// Fetch all records of type T that satisfy @whereConfitions adding one blank field with name @blankName
        /// </summary>
        /// <param name="whereConditions"></param>
        /// <returns>List of records of type T</returns>
        public static List<T> ListWithBlank(string blankName, WhereGroup whereConditions)
        {
            List<T> list = List(whereConditions);
            T blank = new T();
            blank.SetName(blankName);
            list.Insert(0, blank);
            return list;
        }

        /// <summary>
        /// Fetch a certain value from all records of type T
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static List<string> ListField(string field)
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
