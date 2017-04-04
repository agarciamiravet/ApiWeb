namespace ApiWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiWeb.DAL.CUContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

    }
}
