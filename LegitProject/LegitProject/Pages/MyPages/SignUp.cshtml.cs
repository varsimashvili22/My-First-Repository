using LegitProject.Data;
using LegitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            if (ModelState.IsValid)
            {
                // Save the user to the database
                _context.Users.Add(UserModel);
                _context.SaveChanges();

                return RedirectToPage("/MyPages/SignIn");
            }

            return RedirectToPage("/MyPages/SignIn");
        }
    }
}

