using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FanficDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ChapterDto> Chapters { get; set; }
    }

}
