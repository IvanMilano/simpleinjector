using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace ThaWeb.Services
{
    public class WrapperServiceTestForFun : IWrapperServiceTestForFun
    {
        [Import]
        public IServiceTester ServiceTest { get; set; }

        public IEnumerable<int> GetNumbersRanomly()
        {
            return ServiceTest.GetSomeDataRandomly();
        }
    }
}