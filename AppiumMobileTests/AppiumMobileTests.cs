using OpenQA.Selenium.Appium.Android;

namespace AppiumMobileTests
{
    public class AppiumMobileTests
    {
        private AndroidDriver<AndroidElement> driver;
        private AppiumOptions options;

        private const string appLocation = @"D:\QA kurs\Front end\06.04\ExamPrepResources\com.android.example.github.apk";
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";

        [SetUp]
        public void PrepareApp()
        {
            this.options = new AppiumOptions() { PlatformName = "Anroid" };
            options.AddAdditionalCapability("app", appLocation);
        driver = new AndroidDriver<AndroidElement>(new Uri(appiumServer), options);
        }

        [TearDown]  
        public void CloseAppp() 
        {
            driver.Quit();
        }

        [Test]
        public void Test_VerifyBarancevName() 
        {
            Assert.True(true);
        }
    }
}