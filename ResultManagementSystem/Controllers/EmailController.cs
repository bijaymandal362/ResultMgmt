
using Microsoft.AspNetCore.Mvc;
using ResultManagementSystem.Models;
using System;
using System.Threading.Tasks;

namespace ResultManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendMail([FromBody] Email email, string senderemail)
        {
            Console.WriteLine("Sending email");
            var client = new System.Net.Mail.SmtpClient("smtp.example.com", 111);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("bijymandal362@gmail.com", "password");
            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress(senderemail);
            mailMessage.To.Add(email.To);
            mailMessage.Body = email.Text;
            await client.SendMailAsync(mailMessage);
            return Ok();
        }
    }
}
