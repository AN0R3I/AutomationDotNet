using OpenQA.Selenium.Firefox;
using System;

namespace AutomationDemo
{
    public class Class1
    {
        public void Go()
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com");
        }
    }
}
