using System;
using System.IO;

namespace TestingExtensibility
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("/Users/milo/Downloads/06 Interfaces/log.txt"));
            dbMigrator.Migrate();
        }
    }
}
