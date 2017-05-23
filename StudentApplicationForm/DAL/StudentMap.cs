using StudentApplicationForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace StudentApplicationForm.DAL
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            //key  
            HasKey(t => t.StdId);

            //property  
            Property(t => t.StdId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.StdName);
            Property(t => t.StdAddr);
            Property(t => t.StdDOB);
            Property(t => t.StdNat);
       

            //table  
            ToTable("Students");
        }
    }
}