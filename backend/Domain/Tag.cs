using Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Tag
    {
        [Key]
        public int Id { get; set; } //Уникальный ID тега
        public string Title { get; set; } // Название тега

        public virtual List<FanficTag>? RelatedFanfics { get; set; } //связь с таблицей фанфиков

    }
}
