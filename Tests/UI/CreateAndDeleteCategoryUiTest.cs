using linnworksTest.Pages;
using linnworksTest.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Tests.UI
{
    class CreateAndDeleteCategoryUiTest : BaseTest
    {
        [Test]
        public void VerifyCreationAndDeletionOfCategory()
        {
            string categoryName = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
            LoginHelper.Login();

            new MainPage().GetCategoriesButton().Click();
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.GetCreateNewCategoryButton().Click();

            CreateCategoryPage createCategoryPage = new CreateCategoryPage();
            createCategoryPage.GetCategotyNameTextField().SetValue(categoryName);
            createCategoryPage.GetSubmitButton().Click();
            categoriesPage = new CategoriesPage();
            categoriesPage.GetCategoryRowByName(categoryName).WaitForElementToBePresent().AssertExists();

            categoriesPage.GetDeleteButtonByCategoryName(categoryName).Click();
            WebdriverFactory.GetCurrentDriver().SwitchTo().Alert().Accept();

            categoriesPage.GetCategoryRowByName(categoryName).WaitForElementToBeAbsent().AssertAbsent();
        }

    }
}
