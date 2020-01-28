using linnworksTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Pages
{
    class MainPage : BasePage
    {
        public MainPage() : base("Main page", By.XPath("//a[@class='navbar-brand']"))
        {

        }

        public MainPage(string Name, By Locator) : base(Name, Locator)
        {

        }

        public BaseElement GetHomeButton()
        {
            return new BaseElement("Home button", By.XPath("//ul[@class='nav navbar-nav']//a[@href='/']"));
        }

        public BaseElement GetLoginButton()
        {
            return new BaseElement("Login button", By.XPath("//ul[@class='nav navbar-nav']//a[@href='/login']"));
        }

        public BaseElement GetCategoriesButton()
        {
            return new BaseElement("Categories button", By.XPath("//ul[@class='nav navbar-nav']//a[@href='/fetch-category']"));
        }

        public BaseElement GetLogoutButton()
        {
            return new BaseElement("Categories button", By.XPath("//ul[@class='nav navbar-nav']//a[@href='/logout']"));
        }
    }
}
