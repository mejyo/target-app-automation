using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Target_Appliaction
{
    class WomenClothing
    {
 
        public WomenClothing()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        #region 

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[2]/div[1]/ul[1]/li[3]/button[1]")]
        private IWebElement WomenTab { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[2]/div[1]/ul[1]/li[3]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[4]/a[1]")]
        private IWebElement Denim { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[1]/div[1]/div[1]/section[1]/div[2]/span[1]/div[2]/div[1]/ul[1]/li[1]/div[1]/div[1]/a[1]/picture[1]/img[1]")]
        private IWebElement SkinnyJeans { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[1]/div[1]/div[1]/section[1]/main[1]/ul[1]/li[1]/div[1]/a[1]/figure[1]/img[1]")]
        private IWebElement SelectJeans { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/ul[1]/li[3]/a[1]/span[1]/span[2]")]
        private IWebElement JeansSize { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/section[1]/form[1]/div[1]/div[1]/div[1]/button[1]/span[1]/div[2]/span[1]")]
        private IWebElement AddingToBasket { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[1]/div[1]/div[1]/div[4]/a[1]")]
        private IWebElement ViewBasket { get; set; }

        #endregion
        internal void Clothing()
        {


            WomenTab.Click();
            Thread.Sleep(2000);
            Denim.Click();
            Thread.Sleep(7000);

          
        
            
            Thread.Sleep(2000);
            SkinnyJeans.Click();
            Thread.Sleep(2000);
            SelectJeans.Click();
            Thread.Sleep(2000);
            JeansSize.Click();
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(GlobalDefinitions.driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/ html[1] /body[1] / div[3] / div[4] / div[1] / div[3] / div[2] / div[1] / div[2] / div[1] / div[1] / div[2] / div[1] / section[1] / form[1] / div[1] / div[1] / div[1] / button[1] / span[1] / div[2] / span[1]")));

            Actions action = new Actions(GlobalDefinitions.driver);
            action.MoveToElement(element).Perform();
            AddingToBasket.Click();
            Thread.Sleep(2000);
            ViewBasket.Click();
            Thread.Sleep(2000);
        }
    }
}