using AutoMapper;
using Portal.Application.Books.Models;
using Portal.Domain.Entities;

namespace Portal.AutoMapper
{
    public class BookMapping : Profile
    {
        public BookMapping()
        {
            CreateMap<Book, BookItemModel>();
            CreateMap<Book, BookViewModel>();
            CreateMap<BookAddModel, Book>();

        }
    }
}