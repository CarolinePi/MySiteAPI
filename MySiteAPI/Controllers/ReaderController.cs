using Business.Abstraction;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ReaderController : ControllerBase
    {
        private readonly IReaderService _readerService;

        public ReaderController(IReaderService readerService)
        {
            _readerService = readerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorModel>> GetAll()
        {
            return Ok(_readerService.GetAll());
        }

        [HttpPost]
        public ActionResult<AuthorModel> CreateAuthor([FromBody] ReaderModel readerModel)
        {
            _readerService.CreateReaderAsync(readerModel);
            return Ok(readerModel);
        }
    }
}
