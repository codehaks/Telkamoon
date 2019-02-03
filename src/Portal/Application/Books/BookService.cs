using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portal.Application.Books.Models;
using Portal.Domain.Entities;
using Portal.Persistance;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Application.Books
{
    public class BookService : IBookService
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        public BookService(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<bool> Add(BookAddModel input)
        {
            var newBook = _mapper.Map<Book>(input);
            var result = _db.Books.Add(newBook);
            await _db.SaveChangesAsync();
            return true;


        }

        public async Task<BookViewModel> Get(int bookId)
        {
            var book = await _db.Books.FindAsync(bookId);
            return _mapper.Map<BookViewModel>(book);
        }

        public async Task<IList<Book>> GetAll()
        {
            return await _db.Books.ToListAsync();
        }

        public async Task<BookEditModel> GetForEdit(int bookId)
        {
            var book = await _db.Books.FindAsync(bookId);
            return _mapper.Map<BookEditModel>(book);
        }

        public IList<BookViewModel> GetGallery()
        {
            return _db.Books.Select(_mapper.Map<Book, BookViewModel>).ToList();
        }

        public IList<BookItemModel> GetItems()
        {
            var model = _db.Books.Select(_mapper.Map<Book, BookItemModel>).ToList();
            return model;
        }

        public async Task<bool> Update(BookEditModel input)
        {
            var book = _mapper.Map<Book>(input);
            _db.Books.Attach(book);
            _db.Entry(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
