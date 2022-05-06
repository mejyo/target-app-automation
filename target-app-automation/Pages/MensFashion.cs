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
    class MensFashion
    {
        public MensFashion()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        #region 

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[2]/div[1]/ul[1]/li[4]/button[1]")]
        private IWebElement MenTab { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[2]/div[1]/ul[1]/li[4]/div[1]/div[1]/div[2]/div[3]/div[1]/ul[1]/li[1]/a[1]")]
        private IWebElement NewArrival { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[1]/div[1]/div[1]/section[1]/div[2]/span[1]/div[2]/div[1]/ul[1]/li[1]/div[1]/div[1]/a[1]/picture[1]/img[1]")]
        private IWebElement MensTop { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[1]/div[1]/div[1]/section[1]/main[1]/ul[1]/li[1]/div[1]/a[1]/figure[1]/img[1]")]
        private IWebElement Item { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/ul[1]/li[2]/a[1]")]
        private IWebElement ItemSize { get; set; }


        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/section[1]/form[1]/div[1]/div[1]/div[1]/button[1]/span[1]/div[2]/span[1]")]
        private IWebElement AddToBasket { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[1]/div[1]/div[1]/div[4]/a[1]")]
        private IWebElement ViewBasket { get; set; }

        #endregion
        internal void SelectItem()
        {


            MenTab.Click();
            Thread.Sleep(2000);
            NewArrival.Click();
            Thread.Sleep(3000);
            MensTop.Click();
            Thread.Sleep(3000);
            //GlobalDefinitions.driver.SwitchTo().Alert().Dismiss();
            //Thread.Sleep(2000);
            //Actions action = new Actions(GlobalDefinitions.driver);
            // action.MoveToElement(ItemSize).Perform();
            Item.Click();
            Thread.Sleep(2000);
            ItemSize.Click();
            Thread.Sleep(2000);
            AddToBasket.Click();
            Thread.Sleep(2000);
            ViewBasket.Click();
            Thread.Sleep(2000);
        }
    }
}