using Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Genre
    {
        [Key]
        public int Id { get; set; } //Уникальный ID жанра
        public string Title { get; set; } // Название жанра
        public virtual List<FanficGenre>? RelatedFanfics { get; set; } //связь с таблицей фанфиков

    }
}
