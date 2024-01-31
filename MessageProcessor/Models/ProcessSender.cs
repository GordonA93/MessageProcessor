using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MessageProcessor.Models
{
    public class ProcessSender
    {
        public IActionResult ProcessInput(string sender)
        {
            if (sender.Contains (".com") || sender.Contains("@"))
            {
                return new RedirectToPageResult("/Email");
            } else
            {
                return new RedirectToPageResult("/Error");
            }
        }
    }
}
