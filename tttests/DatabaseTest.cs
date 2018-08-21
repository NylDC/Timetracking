using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using timetracker.Services;

namespace tttests
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void WhereCondition_AgtB()
        {
            WhereCondition wc = new WhereCondition() {
                Left = "A",
                Right = "B",
                Operator = ">"
            };
            string correctValue = "[A] >'B'";
            string testValue = wc.Build();
            MyAssert.Equals(correctValue, testValue);
        }

        [TestMethod]
        public void WhereCondition_AB()
        {
            WhereCondition wc = new WhereCondition()
            {
                Left = "A",
                Right = "B"
            };
            string correctValue = "[A] ='B'";
            string testValue = wc.Build();
            MyAssert.Equals(correctValue, testValue);
        }

        [TestMethod]
        public void WhereCondition_AisNULL()
        {
            WhereCondition wc = new WhereCondition()
            {
                Left = "A",
                Operator = "IS",
                Right = "NULL"
            };
            string correctValue = "[A] IS NULL";
            string testValue = wc.Build();
            MyAssert.Equals(correctValue, testValue);
        }

        [TestMethod]
        public void WhereCondition_AisnotNULL()
        {
            WhereCondition wc = new WhereCondition()
            {
                Left = "A",
                Operator = "IS NOT",
                Right = "NULL"
            };
            string correctValue = "[A] IS NOT NULL";
            string testValue = wc.Build();
            MyAssert.Equals(correctValue, testValue);
        }

        [TestMethod]
        public void WhereGroup_2AND()
        {
            WhereGroup wg = new WhereGroup() {
                new WhereCondition("A","B"),
                new WhereCondition("C","D"),
            };
           
            string correctValue = "([A] ='B' AND [C] ='D')";
            string testValue = wg.Build();
            MyAssert.Equals(correctValue, testValue);
        }

        [TestMethod]
        public void WhereGroup_2OR()
        {
            WhereGroup wg = new WhereGroup() {
                new WhereCondition("A","B"),
                new WhereCondition("C","D"),
            };

            string correctValue = "[A] ='B' OR [C] ='D'";
            string testValue = wg.Build();
            MyAssert.Equals(correctValue, testValue);
        }
    }
}
