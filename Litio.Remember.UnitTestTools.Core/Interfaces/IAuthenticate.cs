using Litio.Remember.UnitTestTools.Models;
using System.Threading.Tasks;

namespace Litio.Remember.xUnitTest.Core.Interfaces
{
    public interface IAuthenticate
    {
        Task<SessionData> GetSessionDataAsync();
    }
}
