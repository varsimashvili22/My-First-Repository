using LegitProject.Data;
using LegitProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LegitProject.Pages.MyPages
{
    public class SignInModel : PageModel
    {
        private readonly MyDbContext _context;

        public SignInModel(MyDbContext context)
        {
            _context = context;
        }



        public void OnGet()
        {
            // Retrieve the latest saved username from the database

        }
    }
}
