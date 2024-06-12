using Data;
using Domain;
using System;
using Microsoft.EntityFrameworkCore;
using BL.Interfaces;

namespace BL
{
    public class AuthorService : IAuthorService
    {
        private readonly ProjectDbContext _context;

        public AuthorService(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<AuthorDto> GetAuthorWithDetails(int id)
        {
            var author = await _context.Authors
                .Include(a => a.Fanfics)
                .Include(a => a.Reviews)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (author == null) return null;

            return new AuthorDto
            {
                Id = author.Id,
                Nickname = author.Nickname,
                Description = author.Description,
                SubscribersNumber = author.SubscribersNumber,
                RegistrationDate = author.RegistrationDate,
                FanficIds = author.Fanfics.Select(f => f.Id).ToList(),
                ReviewIds = author.Reviews.Select(r => r.Id).ToList()
            };
        }

    }


}
