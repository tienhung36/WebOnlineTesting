using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public string Question_ID { get; set; }
        public string Teacher_ID { get; set; }
        [ForeignKey("Teacher_ID")]
        public virtual Teacher Teacher { get; set; }
        public string Subject_ID { get; set; }
        //[ForeignKey("Subject_ID"), Column(Order = 1)]
        //public virtual Subject Subject { get; set; }
        [Required]
        public string Question_Description { get; set; }
        [Required]
        public bool Question_isLock { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        //public virtual Question_In_Test Question_In_Test { get; set; }
    }
}