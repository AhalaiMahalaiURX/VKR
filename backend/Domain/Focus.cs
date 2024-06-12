using Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Focus
    {
        [Key]
        public int Id { get; set; } //Уникальный ID направленности
        public string Title { get; set; } // Название направленности

        [InverseProperty(nameof(Fanfic.Focus))]
        public virtual List<Fanfic>? Fanfics { get; set; } //список работ с такой направленностью
    }
}
