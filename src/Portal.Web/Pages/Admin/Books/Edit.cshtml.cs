using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Books;
using Portal.Application.Books.Models;
using Portal.Domain.Entities;

namespace Portal.Web.Pages.Admin.Books
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public BookEditModel Input { get; set; }

        public async Task<IActionResult> OnGet([FromServices] IBookService bookService, int bookId)
        {
            Input=await bookService.GetForEdit(bookId);
            return Page();
        }

        public async Task<IActionResult> OnPost([FromServices] IBookService bookService)
        {
            await bookService.Update(Input);
            return RedirectToPage("Index");
        }
    }
}