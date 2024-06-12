using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Bookmark
    {
        [Key]
        public int Id { get; set; } //Уникальный ID сборника
        public string Author { get; set; } // Автор сборника
        public string Title { get; set; } // Название сборника
        public virtual List<FanficBookmark>? RelatedFanfics { get; set; } //связь с таблицей работ

        

    }
}
