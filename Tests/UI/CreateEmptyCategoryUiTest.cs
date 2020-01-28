using linnworksTest.Pages;
using linnworksTest.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Tests.UI
{
    class CreateEmptyCategoryUiTest : BaseTest
    {
        [Test]
        public void VerifyCategoryCreationWithEmptyName()
        {
            LoginHelper.Login();

            new MainPage().GetCategoriesButton().Click();
            CategoriesPage categoriesPage = new CategoriesPage();
            categoriesPage.GetCreateNewCategoryButton().Click();

            CreateCategoryPage createCategoryPage = new CreateCategoryPage();
            createCategoryPage.GetSubmitButton().Click();
            createCategoryPage.GetRequiredFildMissingMessage().WaitForElementToBePresent().AssertExists();

        }

    }
}
