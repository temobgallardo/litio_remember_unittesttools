using Litio.Remember.UnitTestTools.SharedDroid.Implementations;
using System.Threading.Tasks;
using Xunit;

namespace Litio.Remember.UnitTestTools.xUnitTest
{
    public class LauncherProviderAuthenticateImpUnitTestUnitTest
    {
        /// <summary>
        /// This does not work because it is Net Core
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task SessionShouldNotBeNull_Test()
        {
            //Arrange
            var launcherProvider = new LauncherProviderAuthenticateImp();
            //Act
            var result = await launcherProvider.GetSessionDataAsync();
            //Assert
            Assert.NotNull(result);
        }
    }
}
