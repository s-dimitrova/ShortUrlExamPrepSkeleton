using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumDesktopTests
{
    public class AppiumDesktopTests
    {
        private WindowsDriver<WindowsElement> driver;
        private AppiumOptions options;

        private const string appLocation = @"D:\QA kurs\Front end\06.04\ExamPrepResources\ShortURL-DesktopClient-v1.0.net6\ShortURL-DesktopClient.exe";
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";     
        private const string appServer = "https://shorturl.sdimitrova.repl.co/api";

        [SetUp]
        public void PrepareApp()
        {
            this.options = new AppiumOptions();
            options.AddAdditionalCapability("app", appLocation);
            driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer),options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void CloseAppp()
        {
            driver.Quit();        
        }

        [Test]
        public void Test_AddNewURL()
        {
            var urlToAdd = "https://url" + DateTime.Now.Ticks + ".com";
            //Change the URL ot the backend
            var inputAppUrl = driver.FindElementByAccessibilityId("textBoxApiUrl");
            inputAppUrl.Clear();
            inputAppUrl.SendKeys();

            //press Connect button
            var buttonConnect = driver.FindElementByAccessibilityId("buttonConnect");
            buttonConnect.Click();

            Thread.Sleep(2000);

            //press button Add
            var buttonAdd = driver.FindElementByAccessibilityId("buttonAdd");
            buttonAdd.Click();

            //fill the URL field
            var inputUrl = driver.FindElementByAccessibilityId("textBoxUrl");
            inputUrl.SendKeys("urlToAdd");

            //press button create
            var buttonCreate = driver.FindElementByAccessibilityId("buttonCreate");
            buttonCreate.Click();

            var resultField = driver.FindElementByName(urlToAdd);
            Assert.IsNotEmpty(resultField.Text);
            Assert.That(resultField.Text, Is.EqualTo(urlToAdd));


        }
    }
}