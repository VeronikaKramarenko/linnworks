using linnworksTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Pages
{
    class LoginPage : MainPage
    {

        public LoginPage() : base("Login page", By.Id("token"))
        {
        }

        public BaseElement GetTokenTextField()
        {
            return new BaseElement("Token text field", By.Id("token"));
        }

        public BaseElement GetLoginSubmitButton()
        {
            return new BaseElement("Login button", By.XPath("//button[@type='submit']"));
        }
        public BaseElement GetInvalidTokenMessage()
        {
            return new BaseElement("Invalid token message", By.XPath("//div[@class='alert alert-danger' and contains(.,'Invalid token.')]"));
        }
    }
}
