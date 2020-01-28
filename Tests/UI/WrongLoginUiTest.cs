using linnworksTest.Pages;
using linnworksTest.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Tests.UI
{
    class WrongLoginUiTest : BaseTest
    {
        [Test]
        public void verifyLoginWithWrongToken()
        {
            string wrongToken = "wrong";
            WebdriverFactory.GetCurrentDriver().Url = WebdriverFactory.ApplicationUrl;

            new MainPage().GetLoginButton().Click();
            LoginPage loginPage = new LoginPage();
            loginPage.GetLoginSubmitButton().WaitForElementToBePresent().AssertDisabled();
            loginPage.GetTokenTextField().SetValue(wrongToken);
            loginPage.GetLoginSubmitButton().Click();

            loginPage.GetInvalidTokenMessage().WaitForElementToBePresent().AssertExists();
        }
    }
}
