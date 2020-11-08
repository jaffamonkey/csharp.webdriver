using System;
using Selenium.core.browsers;

namespace Selenium.pages
{
    public class RegisterPage
    {
        private readonly IBrowser _browser;
        public string Title => _driver.Title;
        public string Source => _driver.PageSource;
        public string RunButton => _driver.FindElement(By.Id("run-button"));
        public string SaveButton => _driver.FindElement(By.ClassName("save-button"));
        public string ShareButton => _driver.FindElement(By.Id("Share"));
        public string ShareButton => _driver.FindElement(By.Id("ShareLink"));
        public string NewPackageField => _driver.FindElement(By.ClassName("new-package"));
        public string Username => _driver.FindElement(By.Id("Email"));
        public string Password => _driver.FindElement(By.Id("Password"));
        public string HideShowSideOptions => _driver.FindElement(By.ClassName("btn-sidebar-toggle"));
        public string GettingStartedButton => _driver.FindElement(By.ClassName("btn-default"));
        public string RunOutputValidator => _driver.FindElement(By.Id("output")).Text;
        public string PackageIncludedTick => _driver.FindElement(By.XPath("//*[@id=\"menu\"]/li[1]/ul/li[1]/a/i"));
        
        private const string URI = "https://dotnetfiddle.net";

        private IWebElement UsernameElement => _driver.FindElement(By.Id("username"));
        private IWebElement PasswordElement => _driver.FindElement(By.Id("password"));
        private IWebElement DobElement => _driver.FindElement(By.Id("dob"));
        private IWebElement PhoneElement => _driver.FindElement(By.Id("phone"));
        private IWebElement Create => _driver.FindElement(By.Id("create"));

        public void Navigate() => _driver.Navigate().GoToUrl(URI);


        public RegisterPage(IBrowser browser)
        {
            _browser = browser;
        }

        public void CreateAccount()
        {
            Console.WriteLine("Creating an account");
        }
    }
}
