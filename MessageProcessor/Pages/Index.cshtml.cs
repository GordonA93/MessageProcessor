using MessageProcessor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MessageProcessor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProcessSender _processSender;

        public IndexModel(ProcessSender processSender)
        {
            _processSender = processSender;
        }

        [BindProperty]
		public MsgDetails MessageDetails { get; set; }
       
        public void OnGet()
        {
            MessageDetails = new MsgDetails();

        }

        public IActionResult OnPost()
        {
			if (!ModelState.IsValid)
            {
                return Page();
     
            }

			string sender = MessageDetails.MsgId;
            return _processSender.ProcessInput(sender);
        }
    }
}