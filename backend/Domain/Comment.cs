using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Comment
    {
        [Key]
        public int Id { get; set; } //Уникальный ID комментария
        public string PublicationDate { get; set; } // Дата публикации комментария
        public string Author { get; set; } // Автор комментария
        public string Summary { get; set; } //Содержание комментария

        [ForeignKey(nameof(Chapter))]
        public int ChapterId { get; set; } // Внешний ключ
        public virtual Chapter? Chapter { get; set; } // Навигационное свойство к главе



    }
}
