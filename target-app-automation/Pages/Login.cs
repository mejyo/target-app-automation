using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Icon
        [FindsBy(How = How.XPath, Using = "(//button[@class='MainNavigation-link MainNavigation-link--account u-notButton'])[2]")]
        private IWebElement SignIntab { get; set; }

        // Click on login
        [FindsBy(How = How.CssSelector, Using = ".u-marginAll0.siteDrawer-logIn")]
        private IWebElement Login { get; set; }

        //Finding the Email Field
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[8]/div[1]/div[2]/form[1]/div[1]/div[2]/div[1]/label[1]")]
        private IWebElement Email { get; set; }

        //Finding the Password
        [FindsBy(How = How.XPath, Using = "//input[@id='LoginSignup.j_password']")]
        private IWebElement Password { get; set; }

        //Click on login button
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[8]/div[1]/div[2]/form[1]/div[1]/button[1]")]
        private IWebElement LoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[aria-label='Close Drawer']")]
        private IWebElement CloseButton { get; set; }

      

        #endregion
        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();



            Thread.Sleep(11000);
            SignIntab.Click();

            Thread.Sleep(3000);

            Login.Click();
            Thread.Sleep(2000);
            Email.SendKeys("hi.its.venky@gmail.com");
            Thread.Sleep(2000);
            Password.SendKeys("Im@target6");
            Thread.Sleep(2000);
            LoginButton.Click();
            Thread.Sleep(3000);
            CloseButton.Click();
           
          
        }
    }
}