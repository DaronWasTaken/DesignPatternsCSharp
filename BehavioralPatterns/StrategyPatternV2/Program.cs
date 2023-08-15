namespace StrategyPatternV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database(DatabaseType.Postgres);
            Database database1 = new Database(DatabaseType.Oracle);
        }
    }
}