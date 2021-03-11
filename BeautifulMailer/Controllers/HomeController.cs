using BeautifulMailer.Models;
using BeautifulMailer.Utils;
using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BeautifulMailer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailSender _mailSender;

        public HomeController(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public async Task<IActionResult> Index([FromServices] IFluentEmail mailer)
        {
            //var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
            //{
            //    UseDefaultCredentials = false,
            //    Port = 587,
            //    Credentials = new NetworkCredential("sample@gmail.com", "password_here"),
            //    EnableSsl = true,
            //});

            //Email.DefaultSender = sender;

            //var email = Email
            //    .From("markscodingspot@gmail.com", "Mark's Coding Spot")
            //    .To("coommark@gmail.com", "Mark Melton")
            //    .Subject("Hello there!")
            //    .Body("This is a plain text message using Gmail");

            //try
            //{
            //    await email.SendAsync();
            //}
            //catch(Exception e)
            //{

            //}

            //var email = mailer
            //    .To("coommark@gmail.com", "Mark Melton")
            //    .Subject("Hello there from DI!")
            //    .Body("This is a plain text message using Gmail");

            //await email.SendAsync();

            //_mailSender.SendPlaintextGmail("coommark@gmail.com", "Mark Melton");

            //_mailSender.SendHtmlGmail("coommark@gmail.com", "Mark Melton");

            //_mailSender.SendHtmlWithAttachmentGmail("coommark@gmail.com", "Mark Melton");

            //_mailSender.SendPlaintextSendgrid("coommark@gmail.com", "Mark Melton");

            //_mailSender.SendHtmlSendgrid("coommark@gmail.com", "Mark Melton");

            //_mailSender.SendHtmlWithAttachmentSendgrid("coommark@gmail.com", "Mark Melton");


            IEnumerable<string> sendToEmails = new List<string>
            {
                "coommark@gmail.com",
                "coommark@yahoo.com"
            };
            _mailSender.SendSendgridBulk(sendToEmails); 

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
