using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IAuthorService
    {
        Task<AuthorDto> GetAuthorWithDetails(int id);
    }

}
