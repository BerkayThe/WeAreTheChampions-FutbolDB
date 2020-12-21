﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolDb
{
    [Table("Renkler")]
    public class Renk
    {
        public int Id { get; set; }

        public string RenkAd { get; set; }

        public byte Red { get; set; }

        public byte Green { get; set; }

        public byte Blue { get; set; }

        public virtual ICollection<Takim> Takimlar { get; set; }
    }
}
