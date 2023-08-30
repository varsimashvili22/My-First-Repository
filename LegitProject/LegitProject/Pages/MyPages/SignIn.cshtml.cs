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

        public string? Username { get; set; }

        public void OnGet()
        {
            // Retrieve the latest saved username from the database
            User? latestUser = _context.Users.OrderByDescending(u => u.Id).FirstOrDefault();
            Username = latestUser?.Username;
        }
    }
}
