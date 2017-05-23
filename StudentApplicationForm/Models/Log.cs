using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentApplicationForm.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key]
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime Date
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }

        private DateTime? dateCreated = null;
    }
}