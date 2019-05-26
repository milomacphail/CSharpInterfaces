using System;
namespace TestingExtensibility
{
    public class DbMigrator
    {

        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {

            _logger.LogInfo("Migration started at {0}" + DateTime.Now);


                //details of migration


            _logger.LogInfo("Migration ended at {0}" + DateTime.Now);

            
        }
    }
}
