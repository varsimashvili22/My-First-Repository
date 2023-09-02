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

        public User[] DataList { get; private set; }

        public void OnGet()
        {
            // Query the database to retrieve the data
            DataList = _context.Users.ToArray();
        }
    }
}
