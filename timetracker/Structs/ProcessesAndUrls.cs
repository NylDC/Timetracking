using System.Collections.Generic;
using System.Data;
using timetracker.Models;

namespace timetracker.Structs
{
    class ProcessesAndUrls:ModelType
    {
        public override string Table() => "ProcessesAndUrls";
        public override string PK() => "Id";
        public string Address { get; set; } = "";
        public string Alias { get; set; } = "";
        public bool IsUrl { get; set; } = false;
        public bool IsAllowed { get; set; } = true;

        public override string ToString() => Alias;

        public ProcessesAndUrls() { }

        public ProcessesAndUrls(string address, string alias, bool isUrl, bool isAllowed)
        {
            Address = address;
            Alias = alias;
            IsUrl = isUrl;
            IsAllowed = isAllowed;
        }

        protected override void OnApply(DataRow row)
        {
            Address = row["address"].ToString();
            Alias = row["alias"].ToString();
            IsUrl = row["isUrl"].ToString() == "True";
            IsAllowed = row["isAllowed"].ToString() == "True";
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["address"] = Address;
            dict["alias"] = Alias;
            dict["isUrl"] = IsUrl ? true : false;
            dict["isAllowed"] = IsAllowed ? true : false;
        }


        public override void SetName(string alias)
        {
           // Alias = alias;
        }




    }
}
