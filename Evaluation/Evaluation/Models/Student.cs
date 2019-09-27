using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    public enum GenderType { Male, Female, Helicopter }
    public class Student
    {
        [Key]
        public string Name { get; set; }
       [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Required]
        public GenderType Gender { get; set; }
    }
}