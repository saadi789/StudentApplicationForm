using StudentApplicationForm.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace StudentApplicationForm.DAL
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            //key  
            HasKey(t => t.Id);

            //property  
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Message);
            Property(t => t.Date);


            //table  
            ToTable("Logs");
        }
    }
}