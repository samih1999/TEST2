using Docker.DotNet.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            By bott = By.Name("LOGIN");
            By UERNAM = By.Id("Input_Email");
            By pass = By.Id("Input_Password");
            By log = By.Name("login");
           //By tour = By.Id("navbarDropdown");
           // By maketour = By.XPath(".//*[@id='sami1']");


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://localhost:44356/");

            SelectElement oSelect = new SelectElement(webDriver.FindElement(By.Id("navbarDropdown")));

            oSelect.SelectByValue("Create Tour");




            webDriver.FindElement(bott).Click();
            webDriver.FindElement(UERNAM).SendKeys("ss@f");
            webDriver.FindElement(pass).SendKeys("Sjl/21l#");
            //Thread.Sleep(5000);
            webDriver.FindElement(log).Click();
            //webDriver.FindElement(tour).Click();
            //webDriver.FindElement(maketour).Click();


//webDriver.Quit();


        }
    }
}
