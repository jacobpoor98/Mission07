using System;
using System.Linq;

namespace Mission07.Models
{
    public interface IBookProjectRepository
    {
        IQueryable<Book> Books { get; }
    }
}
