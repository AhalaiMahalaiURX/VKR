using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Rules
    {
        [Key]
        public int Id { get; set; } //Уникальный ID сборника
        
        public string Title { get; set; } //название правила



    }
}
