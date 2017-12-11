using System;
using System.Collections.Generic;

namespace ThaWeb.Services
{
    public class ServiceTester : IServiceTester
    {
        public IEnumerable<int> GetSomeDataRandomly()
        {
            var r = new Random();
            for (var i = 0; i < 10; i++)
            {
                yield return r.Next(0, 100);
            }
        }
    }
}