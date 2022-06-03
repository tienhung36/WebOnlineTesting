using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Answer_In_Test")]
    public class Answer_In_Test
    {
        [Key]
        public string Answer_In_Test_ID { get; set; }
        public string Question_In_Test_ID { get; set; }
        [ForeignKey("Question_In_Test_ID"), Column(Order = 0)]
        public virtual Question_In_Test Question_In_Test { get; set; }
        public string Answer_ID { get; set; }
        [ForeignKey("Answer_ID"), Column(Order = 1)]
        public virtual Answer Answer { get; set; }
        public bool Answer_isTrue { get; set; }
        public string Answer_Explaination { get; set; }
        //public virtual Answer_In_Test_History Answer_In_Test_History { get; set; }
    }
}