using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Domain.Models;

namespace Portal.Web.Pages.Chat
{
    public class UserModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public string FromUser { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public async Task<IActionResult> OnGet(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            UserId = user.Id;

            UserName = userName;
            FromUser = User.Identity.Name;
            return Page();
        }
    }
}