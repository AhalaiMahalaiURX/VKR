using Data;
using Domain;
using System;
using Microsoft.EntityFrameworkCore;
using BL.Interfaces;

namespace BL
{
    public class BookInfoService : IBookInfoService
    {
        private readonly ProjectDbContext _context;

        public BookInfoService(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<BookInfoDto> GetBookWithDetails(int id)
        {
            var fanfic = await _context.Fanfics
                .Include(f => f.Chapters)
                .Include(f => f.Reviews)
                .FirstOrDefaultAsync(f => f.Id == id);

            if (fanfic == null) return null;

            return new BookInfoDto
            {
                Id = fanfic.Id,
                Title = fanfic.Title,
                
                Chapters = fanfic.Chapters.Select(c => new ChapterDto
                {
                    // Инициализация свойств главы
                }).ToList(),
                Reviews = fanfic.Reviews.Select(r => new ReviewDto
                {
                    
                }).ToList()
            };
        }
    }
}