using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    class Program
    {
        static void Main(string[] args)
        {

            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "https://magento.com/";

            //String url=driver.Url;
            //Console.WriteLine("Current Url is "+url);

            //Console.WriteLine("Current Title is "+ driver.Title);

            //Console.WriteLine("***********************************");

            //Console.WriteLine(driver.PageSource);

            //thread.sleep
            // IWebDriver driver = new FirefoxDriver();
            // driver.Url = "https://magento.com/";

            //IWebElement myAccount = driver.FindElement(By.LinkText("MY ACCOUNT"));
            // myAccount.Click();

            // Thread.Sleep(5000);//5s

            //IWebElement userName= driver.FindElement(By.Id("email"));
            // userName.SendKeys("balajidinakaran1@gmail.com");

            // IWebElement password= driver.FindElement(By.Name("login[password]"));
            // password.SendKeys("Welcome123");

            // IWebElement login= driver.FindElement(By.Id("send2"));
            // login.Click();

            // Thread.Sleep(5000);

            // IWebElement logout= driver.FindElement(By.LinkText("Log Out"));
            // logout.Click();


            //IWebDriver driver = new FirefoxDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Url = "https://magento.com/";

            //IWebElement myAccount = driver.FindElement(By.LinkText("MY ACCOUNT"));
            //myAccount.Click();

            //IWebElement userName = driver.FindElement(By.Id("email"));
            //userName.SendKeys("balajidinakaran1@gmail.com");

            //IWebElement password = driver.FindElement(By.Name("login[password]"));
            //password.SendKeys("Welcome123");

            //IWebElement login = driver.FindElement(By.Id("send2"));
            //login.Click();

            //IWebElement logout = driver.FindElement(By.PartialLinkText("Log out"));
            //logout.Click();


            //IWebDriver driver = new FirefoxDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Url = "https://magento.com/";

            //IWebElement myAccount = driver.FindElement(By.PartialLinkText("ACCOUNT"));
            //String text = myAccount.Text;
            //String href = myAccount.GetAttribute("href");

            //Console.WriteLine(text);
            //Console.WriteLine(href);



            //ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));

            //Console.WriteLine(links.Count);

            //foreach (IWebElement link in links)
            //{
            //    Console.WriteLine("Link Text : " + link.Text + " ; Link : " + link.GetAttribute("href"));
            //}

            //for(int i=0; i<links.Count;i++)
            //{
            //    Console.WriteLine("Link Text : " + links[i].Text + " ; Link : " + links[i].GetAttribute("href"));
            //}
            //links[3].Click();
            //foreach(IWebElement link in links)
            //{
            //    Console.WriteLine("Link Text : " + link.Text + " ; Link : " + link.GetAttribute("href"));
            //    if (link.Text.Equals("MY ACCOUNT"))
            //    {
            //        link.Click();
            //        break;
            //    }    
            //}


            //Selecct dropdown
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://account.magento.com/customer/account/create/";

            //IWebElement myCompany= driver.FindElement(By.Name("company_type"));

            //SelectElement select = new SelectElement(myCompany);
            //select.SelectByText("Develops Magento extensions");
            //Thread.Sleep(3000);
            //select.SelectByValue("tech_partner");
            //Thread.Sleep(3000);
            //select.SelectByIndex(5);


            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://www.cleartrip.com/";

            //IWebElement roundTrip= driver.FindElement(By.Id("RoundTrip"));

            //Console.WriteLine(roundTrip.Selected);

            //if(!roundTrip.Selected)
            //{
            //    roundTrip.Click();
            //}
            //IWebElement returnDate = driver.FindElement(By.Id("ReturnDate"));
            //Console.WriteLine(roundTrip.Displayed);
            //if (returnDate.Displayed)
            //{
            //    returnDate.SendKeys("Thu, 31 May, 2018");
            //}


            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://account.magento.com/customer/account/create/";

            //IWebElement submit = driver.FindElement(By.Id("registerSubmit"));

            //Console.WriteLine(submit.Enabled);

            //if(!submit.Enabled)
            //{
            //    Thread.Sleep(25000);//15 sec
            //}
            //submit.Click();

            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://account.magento.com/customer/account/create/";
            //Console.WriteLine("Before clicking on Terms and Condition " + driver.Title);

            //String parent = driver.CurrentWindowHandle;
            //Console.WriteLine("Current window id : "+parent);

            //IWebElement terms= driver.FindElement(By.PartialLinkText("Terms and"));
            //terms.Click();
            //Thread.Sleep(5000);
            //ReadOnlyCollection<String> allWindowId= driver.WindowHandles;
            //foreach(String windowId in allWindowId)
            //{
            //    //Console.WriteLine("For each : "+ windowId);
            //    driver.SwitchTo().Window(windowId);
            //    String title = driver.Title;
            //    if(title.Contains("Terms"))
            //    {
            //       IWebElement privacy= driver.FindElement(By.LinkText("Privacy Policy"));
            //        privacy.Click();
            //        break;
            //    } 
            //}

            //driver.SwitchTo().Window(allWindowId[1]);
            //Console.WriteLine("After clicking on Terms and Condition " + driver.Title);
            //driver.Quit();


            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://magento.com/";

            ////driver.Navigate().GoToUrl("https://magento.com/");
            //IWebElement myAccount = driver.FindElement(By.LinkText("MY ACCOUNT"));
            //myAccount.Click();
            //Thread.Sleep(5000);
            //driver.Navigate().Back();
            //Thread.Sleep(5000);
            //driver.Navigate().Forward();
            //Thread.Sleep(5000);
            //driver.Navigate().Refresh();

            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            //driver.SwitchTo().Frame("login_page");
            //IWebElement user= driver.FindElement(By.Name("fldLoginUserId"));
            //user.SendKeys("HHHHH1234");
            //Thread.Sleep(5000);
            //IWebElement continueEle= driver.FindElement(By.XPath("//img[@alt='continue']"));
            //continueEle.Click();


            //IWebDriver driver = new FirefoxDriver();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://www.amazon.in";

            //IWebElement shopBy= driver.FindElement(By.XPath("//*[text()='Shop by']"));
            //IWebElement echoAlexa = driver.FindElement(By.XPath("(//*[text()='Echo & Alexa'])[1]"));
            //IWebElement echoDot = driver.FindElement(By.XPath("//*[text()='Echo Dot']"));

            //Actions action = new Actions(driver);

            //action.MoveToElement(shopBy).Build().Perform();
            ////Thread.Sleep(5000);
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//*[text()='Echo & Alexa'])[1]")));
            //action.MoveToElement(echoAlexa).Build().Perform();
            ////Thread.Sleep(5000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(echoDot));
            //action.MoveToElement(echoDot).Click().Build().Perform();


            //IWebDriver driver = new ChromeDriver();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();
            //driver.Url = "https://www.cleartrip.com/";

            //IWebElement from = driver.FindElement(By.Id("FromTag"));

            //Actions action = new Actions(driver);

            //action.MoveToElement(from).Click().Build().Perform();
            //Thread.Sleep(3000);
            //action.SendKeys("Tri").SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown)
            //    .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Build().Perform();
            //Thread.Sleep(3000);
            //action.SendKeys(Keys.Enter).Build().Perform();

            //driver.Url = "https://www.google.co.in/";
            //IWebElement from = driver.FindElement(By.Id("lst-ib"));
            //Actions action = new Actions(driver);
            //action.MoveToElement(from).Click().KeyDown(Keys.Shift).SendKeys("google").SendKeys(Keys.Enter).Build().Perform();



            //IWebDriver driver = new FirefoxDriver();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();

            //driver.Url = "http://www.echoecho.com/javascript4.htm";

            //IWebElement ele1= driver.FindElement(By.Name("B1"));
            // ele1.Click();

            //IAlert alert= driver.SwitchTo().Alert();
            //String alertText= alert.Text;
            //Console.WriteLine(alertText);
            //Thread.Sleep(3000);
            //alert.Accept();

            //IWebElement ele2 = driver.FindElement(By.Name("B2"));
            //ele2.Click();

            //IAlert alert = driver.SwitchTo().Alert();
            //String alertText = alert.Text;
            //Console.WriteLine(alertText);
            //Thread.Sleep(3000);
            //alert.Accept();


            //IWebElement ele2 = driver.FindElement(By.Name("B3"));
            //ele2.Click();

            //IAlert alert = driver.SwitchTo().Alert();
            //String alertText = alert.Text;
            //Console.WriteLine(alertText);
            //Thread.Sleep(3000);
            //alert.SendKeys("Test Data");
            //Thread.Sleep(3000);
            //alert.Accept();

            //IWebDriver driver = new FirefoxDriver();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //driver.Manage().Window.Maximize();

            //driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";

            //IWebElement name1Ele=driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[1]/td[2]"));
            // String name1= name1Ele.Text;
            // Console.WriteLine("Name 1 : "+name1);

            // IWebElement name2Ele = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[2]/td[2]"));
            // String name2 = name2Ele.Text;
            // Console.WriteLine("Name 2 : " + name2);

            // ReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr"));

            //int rowCount= rows.Count;
            // Console.WriteLine("No of rows : "+rowCount);

            // ReadOnlyCollection<IWebElement> cols = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr[1]/td"));

            // int colCount = cols.Count;
            // Console.WriteLine("No of columns : " + colCount);

            //for(int i=1; i<=rowCount;i++)
            //{
            //    Console.WriteLine("i value is "+i+" printed successfully");
            //    IWebElement nameEle = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr["+i+"]/td[2]"));
            //    String name = nameEle.Text;
            //    Console.WriteLine(name);
            //    if(name.Equals("Brenden Wagner"))
            //    {
            //       IWebElement checkEle= driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[1]"));
            //        checkEle.Click();
            //        break;
            //    }
            //}


            //for (int i = 1; i <= rowCount; i++)
            //{
            //    Console.WriteLine("i value is " + i + " printed successfully");
            //    IWebElement nameEle = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]"));
            //    String name = nameEle.Text;
            //    Console.WriteLine(name);
            //}


            //IWebElement table = driver.FindElement(By.Id("example"));

            //IWebElement tbody = table.FindElement(By.TagName("tbody"));

            //ReadOnlyCollection<IWebElement> rows = tbody.FindElements(By.TagName("tr"));

            //Console.WriteLine(rows.Count);

            //foreach(IWebElement row in rows )
            //{
            //    Console.WriteLine(row.Text);

            //    ReadOnlyCollection<IWebElement> cols = row.FindElements(By.TagName("td"));

            //    foreach(IWebElement col in cols)
            //    {
            //        Console.WriteLine(col.Text);
            //    }
            //}



            //Thread.Sleep(5000);
            //driver.Quit();



            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            driver.Url = "https://magento.com/";


            Size size=driver.Manage().Window.Size;

            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);

            driver.Manage().Window.Size = new Size(size.Width / 2, size.Height / 2);


            size=driver.FindElement(By.LinkText("MY ACCOUNT")).Size;
            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);

            Point point= driver.FindElement(By.LinkText("MY ACCOUNT")).Location;
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);






























        }
    }
}
