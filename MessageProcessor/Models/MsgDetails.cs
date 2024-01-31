using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MessageProcessor.Models
{
    public class MsgDetails
    {
	    [Required(ErrorMessage = "Sender is required")]
		public string? MsgId { get; set; }

        //[Required(ErrorMessage = "Message Body is required")]
        public string? MsgBody { get; set; }

        //[Required(ErrorMessage = "Type is required")]
        public string? MsgType { get; set; }

        //[Required(ErrorMessage = "Reciever is required")]
        public string? MsgReciever { get; set; }

        //[Required(ErrorMessage = "Subject is required")]
        public string? Subject { get; set; }

    }
}
