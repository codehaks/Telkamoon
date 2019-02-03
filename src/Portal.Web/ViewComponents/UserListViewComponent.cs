using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.ViewComponents
{
    [ViewComponent]
    public class UserListViewComponent:ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserListViewComponent(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);

        }
    }
}
