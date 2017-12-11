using System.Collections.Generic;

namespace ThaWeb.Services
{
    public interface IServiceTester
    {
        IEnumerable<int> GetSomeDataRandomly();
    }
}