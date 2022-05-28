using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCF
{
    [Table("LopSH")]
    public  class LSH
    {
        public LSH()
        {
            this.SVs = new HashSet<SV>();
        }
        [Key][Required]
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SV> SVs { get; set; }
    }
}
