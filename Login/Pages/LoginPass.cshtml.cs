using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login.Pages
{
    public class LoginPassModel : PageModel
    {
        [BindProperty]
        public string UserInput { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
