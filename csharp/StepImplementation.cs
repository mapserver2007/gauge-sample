using csharp.Utils;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;

namespace csharp
{
    public class StepImplementation
    {
        private IWebDriver webDriver;

        [Step("<url>を開く")]
        public void Open(string url)
        {
            webDriver = Driver.WebDriver;
            webDriver.Url = url;
        }

        [Step("タイトルが<title>であること")]
        public void AssertionTitle(string expect)
        {
            var actual = webDriver.FindElements(By.TagName("title"));
            actual.Should().Equals(expect);
        }
    }
}
