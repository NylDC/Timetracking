using System.Collections.Generic;
using System.Data;

namespace timetracker.Structs
{
    public class Project : ModelType
    {
        public override string Table() => "Projects";
        public override string PK() => "Id";
        
        public string Name { get; set; } = "Test project";

        public bool CheckKeyboard = true;
        public bool MakeScreenshots = true;
        public bool CheckMouse = true;
        public bool CheckApps = true;
        public bool CheckBrowsers = true;
        public bool Active = false;

        public Project() { }

        public Project(string name, bool mkScrshots, bool chkKeyboard, bool chkMouse, bool chkApps, bool chkBrowsers, bool active)
        {
            Name = name;
            MakeScreenshots = mkScrshots;
            CheckKeyboard = chkKeyboard;
            CheckMouse = chkMouse;
            CheckApps = chkApps;
            CheckBrowsers = chkBrowsers;
            Active = active;
        }

        // Implement DB-related routines
        protected override void OnApply(DataRow row)
        {
            Name                = row["Name"].ToString();
            CheckApps           = row["CheckApps"].ToString() == "1";
            CheckBrowsers       = row["CheckBrowsers"].ToString() == "1";
            CheckKeyboard       = row["CheckKeyboard"].ToString() == "1";
            CheckMouse          = row["CheckMouse"].ToString() == "1";
            Active              = row["Active"].ToString() == "1";
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["Name"]            = Name;
            dict["CheckApps"]       = CheckApps ? 1 : 0;
            dict["CheckBrowsers"]   = CheckBrowsers ? 1 : 0;
            dict["CheckKeyboard"]   = CheckKeyboard ? 1 : 0;
            dict["CheckMouse"]      = CheckMouse ? 1 : 0;
            dict["Active"]          = Active ? 1 : 0;
        }
        public override void SetName(string name)
        {
            Name = name;
        }
    }
}
