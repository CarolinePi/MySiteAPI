using AutoMapper;
using Business.Abstraction;
using Business.Models;
using Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Implementation.Services
{
    class ChapterService : IChapterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChapterService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<ChapterModel> GetAll()
        {
            var chapters = _unitOfWork.ChapterRepository.GetAll();
            return _mapper.Map<IEnumerable<ChapterModel>>(chapters);
        }

        public IEnumerable<ChapterModel> GetByBook(int bookId)
        {
            var chapters = _unitOfWork.ChapterRepository.GetAll().Where(prop => prop.Book.Equals(bookId));
            return _mapper.Map<IEnumerable<ChapterModel>>(chapters);
        }
    }
}
