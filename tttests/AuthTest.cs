using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using timetracker.Services;
using timetracker.Structs;

namespace tttests
{
    [TestClass]
    public class AuthTest
    {
        const string AuthUserName = "user";
        const string AuthUserPass = "123456";

        const string AuthAdminName = "admin";
        const string AuthAdminPass = "123456";

        [TestMethod]
        public void LogoutWithNoUser()
        {
            Auth.Logout();
            Assert.IsNull(Auth.CurrentUser);
            Auth.Logout();
        }

        [TestMethod]
        public void LoginUserWithCorrectCredentials()
        {
            User user = Auth.Authenticate(AuthUserName, AuthUserPass);
            Assert.IsNotNull(user);
            Assert.AreEqual(user, Auth.CurrentUser);
            Auth.Logout();
            Assert.IsNull(Auth.CurrentUser);
        }

        [TestMethod]
        public void LoginUserWithWrongCredentials()
        {
            Auth.Logout();
            User user = Auth.Authenticate(AuthUserName, AuthUserPass+"wrong");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void LoginAdminWithCorrectCredentials()
        {
            User user = Auth.Authenticate(AuthAdminName, AuthAdminPass);
            Assert.IsNotNull(user);
            Assert.AreEqual(user, Auth.CurrentUser);
            Auth.Logout();
            Assert.IsNull(Auth.CurrentUser);
        }

        [TestMethod]
        public void LoginAdminWithWrongCredentials()
        {
            Auth.Logout();
            User user = Auth.Authenticate(AuthAdminName, AuthAdminPass + "wrong");
            Assert.IsNull(user);
        }
    }
}
