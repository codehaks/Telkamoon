using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portal.Web.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        public IList<IdentityUser> Output { get; set; }
        public void OnGet([FromServices] UserManager<IdentityUser> userManager)
        {
            Output = userManager.Users.ToList();
        }
    }
}