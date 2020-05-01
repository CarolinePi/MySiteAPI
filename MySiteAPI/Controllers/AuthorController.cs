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
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorModel>> GetAll()
        {
            return Ok(_authorService.GetAll());
        }

        [HttpPost]
        public ActionResult<AuthorModel> CreateAuthor([FromBody] AuthorModel authorModel)
        {
            _authorService.CreateAuthorAsync(authorModel);
            return Ok(authorModel);
        }
    }
}
