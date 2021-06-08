using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ScripLab_1
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }

        [Test]
        public void Test1()
        {
            IWebElement login1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            login1.Click();
            login1.SendKeys("user");

            IWebElement login2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            login2.Click();
            login2.SendKeys("user");

            IWebElement loginButton = driver.FindElement(By.XPath("//form/input"));
            loginButton.Click();

           
            IWebElement login3 = driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));

            
        }
        
        [Test]
        public void Test2()
        {
            IWebElement login1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            IWebElement login2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            IWebElement loginButton = driver.FindElement(By.XPath("//form/input"));

            login1.Click();
            login1.SendKeys("user");
            login2.Click();
            login2.SendKeys("user");
            loginButton.Click();

            IWebElement ButtonProducts = driver.FindElement(By.XPath("//a[contains(.,'Product')]"));
            ButtonProducts.Click();

            IWebElement CreatProduct = driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
            CreatProduct.Click();

            IWebElement Name = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            Name.Click();
            Name.SendKeys("product1");

            IWebElement Category = driver.FindElement(By.XPath("//select[@id='CategoryId']"));
            Category.Click();
            // Тут должен быть select

            IWebElement SupplierId = driver.FindElement(By.XPath("//select[@id='SupplierId']"));
            SupplierId.Click();
            // Тут снова  должен быть select

            
            IWebElement UnitPrice = driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            UnitPrice.Click();
            UnitPrice.SendKeys("1");

            IWebElement QuantityPerUnit = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            QuantityPerUnit.Click();
            QuantityPerUnit.SendKeys("2");

            IWebElement UnitsInStock = driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            UnitsInStock.Click();
            UnitsInStock.SendKeys("3");

            IWebElement UnitsOnOrder = driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            UnitsOnOrder.Click();
            UnitsOnOrder.SendKeys("4");

            IWebElement ReorderLevel = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            ReorderLevel.Click();
            ReorderLevel.SendKeys("5");
            
            
            IWebElement ButtonCreat = driver.FindElement(By.XPath("//form/input"));
            ButtonCreat.Click();
           
            
            IWebElement editing = driver.FindElement(By.XPath("//h2[contains(.,'editing')]"));
            Assert.IsFalse(editing.Size.Equals(10));

        }

        [Test]
        public void Test3()
        {
            IWebElement login1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            IWebElement login2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            IWebElement loginButton = driver.FindElement(By.XPath("//form/input"));
           

            login1.Click();
            login1.SendKeys("user");
            login2.Click();
            login2.SendKeys("user");
            loginButton.Click();
           
            
            IWebElement ButtonProducts = driver.FindElement(By.XPath("//a[contains(.,'Product')]"));
            ButtonProducts.Click();


           

            IWebElement Product1 = driver.FindElement(By.XPath("//a[contains(text(),'product1')]"));
            Product1.Click();


            IWebElement UnitPrice = driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            IWebElement QuantityPerUnit = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            IWebElement UnitsInStock = driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            IWebElement UnitsOnOrder = driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            IWebElement ReorderLevel = driver.FindElement(By.XPath("//input[@id='ProductName']"));

            Assert.AreEqual("1", UnitPrice.Value);
            Assert.AreEqual("2", QuantityPerUnit.Value);
            Assert.AreEqual("3", UnitsInStock.Value);
            Assert.AreEqual("4", UnitsOnOrder.Value);
            Assert.AreEqual("5", ReorderLevel.Value);


        }


        [Test]
        public void Test4()
        {
            IWebElement login1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            IWebElement login2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            IWebElement loginButton = driver.FindElement(By.XPath("//form/input"));


            login1.Click();
            login1.SendKeys("user");
            login2.Click();
            login2.SendKeys("user");
            loginButton.Click();


            IWebElement ButtonProducts = driver.FindElement(By.XPath("//a[contains(.,'Product')]"));
            ButtonProducts.Click();

            IWebElement Remove = driver.FindElement(By.XPath("//tr/td[a='product1']/following-sibling::td[10]"));
            Remove.Click();


        }


        [Test]
        public void Test5()
        {
            IWebElement login1 = driver.FindElement(By.XPath("//input[@id='Name']"));
            IWebElement login2 = driver.FindElement(By.XPath("//input[@id='Password']"));
            IWebElement loginButton = driver.FindElement(By.XPath("//form/input"));


            login1.Click();
            login1.SendKeys("user");
            login2.Click();
            login2.SendKeys("user");
            loginButton.Click();

           IWebElement Logout = driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
            Logout.Click();

            IWebElement Img1 = driver.FindElement(By.XPath("//img"));



        }

        [TearDown]
     public void TearDown ()
       {
         driver.Quit();

     }



    }
}