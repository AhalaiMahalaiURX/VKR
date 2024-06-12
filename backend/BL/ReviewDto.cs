using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

   

    public class ReviewDto
    {
        public int Id { get; set; }
        public string Summary { get; set; }

        public List<AuthorDto> Authors { get; set; }
    }

}
