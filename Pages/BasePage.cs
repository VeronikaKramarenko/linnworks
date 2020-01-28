using linnworksTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Pages
{
    class BasePage
    {
        private string Name;
        private By Locator;
        protected BasePage(string Name, By Locator)
        {
            this.Name = Name;
            this.Locator = Locator;
            new BaseElement(Name, Locator).WaitForElementToBePresent().AssertExists();
        }

    }
}
