using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"D:\PROECT-ASP\PROJECT-PUBLISH-VS15\CSharpLog.txt"));
            dbMigrator.Migrate();
        }
    }
}
