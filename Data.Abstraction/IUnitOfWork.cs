using Data.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstraction
{
    public interface IUnitOfWork
    {
        IRepository<BookEntity> BookRepository { get; }
        IRepository<ReaderEntity> ReaderRepository { get; }
        IRepository<AuthorEntity> AuthorRepository { get; }
        IRepository<ChapterEntity> ChapterRepository { get; }
        Task<int> Save();
    }
}
