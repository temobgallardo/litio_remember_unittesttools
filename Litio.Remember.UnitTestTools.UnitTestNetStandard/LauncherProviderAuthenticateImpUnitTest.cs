using System.Threading.Tasks;
using Litio.Remember.UnitTestTools.SharedDroid.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Litio.Remember.UnitTestTools.UnitTestNetStandard
{
    [TestClass]
    public class LauncherProviderAuthenticateImpUnitTest
    {
        /// <summary>
        /// This works because it is Net Standard
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task SessionShouldNotBeNull_Test()
        {
            //Arrange
            var launcherProvider = new LauncherProviderAuthenticateImp();
            //Act
            var result = await launcherProvider.GetSessionDataAsync();
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
