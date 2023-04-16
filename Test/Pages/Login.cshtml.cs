using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;



namespace Test.Pages
{
    public class LoginModel : PageModel
    {
      
        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
               this.Credential = new Credential { UserName = "admin" };
        }
        public void OnPost()
        {

        }
    }
    public class Credential
    {
        [Required]
        [Display(Name = "Email")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
