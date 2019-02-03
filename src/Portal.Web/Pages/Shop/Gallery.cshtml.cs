using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Books;
using Portal.Application.Books.Models;

namespace Portal.Web.Pages.Shop
{
    public class GalleryModel : PageModel
    {
        public IList<BookViewModel> Output { get; set; }
        public void OnGet([FromServices] IBookService bookService)
        {
            Output = bookService.GetGallery();
        }
    }
}