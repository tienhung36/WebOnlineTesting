using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace OnlineTesting.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public string Test_ID { get; set; }
        [Required]
        public string Question_In_Test_ID { get; set; }
        public string Class_ID { get; set; }
        [ForeignKey("Class_ID"), Column(Order = 2)]
        public virtual Classroom Classroom { get; set; }
        public string Subject_ID { get; set; }
        [ForeignKey("Subject_ID"), Column(Order = 1)]
        public virtual Subject Subject { get; set; }
        public string Teacher_ID { get; set; }
        [ForeignKey("Teacher_ID"), Column(Order = 0)]
        public virtual Teacher Teacher { get; set; }
        public string Test_Description { get; set; }
        public bool? Test_isLock { get; set; }
        public DateTime? Test_timeStart { get; set; }
        public DateTime? Test_timeEnd { get; set; }



        //public virtual Test_History Test_History { get; set; }
        public virtual ICollection<Question_In_Test> Question_In_Tests { get; set; }
    }
}