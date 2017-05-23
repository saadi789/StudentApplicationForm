using StudentApplicationForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace StudentApplicationForm.DAL
{
    public class StudentAppDbContext : DbContext
    {
        public StudentAppDbContext() : base(GetCreds())
        {
            Database.SetInitializer<StudentAppDbContext>(new CreateDatabaseIfNotExists<StudentAppDbContext>());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new LogMap());
        }

        private static string GetCreds()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return File.ReadAllText($"{path}\\creds.txt");
        }
    }
}