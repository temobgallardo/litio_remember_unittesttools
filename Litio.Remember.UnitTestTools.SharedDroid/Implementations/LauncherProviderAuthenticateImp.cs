using Litio.Remember.UnitTestTools.Models;
using Litio.Remember.xUnitTest.Core.Interfaces;
using System.Threading.Tasks;

namespace Litio.Remember.UnitTestTools.SharedDroid.Implementations
{
    public class LauncherProviderAuthenticateImp : IAuthenticate
    {
        public LauncherProviderAuthenticateImp()
        {
        }

        public async Task<SessionData> GetSessionDataAsync()
        {
            // Mocking the result for Unit Testing tasting
            return await Task.FromResult(new SessionData() { Name = "Temo B Gallardo"});
        }
    }
}