using csharp.Utils;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;

namespace csharp
{
    public class StepImplementation
    {
        private IWebDriver webDriver;

        [Step("<url>���J��")]
        public void Open(string url)
        {
            webDriver = Driver.WebDriver;
            webDriver.Url = url;
        }

        [Step("�^�C�g����<title>�ł��邱��")]
        public void AssertionTitle(string expect)
        {
            var actual = webDriver.FindElements(By.TagName("title"));
            actual.Should().Equals(expect);
        }
    }
}
