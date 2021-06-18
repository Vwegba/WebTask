using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebTask
{
    class Task
    {
        public void Project()
        {
            //launch chrome
            IWebDriver driver = new ChromeDriver();
            //go to the url/webaite
            driver.Navigate().GoToUrl("http://maltapark.com");
            //click on all classified
            driver.FindElement(By.Id("searchselector")).Click();
            //click on book
            driver.FindElement(By.XPath("//div[@data-value='5']")).Click();
            //type in Computer in the search box
            driver.FindElement(By.Id("search")).SendKeys("Computer");
            //driver.FindElement(By.Id("search")).SendKeys(Keys.Enter); this can also simulates pressing the ENTER KEY
            driver.FindElement(By.XPath("//button[@class = 'btn btn-search']")).Click();// click on the search button

            //gets price and saves into the variable
            string price= driver.FindElement(By.CssSelector("#page-content-left > div.ui.items.listings.gridview.featured.clearfix.unstackable > div.item.featured.e3.e2 > div.content > div.meta > span > span")).Text;
            //gets description and saves into the variable
            string description = driver.FindElement(By.CssSelector("#page-content-left > div.ui.items.listings.gridview.featured.clearfix.unstackable > div.item.featured.e3.e2 > div.content > div.description > p")).Text;
            Console.WriteLine("the price is " + price + " and the description is " + description);

            string price2 = driver.FindElement(By.CssSelector("#page-content-left > div.ui.items.listings.classifieds.clearfix.unstackable > div:nth-child(1) > div.content > div.meta > span > span > span")).Text;
            Console.WriteLine("price of second item is " +price2);


        }
        static void Main(string[] args)
        {
            Task runTask = new Task();
            runTask.Project();
        }
    }
}
