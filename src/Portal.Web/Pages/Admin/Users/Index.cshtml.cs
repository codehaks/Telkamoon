using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Domain.Models;

namespace Portal.Web.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        public IList<ApplicationUser> Output { get; set; }
        public void OnGet([FromServices] UserManager<ApplicationUser> userManager)
        {
            Output = userManager.Users.ToList();
        }
    }
}