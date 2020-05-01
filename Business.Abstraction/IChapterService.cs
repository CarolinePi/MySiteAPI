using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstraction
{
    public interface IChapterService
    {
        IEnumerable<ChapterModel> GetAll();
        IEnumerable<ChapterModel> GetByBook(int bookId);
    }
}
