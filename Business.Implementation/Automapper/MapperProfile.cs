using AutoMapper;
using Business.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Implementation.Automapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<BookEntity, BookModel>().ReverseMap();
            CreateMap<ReaderEntity, ReaderModel>().ReverseMap();
            CreateMap<AuthorEntity, AuthorModel>().ReverseMap();
            CreateMap<ChapterEntity, ChapterModel>().ReverseMap();
        }
    }
}
