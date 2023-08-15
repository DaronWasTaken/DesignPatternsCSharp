using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternV2
{
    internal class Database
    {
        public DatabaseType DbType { get; set; }
        private readonly IDbService dbContext;
        public Database(DatabaseType databaseType)
        {

            switch(databaseType)
            {
                case DatabaseType.Postgres:
                    dbContext = new PostgresImplementation();
                    break;

                case DatabaseType.Oracle:
                    dbContext = new OracleImplementation();
                    break;

                default: 
                    throw new ArgumentException();
                    break;

            }
            dbContext.PrintDbUrl();
        }
    }

    public enum DatabaseType
    {
        Oracle,
        Postgres
    }
}
