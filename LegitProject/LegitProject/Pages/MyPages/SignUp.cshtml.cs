using LegitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LegitProject.Pages.MyPages
{
    public class SignUpModel : PageModel
    {
        public void OnGet()
        {
            
        }

        public IActionResult OnPostSignUp()
        {
            return RedirectToPage();
        }
    }
}

