using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Required]
        public string ID { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int IsLock { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public int IsMale { get; set; }
        public string ContactNumber { get; set; }
        public string MailAddress { get; set; }
    }
}