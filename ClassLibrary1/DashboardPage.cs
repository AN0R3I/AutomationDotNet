using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(19));
                wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("title") == "Dashboard");

                var h4s = Driver.Instance.FindElements(By.TagName("h4"));
                if (h4s.Count > 0)
                    return h4s[0].Text == "Weekly Appointments";
               return false;
            }
        }
    }
}
