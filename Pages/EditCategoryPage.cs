using linnworksTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Pages
{
    class EditCategoryPage : MainPage
    {
        public EditCategoryPage() : base("Edit category page", By.XPath("//app-add-category[./h1[text()='Edit']]//input[@ng-reflect-name='categoryName']"))
        {
        }

        public BaseElement GetCategotyNameTextField()
        {
            return new BaseElement("Category name textfield", By.XPath("//app-add-category[./h1[text()='Edit']]//input[@ng-reflect-name='categoryName']"));
        }

        public BaseElement GetSubmitButton()
        {
            return new BaseElement("Submit button", By.XPath("//app-add-category[./h1[text()='Edit']]//button[@type='submit']"));
        }
    }
}
