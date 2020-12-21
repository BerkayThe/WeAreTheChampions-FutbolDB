using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolDb
{
    [Table("Takimlar")]
    public class Takim
    {
        public Takim()
        {
            Oyuncular = new HashSet<Oyuncu>();
            Renkler = new HashSet<Renk>();
            Takim1Maclari = new HashSet<Mac>();
            Takim2Maclari = new HashSet<Mac>();
        }

        public int Id { get; set; }
        [Required]
        public string TakimAd { get; set; }

        public virtual ICollection<Renk> Renkler { get; set; }

        public virtual ICollection<Oyuncu> Oyuncular { get; set; }

        public virtual ICollection<Mac> Takim1Maclari { get; set; }

        public virtual ICollection<Mac> Takim2Maclari { get; set; }

    }
}
