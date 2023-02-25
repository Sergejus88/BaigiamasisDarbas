using FrameWork;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.Pages.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }
            Driver.CloseDriver();
        }
    }
}
    

