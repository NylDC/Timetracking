using System.Collections.Generic;
using System.Data;

namespace timetracker.Structs
{
    class Project : ModelType
    {
        public override string Table() => "Projects";
        public override string PK() => "Id";
        
        public string Name { get; set; } = "Test project";

        public bool CheckKeyboard = true;
        public bool MakeScreenshots = true;
        public bool CheckMouse = true;
        public bool CheckApps = true;
        public bool CheckBrowsers = true;
        public bool Enabled = false;

        public Project() { }

        public Project(string name, bool mkScrshots, bool chkKeyboard, bool chkMouse, bool chkApps, bool chkBrowsers, bool enabled)
        {
            Name = name;
            MakeScreenshots = mkScrshots;
            CheckKeyboard = chkKeyboard;
            CheckMouse = chkMouse;
            CheckApps = chkApps;
            CheckBrowsers = chkBrowsers;
            Enabled = enabled;
        }

        // Implement DB-related routines
        protected override void OnApply(DataRow row)
        {
            Name                = row["Name"].ToString();
            CheckApps           = row["CheckApps"].ToString() == "1";
            CheckBrowsers       = row["CheckBrowsers"].ToString() == "1";
            CheckKeyboard       = row["CheckKeyboard"].ToString() == "1";
            CheckMouse          = row["CheckMouse"].ToString() == "1";
            Enabled             = row["Enabled"].ToString() == "1";
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["Name"]            = Name;
            dict["CheckApps"]       = CheckApps ? 1 : 0;
            dict["CheckBrowsers"]   = CheckBrowsers ? 1 : 0;
            dict["CheckKeyboard"]   = CheckKeyboard ? 1 : 0;
            dict["CheckMouse"]      = CheckMouse ? 1 : 0;
            dict["Enabled"]         = Enabled ? 1 : 0;
        }
    }
}
