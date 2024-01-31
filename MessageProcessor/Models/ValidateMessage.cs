namespace MessageProcessor.Models
{
	public abstract class ValidateMessage
	{
		public abstract bool ValidateMsg(
			string emailSender,
			string emailSubject,
			string emailBody,
			string emailReceiver);

	}

	public class Email : ValidateMessage
	{
		public override bool ValidateMsg(
			string emailSender,
			string emailSubject,
			string emailBody,
			string emailReceiver)
		{
			if (emailBody.Length <= 2000)
			{
				return false;
			}
			if (emailSubject.Length <= 50)
			{
				return false;
			}
			if (!emailSender.Contains("@") || emailSender.Contains(".com"))
			{
				return false;
			}
			if (!emailReceiver.Contains("@") || emailReceiver.Contains(".com"))
			{
				return false;
			}

			return true;
		}
	}


}