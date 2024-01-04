using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace FocusToDo
{
    public class FocusToDoTests
    {
        
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        private const string appIdentifier = "52299SuperElement.119436511DDC8_792yctbvabkar!App";
        private WindowsDriver<WindowsElement> driver;
        private AppiumOptions options;



        [SetUp]
        public void Setup()
        {
            this.options = new AppiumOptions();
            options.AddAdditionalCapability("app", appIdentifier);
            this.driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer), options);
            System.Threading.Thread.Sleep(5000);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}