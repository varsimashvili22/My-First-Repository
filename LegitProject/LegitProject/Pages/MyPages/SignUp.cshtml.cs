#pragma warning disable 
using LegitProject.Data;
using LegitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace LegitProject.Pages.MyPages
{
    public class SignUpModel : PageModel
    {
        private readonly MyDbContext _context;

        public SignUpModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User UserModel { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!UserModel.Username.IsNullOrEmpty() && !UserModel.Password.IsNullOrEmpty() && _context.GetUserByUsername(UserModel.Username) == null)
            {
                _context.Users.Add(UserModel);
                await _context.SaveChangesAsync();

                return RedirectToPage("./SignIn");
            }
            return Page();
        }
    }

}

