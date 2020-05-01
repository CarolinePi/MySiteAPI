using Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Implementation.Validators
{
    public static class ReaderValidator
    {
        public static void AssertReaderIsValid(ReaderModel reader)
        {
            if (string.IsNullOrEmpty(reader.Name))
            {
                throw new ValidationException("Name is null");
            }
            if (reader.Name.Length > 100)
            {
                throw new ValidationException("Name is too long");
            }
        }
    }
}
