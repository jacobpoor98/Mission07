using System;
using System.Linq;

namespace Mission07.Models
{
    public class EFBookProjectRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookProjectRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Projects => context.Books;
    }
}
