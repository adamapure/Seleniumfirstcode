using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Seleniumfirstcode
{
    public class Tests:Driverhelper
    {
      

        public object ContentPlaceHolder1_Meal { get; private set; }

        [SetUp]
        public void Setup()
        { 
          Console.WriteLine("Chetu");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");


            
            PublicCustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","Almond");

            Assert.Pass();


        }
    }
}