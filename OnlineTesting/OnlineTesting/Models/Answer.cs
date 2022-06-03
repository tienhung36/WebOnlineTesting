using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Answer")]
    public class Answer
    {
        [Key]
        public string Answer_ID { get; set; }
        public string Question_ID { get; set; }
        [ForeignKey("Question_ID")]
        public virtual Question Question { get; set; }
        [Required]
        public string Answer_Description { get; set; }
        [Required]
        public bool Answer_isTrue { get; set; }
        [Required]
        public string Answer_Explaination { get; set; }
        //public virtual Answer_In_Test Answer_In_Test { get; set; }
    }
}