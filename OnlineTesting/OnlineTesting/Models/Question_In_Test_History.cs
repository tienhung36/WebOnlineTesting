using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Question_In_Test_History")]
    public class Question_In_Test_History
    {
        [Key]
        public string Question_In_Test_History_ID { get; set; }
        public string Test_History_ID { get; set; }
        [ForeignKey("Test_History_ID"), Column(Order = 0)]
        public virtual Test_History Test_History { get; set; }
        public string Question_In_Test_ID { get; set; }
        [ForeignKey("Question_In_Test_ID"), Column(Order = 1)]
        public virtual Question_In_Test Question_In_Test { get; set; }
        //[Required]
        //public string Question_Description { get; set; }

        public virtual ICollection<Answer_In_Test_History> Answer_In_Test_Historys { get; set; }

    }
}