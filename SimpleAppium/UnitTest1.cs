using System;
using Xunit;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;

namespace SimpleAppium
{
    public class UnitTest1
    {
        AppiumDriver<IWebElement> driver;

        //public IWebDriver driver;
    
        public void Test1()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "iOS");
            capabilities.SetCapability("platformVersion", "10.0");
            capabilities.SetCapability("deviceName", "iPhone Simulator");
            capabilities.SetCapability("udid", "03514C77-C82A-51ED-969C-83524BEA830E");
            capabilities.SetCapability("app", "/Users/kalyani/Desktop/GrowthPowerhouse.app");
            //Connecting to Appium Server
            //driver = new RemoteWebDriver (new Uri("http://127.0.0:4723/wd/hub"), capabilities);
            driver = new IOSDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), capabilities);

            NUnit.Framework.Assert.IsNotNull(driver.Context);

        }


    }
}
