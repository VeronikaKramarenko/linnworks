using linnworksTest.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace linnworksTest.Elements
{
    class BaseElement
    {
        private const int Timeout = 5;
        private string Name;
        private By Locator;

        public BaseElement(string Name, By Locator)
        {
            this.Name = Name;
            this.Locator = Locator;
        }

        public IWebElement GetWebElement()
        {
            return WebdriverFactory.GetCurrentDriver().FindElement(Locator);
        }

        public BaseElement WaitForElementToBePresent()
        {
            var wait = new WebDriverWait(WebdriverFactory.GetCurrentDriver(), TimeSpan.FromSeconds(Timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Locator));
            return this;
        }

        public BaseElement WaitForElementToBeAbsent()
        {
            var wait = new WebDriverWait(WebdriverFactory.GetCurrentDriver(), TimeSpan.FromSeconds(Timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(Locator));
            return this;
        }
        
        public BaseElement WaitForElementToBeClickable()
        {
            var wait = new WebDriverWait(WebdriverFactory.GetCurrentDriver(), TimeSpan.FromSeconds(Timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Locator));
            return this;
        }

        public BaseElement AssertExists()
        {
            Assert.IsTrue(GetWebElement().Displayed);
            return this;
        }
        public BaseElement AssertAbsent()
        {
            IList<IWebElement> list = WebdriverFactory.GetCurrentDriver().FindElements(Locator);
            if (list.Count > 0)
            {
                Assert.IsFalse(list[0].Displayed);
            } 
            return this;
        }

        public BaseElement AssertDisabled()
        {
            Assert.IsFalse(GetWebElement().Enabled);
            return this;
        }

        public void Click()
        {
            WaitForElementToBePresent();
            WaitForElementToBeClickable();
            GetWebElement().Click();
        }

        public void SetValue(string value)
        {
            GetWebElement().Clear();
            GetWebElement().SendKeys(value);
        }

    }
}
