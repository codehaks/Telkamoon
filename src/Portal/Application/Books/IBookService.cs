using Portal.Application.Books.Models;
using Portal.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portal.Application.Books
{
    public interface IBookService
    {
        Task<IList<Book>> GetAll();
        IList<BookItemModel> GetItems();
        Task<bool> Add(BookAddModel input);
        Task<BookEditModel> GetForEdit(int bookId);
        Task<bool> Update(BookEditModel input);
        IList<BookViewModel> GetGallery();
        Task<BookViewModel> Get(int bookId);
    }
}