using System;
using System.Collections.Generic;
using System.Data;
using timetracker.Services;

namespace timetracker.Structs
{
    abstract class ModelType
    {
        protected int Id = 0;
        
        public int Save()
        {
            var dict = new Dictionary<string, object>();
            OnSave(dict);
            if(Id!=0)
            {
                DoUpdate(dict);
            } else
            {
                DoInsert(dict);
            }
            return Id;
        }

        public void Delete()
        {
            if(Id != 0)
                DBConn.Instance.Delete(Table(), PK(), Id);
        }
        private void DoInsert(Dictionary<string, object> dict)
        {
            Id = DBConn.Instance.Insert(Table(), dict);
        }

        private bool DoUpdate(Dictionary<string, object> dict)
        {
            return DBConn.Instance.Update(Table(), PK(), dict);
        }

        public void Apply(DataRow row)
        {
            Id = Int32.Parse(row["Id"].ToString());
            OnApply(row);
        }
        abstract protected void OnApply(DataRow row);

        abstract protected void OnSave(Dictionary<string, object> dict);

        abstract public string PK();

        abstract public string Table();
    }
}
