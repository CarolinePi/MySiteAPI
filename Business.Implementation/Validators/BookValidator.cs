using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Implementation.Validators
{
    public static class BookValidator
    {
        public static void AssertBookIsValid(BookModel book)
        {
            if (string.IsNullOrEmpty(book.Name))
            {
                throw new ValidationException("Name is null");
            }
            if (book.Name.Length > 100)
            {
                throw new ValidationException("Name is too long");
            }
            if (book.AuthorId.Equals(null) || book.ReaderId.Equals(null))
            {
                throw new ValidationException("I need two parametrs");
            }
        }
    }
}
