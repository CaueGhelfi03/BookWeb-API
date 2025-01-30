using AutoMapper;
using BookWeb.Domain.DTOs.Book;
using BookWeb.Domain.DTOs.BookAuthor;
using BookWeb.Domain.Entities.AuthorEntity;
using BookWeb.Domain.Entities.BookEntity;

namespace BookWeb.Mapper.Author
{
    public class BookMapperProfile : Profile
    {
        public BookMapperProfile()
        {
            CreateMap<Book, BookResponseDTO>().ReverseMap();

            CreateMap<Book, BookAuthorResponseDTO>()
                .ForMember(target => target.Author, opt => opt.MapFrom(src => src.Author))
                .ReverseMap();

            CreateMap<BookRequestDTO, Book>()
                .ForMember(target => target.Author, opt => opt.MapFrom(src => src))
                .ReverseMap(); 
        }


    }
}
