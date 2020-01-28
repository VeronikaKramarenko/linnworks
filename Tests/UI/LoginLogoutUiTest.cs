using linnworksTest.Pages;
using linnworksTest.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Tests.UI
{
    
    class LoginLogoutUiTest : BaseTest
    {
        [Test]
        public void VerifyLoginAndLogout()
        {
            LoginHelper.Login();
            new CategoriesPage().GetLogoutButton().Click();

            MainPage mainPage = new MainPage();
            mainPage.GetLogoutButton().WaitForElementToBeAbsent().AssertAbsent();
            mainPage.GetLoginButton().Click();

            new LoginPage().GetTokenTextField().WaitForElementToBePresent().AssertExists();
        }
    }
}
