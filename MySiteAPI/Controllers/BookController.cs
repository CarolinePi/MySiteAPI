using Business.Abstraction;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookModel>> GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpPost]
        public ActionResult<BookModel> CreateBook([FromBody] BookModel bookModel)
        {
            _bookService.CreateBookAsync(bookModel);
            return Ok(bookModel);
        }
        
        [HttpGet("authorId")]
        public ActionResult<BookModel> GetByAuthor(int authorId)
        {
            var books = _bookService.GetByAuthor(authorId);
            return Ok(books);
        }

        [HttpGet("readerId")]
        public ActionResult<BookModel> GetByReader(int readerId)
        {
            var books = _bookService.GetByAuthor(readerId);
            return Ok(books);
        }
    }

}
