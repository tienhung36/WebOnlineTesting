using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Answer_In_Test_History")]
    public class Answer_In_Test_History
    {
        [Key]
        public string Answer_In_Test_History_ID { get; set; }
        public string Question_In_Test_History_ID { get; set; }
        [ForeignKey("Question_In_Test_History_ID"), Column(Order = 0)]
        public virtual Question_In_Test_History Question_In_Test_History { get; set; }
        public string Answer_In_Test_ID { get; set; }
        [ForeignKey("Answer_In_Test_ID"), Column(Order = 1)]
        public virtual Answer_In_Test Answer_In_Test { get; set; }
        /*[Required]
        public bool Answer_isTrue { get; set; }
        [Required]
        public string Answer_Explaination { get; set; }*/
        public bool Answer_isChoosed { get; set; }


    }
}