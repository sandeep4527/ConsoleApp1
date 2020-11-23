using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace ConsoleApp1
{
    [Binding]
    public sealed class StepDefinition1
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Url for Taiga Web App")]
        public void GivenUrlForTaigaWebApp()
        {
            driver.Navigate().GoToUrl("https://taiga.ensurity.com/");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
        }

        [Given(@"Enter User name and Password")]
        public void GivenEnterUserNameAndPassword()
        {
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Name("username")).SendKeys("sandeep.a@ensurity.com");
            driver.FindElement(By.Name("password")).SendKeys("Pass@word1");
        }

        [When(@"hit on the login button")]
        public void WhenHitOnTheLoginButton()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/form/fieldset[3]/button")).Submit();
        }

        [Then(@"the result window should be logged in page")]
        public void ThenTheResultWindowShouldBeLoggedInPage()
        {
            Thread.Sleep(2000);
           var text= driver.FindElement(By.XPath("/html/body/div[1]/nav/div[2]/div[3]/a")).Text;
            Assert.AreEqual("Sandeep Aaleti", text);
            
        }


    }
}
