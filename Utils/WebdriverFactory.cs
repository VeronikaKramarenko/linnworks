using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace linnworksTest.Utils
{
    public class WebdriverFactory
    {
        public const string ApplicationUrl = "http://localhost:59509";
        private const string EncodedToken = "YmNjZjkwNWMtNjU5Mi00MGYyLThkYjEtYzk3Njc5MWZhNDBh";
        private static IWebDriver driver;

        public static void OpenNewBrowser()
        {
            GetCurrentDriver();
        }

        public static IWebDriver GetCurrentDriver() {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static void ClearUpDriver()
        {
            driver = null;
        }

        public static string GetToken()
        {
            byte[] data = System.Convert.FromBase64String(EncodedToken);
            return System.Text.Encoding.ASCII.GetString(data);
        }
      
    }
}
