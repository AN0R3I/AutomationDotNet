using System;
using AutomationDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationDemoTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("acuzinna").WithPassword("1234567").Login();

            //Assert.IsTrue(DashboardPage.IsAt, "Failed to login");
        }

        [TestCleanup]
        public void Cleanup()
        {
           Driver.Close();
        }
    }
}
