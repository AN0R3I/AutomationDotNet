using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://ehr.unifiedpractice.com/Public/Account/Login?");
           // var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
           // wait.Until(d => d.SwitchTo().ActiveElement().Get("id") == "user_login");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var userNameInput = Driver.Instance.FindElement(By.Id("Parameter_UserName"));
            userNameInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("Parameter_Password"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/div[1]/form/div[3]/button"));
            loginButton.Click();
        }
    }
}
