#pragma warning disable 
using LegitProject.Data;
using LegitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

namespace LegitProject.Pages.MyPages
{
    public class SignInModel : PageModel
    {
        private readonly MyDbContext _context;

        public SignInModel(MyDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public List<User> DataList { get; private set; }

        public void OnGet()
        {
            // Query the database to retrieve the data
            DataList = _context.Users.ToList();
        }
        public IActionResult OnPost()
        {
            if (!Username.IsNullOrEmpty() &&
                _context.GetUserByUsername(Username) != null &&
                _context.GetUserByUsername(Username).Password == Password)
            {
                return RedirectToPage("/Index");
            }
            
            return Page();
        }
    }
}
