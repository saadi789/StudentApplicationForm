namespace StudentApplicationForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentApplicationForm.DAL.StudentAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudentApplicationForm.DAL.StudentAppDbContext context)
        {

        }
    }
}
