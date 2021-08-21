using System;
using System.Threading.Tasks;

namespace EmailSender
{
    public interface IEmailService
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
