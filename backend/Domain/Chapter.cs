using Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; } //Уникальный ID главы
        public int SerialNumber { get; set; } 
        public string Title { get; set; } 
        public string PublicationDate { get; set; } 
        public string Summary { get; set; } //Содержание главы

        public string Status { get; set; } //Статус главы (Опубликовано либо нет)

        [ForeignKey(nameof(Fanfic))]
        public int FanficId { get; set; } // Внешний ключ
        public virtual Fanfic? Fanfic { get; set; } // Навигационное свойство к фанфику

        public int CommentsNumber { get; set; } //количество комментариев

        [InverseProperty(nameof(Comment.Chapter))]
        public virtual List<Comment>? Comments { get; set; } //список комментариев к главе

    }
}
