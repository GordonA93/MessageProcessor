using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MessageProcessor.Models
{
    public class ProcessSender
    {
        public IActionResult ProcessInput(string sender)
        {
            if (sender == ".com")
            {
                Console.WriteLine("Redirecting to Email page");
                return new RedirectToPageResult("/Email");
            } else
            {
                Console.WriteLine("Redirecting to Error page");
                return new RedirectToPageResult("/Error");
            }
        }
    }
}
