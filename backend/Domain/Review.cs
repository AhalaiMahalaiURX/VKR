using Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Review
    {
        [Key]
        public int Id { get; set; } //Уникальный ID рецензии
        public string PublicationDate { get; set; } // Дата публикации рецензии
        public string Summary { get; set; } //Содержание рецензии

        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; } // Внешний ключ
        public virtual Author? Author { get; set; } // Навигационное свойство к автору рецензии

        [ForeignKey(nameof(Fanfic))]
        public int FanficId { get; set; } // Внешний ключ
        public virtual Fanfic? Fanfic { get; set; } // Навигационное свойство к фанфику


    }
}
