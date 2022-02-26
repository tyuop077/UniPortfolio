using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortfolio.Misc.Services.EmailService
{
    public interface IEmailService
    {
        Task Send(string email, string subject, string message);
    }
}
