namespace _0_Framework.Application.Email
{
    public interface IEmailService
    {
        void SendEmail(string title, string messageBody, string destination);
    }
}