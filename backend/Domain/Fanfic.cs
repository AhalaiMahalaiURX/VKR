using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{
    public class Fanfic
    {
        [Key]
        public int Id { get; set; } // id конкретного фанфика
        public string Title { get; set; } // название фанфика

        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; } // Внешний ключ
        public virtual Author? Author { get; set; } // Навигационное свойство к автору


        public string PublicationDate { get; set; } 
        public string AgeRating { get; set; } 
        public string Status { get; set; } 
        public string Type { get; set; } 

        [ForeignKey(nameof(Focus))]
        public int FocusId { get; set; } // Внешний ключ
        public virtual Focus? Focus { get; set; } // Навигационное свойство к направленности

        public virtual List<FanficFandom>? RelatedFandoms { get; set; } //связь с таблицей Фандомов
        public virtual List<FanficGenre>? RelatedGenres { get; set; } //связь с таблицей Жанров
        public virtual List<FanficTag>? RelatedTags { get; set; } //связь с таблицей Тегов
        public string Summary { get; set; } //краткое описание
        public decimal TotalRate { get; set; } // рейтинг
        public int Likes { get; set; } 
        public int Views { get; set; } 
        public int CommentsNumber { get; set; } 
        public int ChaptersNumber { get; set; } 

        [InverseProperty(nameof(Chapter.Fanfic))]
        public virtual List<Chapter>? Chapters { get; set; } //список глав

        public int ReviewsNumber { get; set; } //количество рецензий

        [InverseProperty(nameof(Review.Fanfic))]
        public virtual List<Review>? Reviews { get; set; } //список рецензий к фанфику
        public int BookmarksNumber { get; set; } 
        public virtual List<FanficBookmark>? RelatedBookmarks { get; set; } //связь с таблицей 

        public string PhotoRef { get; set; }

        

    }
}
