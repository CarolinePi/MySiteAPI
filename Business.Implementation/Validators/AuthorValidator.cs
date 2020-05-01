using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Implementation.Validators
{
    public static class AuthorValidator
    {
        public static void AssertAuthorIsValid(AuthorModel author)
        {
            if (string.IsNullOrEmpty(author.Name))
            {
                throw new ValidationException("Name is null");
            }
            if (author.Name.Length > 100)
            {
                throw new ValidationException("Name is too long");
            }
        }
    }
}
