using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timetracker.Models;
using timetracker.Structs;

namespace timetracker.Services
{
    class Auth
    {
        public static User Authenticate(string login, string password)
        {
            User tmpUser = null;
            try
            {
                tmpUser = UserModel.FindOne(new WhereGroup
                {
                    new WhereCondition("Login",login),
                    new WhereCondition("Password",password)
                });
            }
            catch (Exception ex)
            {
            }

            return CurrentUser = tmpUser;
        }

        public static User CurrentUser { get; private set; } = null;
    }
}
