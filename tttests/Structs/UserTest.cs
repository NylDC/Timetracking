using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using timetracker.Structs;
using timetracker.Models;

namespace tttests.Structs
{
    [TestClass]
    public class UserTest
    {
        const string ItemLogin = "testuser1";
        const string ItemFullName = "The Test User 1";
        const string ItemPassword = "password";
        const bool   ItemIsAdmin = false;
        const string ItemGST = "28571034";
        const string ItemIRD = "12345678";
        const bool   ItemEnabled = true;
        const string ItemAddress = "Auckland, 1 Queen st.";

        [TestMethod]
        public void AllRoutines()
        {
            var user = new User(ItemLogin, ItemFullName, ItemPassword, ItemIsAdmin, ItemAddress, ItemGST, ItemIRD,ItemEnabled);

            MyAssert.Equals(user.Login, ItemLogin);
            MyAssert.Equals(user.FullName, ItemFullName);
            Assert.AreEqual(user.IsAdmin, ItemIsAdmin);
            MyAssert.Equals(user.Address, ItemAddress);
            MyAssert.Equals(user.GSTNumber, ItemGST);
            MyAssert.Equals(user.IRDNumber, ItemIRD);
            Assert.AreEqual(user.Enabled, ItemEnabled);

            // test saving
            user.Save();

            // user2 must be retrieved from the DB now
            var user2 = UserModel.Find(user.Id);

            MyAssert.Equals(user2.Login, ItemLogin);
            MyAssert.Equals(user2.FullName, ItemFullName);
            Assert.AreEqual(user2.IsAdmin, ItemIsAdmin);
            MyAssert.Equals(user2.Address, ItemAddress);
            MyAssert.Equals(user2.GSTNumber, ItemGST);
            MyAssert.Equals(user2.IRDNumber, ItemIRD);
            Assert.AreEqual(user2.Enabled, ItemEnabled);

            user2.Delete();

            try
            {
                UserModel.Find(user.Id);
            }catch(Exception e)
            {
                return;
            }
            throw new Exception("User is still found");
        }
    }
}
