using ConductorTest.test.support;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConductorTest.src.pages
{
    public abstract class Page
    {
        private readonly IWebDriver driver;

        public Page(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void WaitForId(string id)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(id)));
        }

        public void waitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            Thread.Sleep(1000);
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@id='LoaderPage']//div[@class='progress']")));
            }
            catch
            {
                Actions action = new Actions(driver);
                action.SendKeys(Keys.Escape);
                IAction pressEscape = action.SendKeys(Keys.Escape);
                pressEscape.Perform();
            }
           
            Thread.Sleep(1000);
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        
        public void WaitUntil(bool condition)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 1, 0));
            wait.Until(driver => condition);
        }
        public bool IsAttribtuePresent(IWebElement element, String attribute)
        {
            Boolean result = false;
            try
            {
                String value = element.GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception e) { Console.WriteLine("attribute missing exception " + e); }

            return result;
        }

        public bool IsElementVisible(IWebElement element)
        {
            bool flag = false;
            try
            {
                flag = element.Displayed && element.Enabled;
                return flag;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("No such element exception: " + ex);
                return false;
            }

        }

        public bool TryFindElement(By by, out IWebElement element)
        {
            element = null;
            try
            {
                element = driver.FindElement(by);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("No Such element exception " + e);
                return false;
            }
            return true;
        }

        public string GenerateRandomNumber()
        {
            Random random = new Random();
            string randomNo = random.Next(10000).ToString();
            return randomNo;
        }

        public List<string> getTextFromWebElements(ReadOnlyCollection<IWebElement> webElements)
        {
            List<string> listOfString = new List<string>();
            foreach (IWebElement element in webElements)
            {
                string strTxtFrmElemnt = element.Text;
                listOfString.Add(strTxtFrmElemnt);
            }
            return listOfString;
        }

        public static dynamic getJson()
        {
            string projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string projectDirectory = Directory.GetParent(projectPath).Parent.FullName;
            dynamic jsonObject = JObject.Parse(File.ReadAllText(projectDirectory + @"\test\resources\prop.json"));
            return jsonObject;
        }

        public void selectElement(IWebElement element, string selectBy, string parameter)
        {
            var selectElement = new SelectElement(element);
            switch (selectBy)
            {
                case "ByValue":
                    selectElement.SelectByValue(parameter);
                    break;
                case "ByText":
                    selectElement.SelectByText(parameter);
                    break;
                case "ByIndex":
                    selectElement.SelectByIndex((Int32.Parse(parameter)));
                    break;
            }
        }

        public void checkFlagAndClick(IWebElement webElement, dynamic flag)
        {
            //var type = webElement.GetAttribute("type");
            flag = flag.ToString();
            if (flag == "Yes")
            {
                if (!(IsAttribtuePresent(webElement, "checked")))
                {
                    webElement.Click();
                    waitForPageLoad();
                }
            }
            else
            {
                if ((IsAttribtuePresent(webElement, "checked")))
                {
                    webElement.Click();
                    waitForPageLoad();
                }
            }
        }
    }
}
