using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTesting.Models
{
    [Table("admin")]
    public class admin
    {
        [Key]
        [Required]
        public string taikhoan { get; set; }
        public string Password { get; set; }
    }
}