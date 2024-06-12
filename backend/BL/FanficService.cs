using Data;
using Domain;
using System;
using Microsoft.EntityFrameworkCore;
using BL.Interfaces;

namespace BL
{
    public class FanficService : IFanficService
    {
        private readonly ProjectDbContext _context;

        public FanficService(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<List<FanficDto>> GetFanficsWithChaptersByAuthor(int authorId)
        {
            return await _context.Fanfics
                .Where(f => f.AuthorId == authorId)
                .Select(f => new FanficDto
                {
                    Id = f.Id,
                    Title = f.Title,
                    Chapters = f.Chapters.Select(c => new ChapterDto
                    {
                        Id = c.Id,
                        SerialNumber = c.SerialNumber,
                        Title = c.Title,
                        CommentsNumber = c.CommentsNumber
                        
                    }).ToList()
                })
                .ToListAsync();
        }
    }
}