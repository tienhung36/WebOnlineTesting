using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Required]
        public string Student_ID { get; set; }
        [ForeignKey("Student_ID"),Column(Order =0)]
        public virtual Account Account { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public string Classroom_ID { get; set; }
        [ForeignKey("Classroom_ID"), Column(Order = 1)]
        public virtual Classroom Classroom { get; set; }

    }
}