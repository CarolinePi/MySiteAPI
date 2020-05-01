using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementation
{
    public class LibraryDbContext: DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<ChapterEntity> Chapters { get; set; }
        public DbSet<ReaderEntity> Readers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }

}
