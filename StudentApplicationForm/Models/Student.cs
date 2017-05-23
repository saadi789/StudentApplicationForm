using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApplicationForm.Models
{
    public class Student
    {
        [Key]
        public int StdId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Full Name")]
        public string StdName { get; set; }

        [Required(ErrorMessage = "Gender is Required")]
        [Display(Name = "Gender")]
        public string StdSex { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime StdDOB { get; set; }

        [Required(ErrorMessage = "NAT is Required")]
        [Display(Name = "NAT")]
        public string StdNat { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [Display(Name = "Address")]
        public string StdAddr { get; set; }
    }
}