using LegitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LegitProject.Pages.MyPages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public MyModels MyModel { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostSignUp(string username, string password)
        {
            // Validate username and password
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError(string.Empty, "Username and password are required.");
                return Page();
            }

            // Check if username already exists (you'll need to implement your logic here)

            // If all validations pass, perform signup logic

            return Page(); 
        }
    }
}
