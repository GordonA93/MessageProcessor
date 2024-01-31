using MessageProcessor.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MessageProcessor.Pages
{
    public class EmailModel : PageModel
    {
        [BindProperty]
		[StringLength(50, MinimumLength = 1, ErrorMessage = "The field must be between 2 and 50 characters.")]
		public MsgDetails? EmailDetails { get; set; }
        [BindProperty]
        public MsgDetails? Subject { get; set; }
        public void OnGet()
        {
            EmailDetails = new MsgDetails();
        }
        public IActionResult OnPost()
        {
			if (!ModelState.IsValid)
			{
				return Page();

			}

			string? emailSender = EmailDetails.MsgId;
            string? emailSubject = EmailDetails.Subject;

            return Page();
        }
    }
}
