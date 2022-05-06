using MarsFramework.Pages;
using NUnit.Framework;
using System;
using Target_Appliaction;

namespace ConsoleApp1
{
   public static class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : MarsFramework.Global.Base
        {

            [Test, Order(1)]
            public void LoginSteps()
            {


                SignIn signInlObj = new SignIn();

                signInlObj.LoginSteps();
            }

            [Test, Order(2)]
            public void SelectingItem()
            {


                AddingItem  addingItemlObj = new AddingItem();

                addingItemlObj.SelectItem();
            }
            [Test, Order(3)]
            public void SelectingWomensClothing()
            {


                WomenClothing womenClothinglObj = new WomenClothing();

                womenClothinglObj.Clothing();
            }

            [Test, Order(4)]
            public void SelectingMensClothing()
            {


                MensFashion mensFashionObj = new MensFashion();

                mensFashionObj.SelectItem();
            }
        }
    }
}
