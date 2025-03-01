using Demo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork
    {
        public ApplicationUnitOfWork(DbContext context, IBookRepository bookRepository, IAuthorRepository authorRepository) : base(context)
        {
        }

        public IBookRepository BookRepository { get; private set; }
        public IAuthorRepository AuthorRepository { get; private set; }
    }
}
