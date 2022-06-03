using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        public Teacher()
        {
            this.Questions = new HashSet<Question>();
        }
        [Key]
        [Required]
        public string Teacher_ID { get; set; }
        [ForeignKey("Teacher_ID"), Column(Order = 0)]
        public virtual Account Account { get; set; }
        public string Subject_ID { get; set; }
        [ForeignKey("Subject_ID"), Column(Order = 1)]
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}