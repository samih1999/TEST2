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
            By tour = By.Id("navbarDropdown");
            By maketour = By.XPath(".//*[@id='sami1']");
            By from = By.Name("from");
            By to = By.Name("to");
            By cardn = By.Name("nameoncard");
            By cardnum = By.Name("cardnum");
            By cvv = By.Name("cvv");
            By exp = By.Name("exp");
            By create = By.Name("create");
           
            By logout = By.Name("logout");
         


            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://localhost:44356/");



            webDriver.FindElement(bott).Click();
            webDriver.FindElement(UERNAM).SendKeys("ss@f");
            webDriver.FindElement(pass).SendKeys("Sjl/21l#");
            Thread.Sleep(1000);
            webDriver.FindElement(log).Click();
            Thread.Sleep(1000);
            webDriver.FindElement(tour).Click();
            Thread.Sleep(1000);
            webDriver.FindElement(maketour).Click();
            

            Thread.Sleep(1000);

            var selectElement = new SelectElement(webDriver.FindElement(By.Name("tourguide")));
            Thread.Sleep(1000);

            selectElement.SelectByIndex(2);

            Thread.Sleep(1000);

            var selec = new SelectElement(webDriver.FindElement(By.Name("p")));
            Thread.Sleep(1000);

            selec.SelectByIndex(1);

            Thread.Sleep(1000);

            webDriver.FindElement(from).SendKeys("01022022");
            Thread.Sleep(1000);
        

            webDriver.FindElement(to).SendKeys("02022022");
            Thread.Sleep(1000);

            webDriver.FindElement(cardn).SendKeys("sami khalifeh");
            Thread.Sleep(1000);
            webDriver.FindElement(cardnum).SendKeys("1234");
            Thread.Sleep(1000);
            webDriver.FindElement(cvv).SendKeys("1234");
            Thread.Sleep(1000);
            webDriver.FindElement(exp).SendKeys("01022020");
            Thread.Sleep(1000);
            webDriver.FindElement(create).Click();


            Thread.Sleep(1000);
            webDriver.FindElement(logout).Click();


            Thread.Sleep(1000);

            webDriver.Quit();


        }
    }
}
