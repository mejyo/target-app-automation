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
   
   class AddingItem
    {
        public AddingItem()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        #region 

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[2]/div[1]/ul[1]/li[3]/button[1]")]
        private IWebElement WomenTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='MegaMenu-item isActive']//a[@class='MegaMenu-link MegaMenu--NewLink'][normalize-space()='New Arrivals']")]
        private IWebElement NewArrival { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[1]/div[1]/div[1]/section[1]/main[1]/ul[1]/li[1]/div[1]/a[1]/figure[1]/img[1]")]
        private IWebElement Item { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/ul[1]/li[3]/a[1]/span[1]/span[2]")]
        private IWebElement ItemSize { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[4]/div[1]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/section[1]/form[1]/div[1]/div[1]/div[1]/button[1]/span[1]/div[2]/span[1]")]
        private IWebElement AddToBasket { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[4]/div[1]/div[1]/div[1]/div[1]/div[4]/a[1]")]
        private IWebElement ViewBasket { get; set; }

        #endregion
        internal void SelectItem()
        {

            
            WomenTab.Click();
            Thread.Sleep(2000);
            NewArrival.Click();
            Thread.Sleep(7000);

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