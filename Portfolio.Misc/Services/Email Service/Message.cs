using MimeKit;

namespace Portfolio.Misc.Services.Email_Service;

public class Message
{
    public List<MailboxAddress> To { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

    public Message(IEnumerable<string> to, string subject, string content)
    {
        To = new List<MailboxAddress>();
        To.AddRange(to.Select(x => new MailboxAddress(x, "ibneev2015@mail.ru")));
        Subject = subject;
        Content = content;
    }
}