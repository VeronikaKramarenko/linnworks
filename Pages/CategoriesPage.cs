using linnworksTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Pages
{
    class CategoriesPage : MainPage
    {
        public CategoriesPage() : base("Categories page", By.TagName("app-fetch-category")) { }

        public BaseElement GetCreateNewCategoryButton()
        {
            return new BaseElement("Create new category", By.XPath("//a[@href='/add-category']"));
        }

        public BaseElement GetCategoryRowByName(string Name)
        {
            return new BaseElement("Categories table", 
                By.XPath(String.Format("//app-fetch-category//table//tr[./td[contains(.,'{0}')]]", Name)));
        }

        public BaseElement GetEditButtonByCategoryName(string Name)
        {
            return new BaseElement("Edit category button",
                By.XPath(String.Format("//app-fetch-category//table//tr[./td[contains(.,'{0}')]]//a[contains(@href,'category/edit')]", Name)));
        }

        public BaseElement GetDeleteButtonByCategoryName(string Name)
        {
            return new BaseElement("Delete category button",
                By.XPath(String.Format("//app-fetch-category//table//tr[./td[contains(.,'{0}')]]//a[contains(text(),'Delete')]", Name)));
        }
    }
}
