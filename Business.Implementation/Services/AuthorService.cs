using Business.Abstraction;
using Business.Models;
using Business.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using AutoMapper;
using Data.Abstraction;
using Data.Entities;

namespace Business.Implementation.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async void CreateAuthorAsync(AuthorModel authorModel)
        {
            AuthorValidator.AssertAuthorIsValid(authorModel);
            var author = _mapper.Map<AuthorEntity>(authorModel);

            await _unitOfWork.AuthorRepository.Create(author);
            await _unitOfWork.Save();
        }

        public IEnumerable<AuthorModel> GetAll()
        {
            var authors = _unitOfWork.AuthorRepository.GetAll();
            return _mapper.Map<IEnumerable<AuthorModel>>(authors);
        }
    }
}
