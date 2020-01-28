using linnworksTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace linnworksTest.Pages
{
    class CreateCategoryPage : MainPage
    {
        public CreateCategoryPage() : base("Create category page", By.XPath("//app-add-category[./h1[text()='Create']]//input[@ng-reflect-name='categoryName']"))
        {
        }

        public BaseElement GetCategotyNameTextField()
        {
            return new BaseElement("Category name textfield", By.XPath("//app-add-category[./h1[text()='Create']]//input[@ng-reflect-name='categoryName']"));
        }
        
        public BaseElement GetSubmitButton()
        {
            return new BaseElement("Submit button", By.XPath("//app-add-category[./h1[text()='Create']]//button[@type='submit']"));
        }
        
        public BaseElement GetRequiredFildMissingMessage()
        {
            return new BaseElement("Name is required message", By.XPath("//span[@class='text-danger' and contains(text(),'Name is required')]"));
        }
        

    }
}
