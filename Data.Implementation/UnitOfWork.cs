using Data.Entities;
using Data.Abstraction;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementation
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly LibraryDbContext _context;
        public UnitOfWork(
            IRepository<BookEntity> bookRepository,
            IRepository<AuthorEntity> authorRepository,
            IRepository<ChapterEntity> chapterRepository,
            IRepository<ReaderEntity> readerRepository,
            LibraryDbContext context
            )
        {
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
            ChapterRepository = chapterRepository;
            ReaderRepository = readerRepository;
            _context = context;
        }

        public IRepository<BookEntity> BookRepository { get; }
        public IRepository<AuthorEntity> AuthorRepository { get; }
        public IRepository<ChapterEntity> ChapterRepository { get; }
        public IRepository<ReaderEntity> ReaderRepository { get; }
        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
