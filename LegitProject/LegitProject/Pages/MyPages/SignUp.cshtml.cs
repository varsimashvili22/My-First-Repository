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
        [BindProperty]
        public string ErrorMassage { get; set; } = "";

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (_context.GetUserByUsername(UserModel.Username) != null)
            {
                ErrorMassage = "Username already exists!";
                return Page();
            }
            if (UserModel.Username.IsNullOrEmpty())
            {
                ErrorMassage = "Enter Username!";
                return Page();
            }
            if (UserModel.Password.IsNullOrEmpty())
            {
                ErrorMassage = "Enter Password!";
                return Page();
            }
            
            await _context.SaveChangesAsync();
            return RedirectToPage("./SignIn");
        }
    }

}

