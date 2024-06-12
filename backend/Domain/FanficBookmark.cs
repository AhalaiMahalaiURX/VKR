using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FanficBookmark
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Fanfic))]
        public int FanficId { get; set; } // id конкретного фанфика
        public virtual Fanfic? Fanfic { get; set; }

        [ForeignKey(nameof(Bookmark))]
        public int BookmarkId { get; set; } // id конкретного сборника
        public virtual Bookmark? Bookmark { get; set; }
    }
}