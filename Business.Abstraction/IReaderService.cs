using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstraction
{
    public interface IReaderService
    {
        IEnumerable<ReaderModel> GetAll();
        void CreateReaderAsync(ReaderModel reader);
    }
}
