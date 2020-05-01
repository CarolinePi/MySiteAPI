using Business.Abstraction;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService _chapterService;

        public ChapterController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ChapterModel>> GetAll()
        {
            return Ok(_chapterService.GetAll());
        }

        [HttpGet("bookId")]
        public ActionResult<BookModel> GetByReader(int bookId)
        {
            var books = _chapterService.GetByBook(bookId);
            return Ok(books);
        }
    }
}
