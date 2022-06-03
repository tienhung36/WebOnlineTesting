using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace OnlineTesting.Models
{
    [Table("Test_History")]
    public class Test_History
    {
        [Key]
        public string Test_ID_History { get; set; }
        public string Test_ID { get; set; }
        [ForeignKey("Test_ID"), Column(Order = 0)]
        public virtual Test Test { get; set; }
        public string Question_In_Test_History_ID { get; set; }
        [ForeignKey("Question_In_Test_History_ID")]
        public virtual ICollection<Question_In_Test_History> Question_In_Test_Historys { get; set; }
        //[Required]
        /*public string Class_ID { get; set; }
        [Required]
        public string Subject_ID { get; set; }
        [Required]
        public string Teacher_ID { get; set; }
        public string Test_Description { get; set; }
        public bool? Test_isLock { get; set; }
        [Required]
        public DateTime? Test_timeStart { get; set; }
        [Required]
        public DateTime? Test_timeEnd { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }*/
    }
}