using AutoMapper;
using Business.Abstraction;
using Business.Implementation.Validators;
using Business.Models;
using Data.Abstraction;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Implementation.Services
{
    public class ReaderService : IReaderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReaderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async void CreateReaderAsync(ReaderModel readerModel)
        {
            ReaderValidator.AssertReaderIsValid(readerModel);
            var reader = _mapper.Map<ReaderEntity>(readerModel);

            await _unitOfWork.ReaderRepository.Create(reader);
            await _unitOfWork.Save();
        }

        public IEnumerable<ReaderModel> GetAll()
        {
            var readers = _unitOfWork.ReaderRepository.GetAll();
            return _mapper.Map<IEnumerable<ReaderModel>>(readers);
        }

    }
}
