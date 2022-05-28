using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCF
{
    [Table("SinhVien")]
    public  class SV
    {
       [Key][Required][StringLength(9)]
       public string MSSV { get; set; }
        public string NameSV { get; set; }
        [Required]
        public int ID_Lop { get; set; }
        public double DTB { get; set; }
        [ForeignKey("ID_Lop")]
        public virtual LSH LSH { get; set; }
    }
}
