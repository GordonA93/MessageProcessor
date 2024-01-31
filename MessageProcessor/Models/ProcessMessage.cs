using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MessageProcessor.Models
{
    public class ProcessMessage
    {
        public IActionResult ProcessSubject()
        {
            List<string> msgSubject = new List<string>();

            return (IActionResult)msgSubject;

        }
    }
}
