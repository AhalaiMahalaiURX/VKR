using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Description { get; set; }
        public int SubscribersNumber { get; set; }
        public string RegistrationDate { get; set; }
        // Список ID фанфиков или FanficDto, если нужны детали
        public List<int> FanficIds { get; set; }
        // Аналогично для рецензий
        public List<int> ReviewIds { get; set; }
    }

}
