using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace DEMOQAPRACTICEFORM
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod001()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/index.php";
            //string url = driver.Url = "https://adactinhotelapp.com/Register.php";
            //Assert.AreEqual("https://adactinhotelapp.com/Register.php", url);
            driver.FindElement(By.CssSelector("#login_form > table > tbody > tr:nth-child(7) > td > a")).Click();
            driver.FindElement(By.Id("username")).SendKeys("Aarish999");
            driver.FindElement(By.Id("password")).SendKeys("12345678");
            driver.FindElement(By.CssSelector("#re_password")).SendKeys("12345678");
            driver.FindElement(By.Id("full_name")).SendKeys("AarishIrfan");
            driver.FindElement(By.Id("email_add")).SendKeys("aarishirfancs@gmail.com");
            Thread.Sleep(10000);
            driver.FindElement(By.Id("tnc_box")).Click();
            driver.FindElement(By.Id("Submit")).Click();
            driver.FindElement(By.CssSelector("body > table.content > tbody > tr > td:nth-child(1) > table > tbody > tr > td > a")).Click();
            driver.FindElement(By.Id("username")).SendKeys("AmirImam");
            driver.FindElement(By.Id("password")).SendKeys("AmirImam");
            driver.FindElement(By.Id("login")).Click();
            string ExpectedText = driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", ExpectedText);
            driver.Close();
        }

        [TestMethod]
        public void TestMethod002()
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/";
            driver.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(2) > div > div.avatar.mx-auto.white > svg")).Click();
            driver.FindElement(By.CssSelector("#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(2) > div")).Click();
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("Aarish");
            driver.FindElement(By.CssSelector("#lastName")).SendKeys("Irfan");
            driver.FindElement(By.CssSelector("#userEmail")).SendKeys("aarishirfancs@gmail.com");
            driver.FindElement(By.CssSelector("#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label")).Click();
            driver.FindElement(By.XPath("//*[@id='userNumber']")).SendKeys("03330263194");
            driver.FindElement(By.XPath("//*[@id='userNumber']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//*[@id='dateOfBirthInput']")).SendKeys("03 July 1998");
            driver.FindElement(By.XPath("//*[@id='dateOfBirthInput']")).SendKeys(Keys.Enter);
            js.ExecuteScript("0,400");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("subjectsInput")).SendKeys("Physics");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Enter);
            driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-2']")).Click();
            driver.FindElement(By.Id("uploadPicture")).SendKeys("D:\\Pictures\\mypicture.jpg");
            driver.FindElement(By.Id("currentAddress")).SendKeys("Karachi, Pakistan");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Noida");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("submit")).Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMethod003()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/";
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.FindElement(By.CssSelector("#app > div > div > div.home-body > div > div:nth-child(1) > div")).Click();
            driver.FindElement(By.CssSelector("#item-0 > span")).Click();
            driver.FindElement(By.Id("userName")).SendKeys("aarishIrfan");
            driver.FindElement(By.Id("userEmail")).SendKeys("aarishirfancs@gmail.com");
            driver.FindElement(By.Id("currentAddress")).SendKeys("Saadi Gardens");
            driver.FindElement(By.Id("permanentAddress")).SendKeys("Saadi Gardens");
            driver.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("item-1")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.FindElement(By.CssSelector("#tree-node > ol > li > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > span > button > svg")).Click();
            js.ExecuteScript("window.scrollBy(0,400)", "");
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > ol > li:nth-child(1) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > ol > li:nth-child(2) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li.rct-node.rct-node-parent.rct-node-collapsed > span > button > svg")).Click();
            js.ExecuteScript("window.scrollBy(0,-400)", "");
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > ol > li:nth-child(2) > span > button")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > ol > li.rct-node.rct-node-parent.rct-node-expanded > span > button")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > span > button > svg")).Click();
            driver.FindElement(By.CssSelector("#tree-node > ol > li > span > button")).Click();
            driver.FindElement(By.Id("item-2")).Click();
            driver.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > div:nth-child(2) > label")).Click();
            driver.FindElement(By.CssSelector("#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(4) > span > div > div.header-text")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[4]/div/ul/li[9]")).Click();
            //Thread.Sleep(5000);
            driver.Close();
        }

        [TestMethod]
        public void WidGet()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/select-menu";
            driver.FindElement(By.Id("react-select-2-input")).SendKeys("Group 1, option 1");
            driver.FindElement(By.Id("react-select-2-input")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("react-select-2-input")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("react-select-3-input")).SendKeys("Dr.");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Enter);
            var element = driver.FindElement(By.Id("oldSelectMenu"));
            var selectdropdown = new SelectElement(element);
            selectdropdown.SelectByValue("4");
            driver.FindElement(By.Id("oldSelectMenu")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Green");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Tab);
            var element2 = driver.FindElement(By.Id("cars"));
            var selectdropdown2 = new SelectElement(element2);
            selectdropdown2.SelectByValue("volvo");
        }
    }
}
