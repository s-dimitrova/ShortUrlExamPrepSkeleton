using OpenQA.Selenium.Appium;

namespace AppiumDesktopTests
{
    internal class WindowsDriver<T>
    {
        private Uri uri;
        private AppiumOptions options;

        public WindowsDriver(Uri uri, AppiumOptions options)
        {
            this.uri = uri;
            this.options = options;
        }

        internal object FindElementByAccessibilityId(string v)
        {
            throw new NotImplementedException();
        }

        internal object Manage()
        {
            throw new NotImplementedException();
        }

        internal void Quit()
        {
            throw new NotImplementedException();
        }
    }
}