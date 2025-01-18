using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace HealthCareWebsite
{
    [TestClass]
    public class TestExecution 
    {


        [TestMethod]
        
        public void TestCase001()

        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("btn-make-appointment")).Click();
            string msg = driver.FindElement(By.XPath("//p[@class='lead']")).Text;
            Assert.AreEqual("Please login to make appointment.", msg);
            //This code is optional just to print the assertion passed msg on console
            if (msg == "Please login to make appointment.")
            {
                Console.WriteLine("Validation message displayed correctly. Test Passed!");
            }
            else
            {
                Console.WriteLine("Validation message not displayed correctly. Test Failed!");
            }
            driver.Close();
        }
        [TestMethod, TestCategory("LoginWithValidDetails"), TestCategory("Positive")]

        public void TestCase002()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("menu-toggle")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[normalize-space()='Login']")).Click();
            Thread.Sleep(1000);
            
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.XPath("//button[@id='btn-login']")).Click();
            driver.Close();
        }
        [TestMethod, TestCategory("LoginWithInValidDetails"), TestCategory("Negative")]

        public void TestCase003()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("menu-toggle")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[normalize-space()='Login']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("123");
            driver.FindElement(By.XPath("//button[@id='btn-login']")).Click();
            string errorMessage = driver.FindElement(By.XPath("//p[@class='lead text-danger']")).Text;
            Assert.AreEqual("Login failed! Please ensure the username and password are valid.", errorMessage);
            if (errorMessage == "Login failed! Please ensure the username and password are valid.")
            {
                Console.WriteLine("Validation message displayed correctly. Test Passed!");
            }
            else
            {
                Console.WriteLine("Validation message not displayed correctly. Test Failed!");
            }
            driver.Close();
        }

        [TestMethod, TestCategory("AppointmentBooking"), TestCategory("Positive")]

        public void TestCase004()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("menu-toggle")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[normalize-space()='Login']")).Click();
            Thread.Sleep(1000);
            string msg1 = driver.FindElement(By.XPath("//p[@class='lead']")).Text;
            Assert.AreEqual("Please login to make appointment.", msg1);
            //This code is optional just to print the assertion passed msg on console
            if (msg1 == "Please login to make appointment.")
            {
                Console.WriteLine("Validation message displayed correctly. Test Passed!");
            }
            else
            {
                Console.WriteLine("Validation message not displayed correctly. Test Failed!");
            }
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.XPath("//button[@id='btn-login']")).Click();
            IWebElement dropdown = driver.FindElement(By.Id("combo_facility"));
            SelectElement select = new SelectElement(dropdown);
            dropdown.Click();
            dropdown.FindElement(By.XPath("//option[@value='Hongkong CURA Healthcare Center']")).Click();
            driver.FindElement(By.Id("chk_hospotal_readmission")).Click();
            driver.FindElement(By.Id("radio_program_medicaid")).Click();
            driver.FindElement(By.Id("txt_visit_date")).SendKeys("01/18/2025");
            driver.FindElement(By.Id("txt_comment")).SendKeys("I want to book My appointment");
            driver.FindElement(By.Id("btn-book-appointment")).Click();
            string appointentConfirmationMsg = driver.FindElement(By.XPath("//h2[normalize-space()='Appointment Confirmation']")).Text;
            Assert.AreEqual("Appointment Confirmation", appointentConfirmationMsg);
            //This code is optional just to print the assertion passed msg on console
            if (appointentConfirmationMsg == "Appointment Confirmation")
            {
                Console.WriteLine("Confirmation message displayed correctly. Test Passed!");
            }
            else
            {
                Console.WriteLine("Confirmation message is not displayed correctly. Test Failed!");
            }
            driver.Close();


        }
        //this is a negative case that if you dont select the date you will not be able to book appointment but no id or xpath given for that error that's this case will not pass
        //driver.FindElement(By.Id("txt_visit_date")).SendKeys("01/18/2025");
        /*[TestMethod, TestCategory("AppointmentBooking"), TestCategory("Negative")]

        public void TestCase005()
        {
           
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("menu-toggle")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[normalize-space()='Login']")).Click();
            Thread.Sleep(1000);
            string msg1 = driver.FindElement(By.XPath("//p[@class='lead']")).Text;
            Assert.AreEqual("Please login to make appointment.", msg1);
            //This code is optional just to print the assertion passed msg on console
            if (msg1 == "Please login to make appointment.")
            {
                Console.WriteLine("Validation message displayed correctly. Test Passed!");
            }
            else
            {
                Console.WriteLine("Validation message not displayed correctly. Test Failed!");
            }
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.XPath("//button[@id='btn-login']")).Click();
            IWebElement dropdown = driver.FindElement(By.Id("combo_facility"));
            SelectElement select = new SelectElement(dropdown);
            dropdown.Click();
            dropdown.FindElement(By.XPath("//option[@value='Hongkong CURA Healthcare Center']")).Click();
            driver.FindElement(By.Id("chk_hospotal_readmission")).Click();
            driver.FindElement(By.Id("radio_program_medicaid")).Click();
            //driver.FindElement(By.Id("txt_visit_date")).SendKeys("01/18/2025");
            driver.FindElement(By.Id("txt_comment")).SendKeys("I want to book My appointment");
            driver.FindElement(By.Id("btn-book-appointment")).Click();

            string appointentConfirmationMsg = driver.FindElement(By.XPath("//h2[normalize-space()='Appointment Confirmation']")).Text;
            Assert.AreEqual("Appointment Confirmation", appointentConfirmationMsg);
            //This code is optional just to print the assertion passed msg on console
            if (appointentConfirmationMsg == "Appointment Confirmation")
            {
                Console.WriteLine("Confirmation message displayed correctly. Test Passed!");
            }
            else
            {
                Console.WriteLine("Confirmation message is not displayed correctly. Test Failed!");
            }
            driver.Close();


        }*/
        [TestMethod]
        public void TestCase006()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("menu-toggle")).Click();
            driver.FindElement(By.XPath("//a[normalize-space()='Login']")).Click();
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.XPath("//button[@id='btn-login']")).Click();
            driver.FindElement(By.Id("menu-toggle")).Click();
            driver.FindElement(By.XPath("//a[normalize-space()='History']")).Click();
            Thread.Sleep(1000);
            string checkHistory = driver.FindElement(By.XPath("//h2[normalize-space()='History']")).Text;
            Assert.AreEqual("History", checkHistory);
            //This code is optional just to print the assertion passed msg on console
            if (checkHistory == "History")
            {
                Console.WriteLine("Successfully landed on History Page. Test Passed!");
            }
            else
            {
                Console.WriteLine("Successfully landed on History Page. Test Failed!");
            }
            driver.Close();
        }


        
    }
}
