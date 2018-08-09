using System.Collections.Generic;
using System.Data;

namespace timetracker.Structs
{
    class User : ModelType
    {
        public override string Table() => "Users";
        public override string PK() => "Id";

        public string Login { get; set; } = "login";
        public string FullName { get; set; } = "full name";

        private string Password = "";
        public void SetPassword(string pw) => Password = pw;

        public bool IsAdmin { get; set; } = false;
        public bool Enabled { get; set; } = false;
        public string GSTNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string IRDNumber { get; set; } = "";

        public User() { }

        public User(string login, string fullName, string password, bool isAdmin, string address, string gstNumber, string irdNumber, bool enabled)
        {
            Login = login;
            FullName = fullName;
            Password = password;
            IsAdmin = isAdmin;
            Address = address;
            GSTNumber = gstNumber;
            IRDNumber = irdNumber;
            Enabled = enabled;
        }

        public static bool CheckAndAuthenticate(string login, string password)
        {
            // TODO: implement this
            return true;
        }

        // Implement DB-related routines
        protected override void OnApply(DataRow row)
        {
            Login = row["Login"].ToString();
            FullName = row["FullName"].ToString();
            IsAdmin = row["IsAdmin"].ToString() == "1";
            Address = row["Address"].ToString();
            GSTNumber = row["GSTNumber"].ToString();
            IRDNumber = row["IRDNumber"].ToString();
            Enabled = row["Enabled"].ToString() == "1";
        }

        protected override void OnSave(Dictionary<string, object> dict)
        {
            dict["Login"] = Login;
            dict["FullName"] = FullName;
            dict["IsAdmin"] = IsAdmin ? 1 : 0;
            if (Password != null)
                dict["Password"] = Password;
            dict["Address"] = Address;
            dict["GSTNumber"] = GSTNumber;
            dict["IRDNumber"] = IRDNumber;
            dict["Enabled"] = Enabled ? 1 : 0;
        }
    }
}
