using System.Collections.Generic;
using System.Data;

namespace timetracker.Structs
{
    class WorkType : ModelType
    {
        public override string Table() => "WorkTypes";
        public override string PK() => "Id";

        public string Name = "Test Work Type";

        public WorkType() { }

        public WorkType(string name)
        {
            Name = name;
        }

        protected override void OnApply(DataRow row)
        {
            Name = row["Name"].ToString();
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["Name"] = Name;
        }
    }
}
