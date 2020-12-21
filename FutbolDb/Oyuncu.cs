using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolDb
{
    [Table("Oyuncular")]
    public class Oyuncu
    {
        public int Id { get; set; }

        public string OyuncuAd { get; set; }
        
        public int? TakimId { get; set; }

        public virtual Takim Takimi { get; set; }
    }
}
