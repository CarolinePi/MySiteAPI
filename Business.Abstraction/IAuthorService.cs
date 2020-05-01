using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstraction
{
    public interface IAuthorService
    {
        IEnumerable<AuthorModel> GetAll();
        void CreateAuthorAsync(AuthorModel authorModel);
    }
}
