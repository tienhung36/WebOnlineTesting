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
        [StringLength(10)]
        public string Test_ID_History { get; set; }

        [StringLength(10)]
        public string Test_ID { get; set; }

        [StringLength(10)]
        public string Question_int_Test_History_ID { get; set; }

        [StringLength(10)]
        public string Class_ID { get; set; }

        [StringLength(10)]
        public string Subject_ID { get; set; }

        [StringLength(10)]
        public string Teacher_ID { get; set; }

        [StringLength(100)]
        public string Test_Description { get; set; }

        public bool? Test_isLock { get; set; }

        public DateTime? Test_timeStart { get; set; }

        public DateTime? Test_timeEnd { get; set; }

        public virtual Test Test { get; set; }
    }
}