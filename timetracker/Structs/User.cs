using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetracker.Structs
{
    class User
    {
        public int Id = 1;
        public string Login = "login";
        private string Password = "password";

        private static bool CheckAndAuthenticate(string login, string password)
        {
            // TODO: implement this
            return true;
        }
    }
}
