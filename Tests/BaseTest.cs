using linnworksTest.Utils;
using NUnit.Framework;
using System;

namespace linnworksTest.Tests
{
    class BaseTest
    {
        [SetUp]
        public void startBrowser()
        {
            WebdriverFactory.OpenNewBrowser();
            WebdriverFactory.GetCurrentDriver().Manage().Window.Maximize();
        }

        [TearDown]
        public void closeBrowser()
        {
            WebdriverFactory.GetCurrentDriver().Close();
            WebdriverFactory.ClearUpDriver();
        }
    }
}
