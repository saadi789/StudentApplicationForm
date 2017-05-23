using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentApplicationForm.Models
{
    public class InitialSetup
    {
        [Required(ErrorMessage = "Required Fields")]
        [Display(Name = "Server Name or IP")]
        public string ServerName { get; set; }

        public bool IntegratedSecurity { get; set; }

        private string defaultDbName;
        [Required(ErrorMessage = "Can not be blank")]
        [Display(Name = "Database will be created. DB name can be changed")]
        public string DatabaseName
        {
            get
            {
                if (string.IsNullOrEmpty(defaultDbName))
                {
                    defaultDbName = "StudentsDB";
                    return defaultDbName;
                }
                return defaultDbName;
            }
            set { defaultDbName = value; }
        }
        
        public string Username { get; set; }

        public string Password { get; set; }
    }
}