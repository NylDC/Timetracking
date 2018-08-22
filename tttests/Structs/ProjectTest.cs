using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using timetracker.Models;
using timetracker.Structs;

namespace tttests.Structs
{
    [TestClass]
    public class ProjectTest
    {
        const string ItemName = "testproject1";
        const bool ItemMkScrsh = true;
        const bool ItemChkKB = false;
        const bool ItemChkMouse = true;
        const bool ItemChkApps = true;
        const bool ItemChkBrowsers = true;
        const bool ItemActive = true;

        [TestMethod]
        public void AllRoutines()
        {
            var project = new Project(ItemName, ItemMkScrsh, ItemChkKB, ItemChkMouse, ItemChkApps, ItemChkBrowsers, ItemActive);

            MyAssert.Equals(project.Name, ItemName);
            MyAssert.Equals(project.MakeScreenshots, ItemMkScrsh);
            Assert.AreEqual(project.CheckKeyboard, ItemChkKB);
            MyAssert.Equals(project.CheckMouse, ItemChkMouse);
            MyAssert.Equals(project.CheckApps, ItemChkApps);
            MyAssert.Equals(project.CheckBrowsers, ItemChkBrowsers);
            Assert.AreEqual(project.Active, ItemActive);

            // test saving
            project.Save();

            // user2 must be retrieved from the DB now
            var project2 = ProjectModel.Find(project.Id);

            MyAssert.Equals(project2.Name, ItemName);
            MyAssert.Equals(project2.MakeScreenshots, ItemMkScrsh);
            Assert.AreEqual(project2.CheckKeyboard, ItemChkKB);
            MyAssert.Equals(project2.CheckMouse, ItemChkMouse);
            MyAssert.Equals(project2.CheckApps, ItemChkApps);
            MyAssert.Equals(project2.CheckBrowsers, ItemChkBrowsers);
            Assert.AreEqual(project2.Active, ItemActive);

            project2.Delete();

            try
            {
                ProjectModel.Find(project.Id);
            }
            catch (Exception e)
            {
                return;
            }
            throw new Exception("Project is still found");
        }
    }
}
