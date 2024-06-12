using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FanficGenre
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Fanfic))]
        public int FanficId { get; set; } // id конкретного фанфика
        public virtual Fanfic? Fanfic { get; set; }

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; } // id конкретного жанра
        public virtual Genre? Genre { get; set; }
    }
}