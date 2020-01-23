using BoDi;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ConductorTest.test.support
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;
        //private static string projectDirectory;
        //public JObject jsonObject;
        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //SqlClient.SetUserVersionTo50();
            //string projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //string projectDirectory = Directory.GetParent(projectPath).Parent.FullName;
            //JObject jsonObject = JObject.Parse(File.ReadAllText(projectDirectory + @"\test\resources\prop.json"));
            //return jsonObject;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //SqlClient.SetUserVersionTo50(); // temp code
            //driver = new EdgeDriver(@"..\WebDrivers", new EdgeOptions(), TimeSpan.FromMinutes(3));
            //driver = new FirefoxDriver(@"..\WebDrivers", new FirefoxOptions(), TimeSpan.FromMinutes(3));
            string projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string projectDirectory = Directory.GetParent(projectPath).Parent.FullName;
            driver = new ChromeDriver(projectDirectory+@"\test\support\webdrivers", new ChromeOptions(), TimeSpan.FromMinutes(3));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // code that runs after the test run - not currently using
        }
    }
}
