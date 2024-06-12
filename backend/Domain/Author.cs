using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {

        //У каждого автора собственный ID

        [Key]
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Description { get; set; }
        public string SubscribersNumber { get; set; }

        [InverseProperty(nameof(Fanfic.Author))]
        public virtual List<Fanfic>? Fanfics { get; set; } //связь с работами

        public string RegistrationDate { get; set; }

        [InverseProperty(nameof(Review.Author))]
        public virtual List<Review>? Reviews { get; set; } //связь с рецензиями
        public string password {get ; set; }

        public string email { get; set; }

        public string role { get; set; }

        public string photoref {  get; set; }


    }
}
