using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Faq
    {
        [Key]
        public int Id { get; set; } //Уникальный 

        public string Title { get; set; } //название вопроса



    }
}
