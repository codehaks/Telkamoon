using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Books;
using Portal.Application.Books.Models;
using System.Collections.Generic;

namespace Portal.Web.Pages.Admin.Books
{
    public class IndexModel : PageModel
    {
        public IList<BookItemModel> Output { get; set; }
        public void OnGet([FromServices] IBookService bookService)
        {
            Output = bookService.GetItems();
        }
    }
}