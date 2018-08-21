using System;
using System.Collections.Generic;
using System.Data;
using timetracker.Services;

namespace timetracker.Structs
{
    /// <summary>
    /// Abstract class that represents an arbitrary database record.
    /// To be implemented in other Structs.
    /// </summary>
    public abstract class ModelType
    {
        public int Id { get; private set; } = 0;

        /// <summary>
        /// Save current contents to the database.
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            var dict = new Dictionary<string, object>();
            OnSave(dict);
            if(Id != 0)
            {
                dict["Id"] = Id;
                DoUpdate(dict);
            } else
            {
                DoInsert(dict);
            }
            return Id;
        }

        /// <summary>
        /// Remove current object from the database.
        /// </summary>
        public void Delete()
        {
            if(Id != 0)
                DBConn.Instance.Delete(Table(), PK(), Id);
        }

        /// <summary>
        /// Perform INSERT on the nonexistent record
        /// </summary>
        /// <param name="dict"></param>
        private void DoInsert(Dictionary<string, object> dict)
        {
            Id = DBConn.Instance.Insert(Table(), dict);
        }

        /// <summary>
        /// Perform UPDATE on the existing record
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        private bool DoUpdate(Dictionary<string, object> dict)
        {
            return DBConn.Instance.Update(Table(), PK(), dict);
        }

        /// <summary>
        /// Take data from DB, use Id and call underlying OnApply() to fill local fields from DataRow
        /// </summary>
        /// <param name="row"></param>
        public void Apply(DataRow row)
        {
            Id = Int32.Parse(row["Id"].ToString());
            OnApply(row);
        }

        /// <summary>
        /// Abstract function that is executed on the child class instances to fill additional fields from DB.
        /// Used on object creation.
        /// </summary>
        /// <param name="row"></param>
        abstract protected void OnApply(DataRow row);

        /// <summary>
        /// Abstract function that is executed on the child class instances to save record to DB.
        /// Used on object creation.
        /// </summary>
        /// <param name="dict"></param>
        /// 
        abstract protected void OnSave(Dictionary<string, object> dict);

        /// <summary>
        /// Must return Unique ID field name
        /// </summary>
        /// <returns></returns>
        abstract public string PK();

        /// <summary>
        /// Must return Table name
        /// </summary>
        /// <returns></returns>
        abstract public string Table();

        /// <summary>
        /// Sets display name for the item.
        /// </summary>
        /// <param name="name"></param>
        abstract public void SetName(string name);
    }
}
