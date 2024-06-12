using Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Fandom
    {
        [Key]
        public int Id { get; set; } //Уникальный ID фэндома
        public string Title { get; set; } // название фэндома

        public virtual List<FanficFandom>? RelatedFanfics { get; set; } //связь с таблицей фанфиков
    }
}
