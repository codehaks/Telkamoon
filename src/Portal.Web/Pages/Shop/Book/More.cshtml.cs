using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Books;
using Portal.Application.Books.Models;

namespace Portal.Web.Pages.Shop.Book
{
    public class MoreModel : PageModel
    {
        public BookViewModel Output { get; set; }
        public async Task<IActionResult> OnGet([FromServices] IBookService bookService,int bookId)
        {
            Output = await bookService.Get(bookId);
            return Page();
        }
    }
}