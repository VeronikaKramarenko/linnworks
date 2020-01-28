using linnworksTest.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Utils
{
    class LoginHelper
    {
        public static void Login()
        {
            WebdriverFactory.GetCurrentDriver().Url = WebdriverFactory.ApplicationUrl;

            new MainPage().GetLoginButton().Click();
            LoginPage loginPage = new LoginPage();
            loginPage.GetTokenTextField().SetValue(WebdriverFactory.GetToken());
            loginPage.GetLoginSubmitButton().Click();

            new MainPage().GetLogoutButton().WaitForElementToBePresent().AssertExists();
        }
    }
}
