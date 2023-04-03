using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;
using TestWebApplication.Models;

namespace TestWebApplication.Pages
{
    public class LoginModel : PageModel
    {

        private string Username = "Admin";

        public LoginModel()
        {
            Input = new();
        }
        
        [BindProperty]
        public LoginInputModel Input { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (Input.Username.Equals(Username))
            {
                if (Input.Password.Equals("1234"))
                {
                    return RedirectToPage("/Index");
                }
            }

            return Page();
        }
    }
}
