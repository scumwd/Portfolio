namespace Portfolio.Misc.Services.Email_Service;

public interface IEmailService
{
    void SendEmail(Message message);
}