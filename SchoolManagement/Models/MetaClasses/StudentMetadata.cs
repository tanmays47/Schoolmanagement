using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SchoolManagement.Models.MetaClasses
{
    public class StudentMetadata
    {
        [StringLength(50)]
        [Display(Name ="Last name")]
        public string LastName { get; set; }
        
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Date of Enrollment")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; }

        //[Display(Name = "Date of Birth")]
        //public Nullable<System.DateTime> DateOfBirth { get; set; }
    }
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    { }
}