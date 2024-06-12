using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BookInfoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        // Другие свойства фанфика
        public List<ChapterDto> Chapters { get; set; }
        public List<ReviewDto> Reviews { get; set; }
    }

}
