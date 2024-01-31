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
		public MsgDetails? EmailDetails { get; set; }
		public StoreData? gatherEmailInfo = new StoreData();

		public void OnGet()
        {
            EmailDetails = new MsgDetails();
            gatherEmailInfo = new StoreData();
   
        }
        public IActionResult OnPost()
        {
			if (!ModelState.IsValid)
			{
				return Page();

			}

			string? emailSender = EmailDetails.MsgId;
            string? emailSubject = EmailDetails.Subject;
			string? emailBody = EmailDetails.MsgBody;
			string? emailReceiver = EmailDetails.MsgReciever;

			gatherEmailInfo.storeSender.Add(emailSender);
            Console.WriteLine($"Sender {emailSender} was added to list");
            gatherEmailInfo.storeSubject.Add(emailSubject);
			Console.WriteLine($"Subject {emailSubject} was added to list");
			gatherEmailInfo.storeBody.Add(emailBody);
			Console.WriteLine($"Subject {emailBody} was added to list");
			gatherEmailInfo.storeSubject.Add(emailReceiver);
			Console.WriteLine($"Subject {emailReceiver} was added to list");

			return Page();
        }
    }
}