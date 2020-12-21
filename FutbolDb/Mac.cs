using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolDb
{
    [Table("Maçlar")]
    public class Mac
    {
        public int Id { get; set; }

        public DateTime? MacTarih { get; set; }
      
        public int Takim1Id { get; set; }
       
        public int Takim2Id { get; set; }

        public int? Skor1 { get; set; }

        public int? Skor2 { get; set; }

        public virtual Sonuc? Sonuc { get; set; }

        public virtual Takim Takim1 { get; set; }

        public virtual Takim Takim2 { get; set; }

    }
}
