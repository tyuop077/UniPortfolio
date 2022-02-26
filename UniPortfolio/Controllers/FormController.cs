using Microsoft.AspNetCore.Mvc;
using UniPortfolio.Misc.Services.EmailService;
using UniPortfolio.Models;

namespace UniPortfolio.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Submit([FromServices] IEmailService emailService, FeedbackFormModel form)
        {
            emailService.Send(form.Email, form.Subject, form.Message);
            return Ok();
        }
    }
}
