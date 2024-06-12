using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FanficFandom
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Fanfic))]
        public int FanficId { get; set; } // id конкретного фанфика
        public Fanfic? Fanfic { get; set; }

        [ForeignKey(nameof(Fandom))]
        public int FandomId { get; set; } // id конкретного фандома
        public Fandom? Fandom { get; set; }
    }
}