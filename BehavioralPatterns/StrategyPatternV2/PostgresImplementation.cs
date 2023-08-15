using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternV2
{
    internal class PostgresImplementation : IDbService
    {
        public void PrintDbUrl()
        {
            Console.WriteLine("Postgres"); ;
        }
    }
}
