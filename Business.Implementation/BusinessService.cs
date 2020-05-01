using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Business.Abstraction;
using Business.Implementation.Services;
using Business.Implementation.Automapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Implementation
{
    public static class BusinessService
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<IChapterService, ChapterService>();
            services.AddTransient<IReaderService, ReaderService>();

            var mapperConfig = new MapperConfiguration(c => c.AddProfile(new MapperProfile()));

            var mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}
