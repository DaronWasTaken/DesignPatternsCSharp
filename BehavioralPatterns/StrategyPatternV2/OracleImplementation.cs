using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternV2
{
    internal class OracleImplementation : IDbService
    {
        public void PrintDbUrl()
        {
            Console.WriteLine("Oracle");
        }
    }
}
