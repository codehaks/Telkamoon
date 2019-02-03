using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Books;
using Portal.Application.Books.Models;
using System.Threading.Tasks;

namespace Portal.Web.Pages.Admin.Books
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public BookAddModel Input { get; set; }

        public async Task<IActionResult> OnPost([FromServices] IBookService bookService)
        {
            bool result = await bookService.Add(Input);
            return RedirectToPage("index");
        }
    }
}