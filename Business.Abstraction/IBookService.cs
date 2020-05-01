using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstraction
{
    public interface IBookService
    {
        IEnumerable<BookModel> GetAll();
        IEnumerable<BookModel> GetByAuthor(int authorId);
        IEnumerable<BookModel> GetByReader(int readerId);
        void CreateBookAsync(BookModel bookModel);

    }
}
