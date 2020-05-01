using AutoMapper;
using Business.Abstraction;
using Business.Implementation.Validators;
using Business.Models;
using Data.Abstraction;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Implementation.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async void CreateBookAsync(BookModel bookModel)
        {
            BookValidator.AssertBookIsValid(bookModel);
            var book = _mapper.Map<BookEntity>(bookModel);

            await _unitOfWork.BookRepository.Create(book);
            await _unitOfWork.Save();
        }

        public IEnumerable<BookModel> GetAll()
        {
            var books = _unitOfWork.BookRepository.GetAll();
            return _mapper.Map<IEnumerable<BookModel>>(books);
        }

        public IEnumerable<BookModel> GetByAuthor(int authorId)
        {

            var books = _unitOfWork.BookRepository.GetAll().Where(prop => prop.Author.Equals(authorId));
            return _mapper.Map<IEnumerable<BookModel>>(books);
        }


        public IEnumerable<BookModel> GetByReader(int readerId)
        {
            var books = _unitOfWork.BookRepository.GetAll().Where(prop => prop.Reader.Equals(readerId));
            return _mapper.Map<IEnumerable<BookModel>>(books);
        }
    }
}
