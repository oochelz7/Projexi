using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Projexi.Models;
using System.Net;
using System.Net.Mail;
using System.Text;
using SendGridMail;
using SendGridMail.Transport;

namespace Projexi.Controllers {
    public class ProjectSubmissionController : Controller {
        //
        // GET: /ProjectSubmission/
        [HttpGet]
        public ActionResult Index() {
            ProjectSubmission project = new ProjectSubmission();
            project.Deadline = DateTime.Now;
            project.FirstProofDate = DateTime.Now;
            return View(project);
        }

        //
        // POST: /ProjectSubmission/
        [HttpPost]
        public ActionResult Index(ProjectSubmission project) {
            string username = "ba04776e-78bc-479a-a2a0-8035d31e119a";
            string password = "9o<turtifiC>>p";

            ISendGrid email = SendGrid.GenerateInstance();
            email.AddTo("chelsea@oochelz.com");
            email.From = new MailAddress("blahh@nshdf.com");
            email.Subject = "Yay, mail!";
            email.Html = "<html><p>Hello</p><p>BAnana</p></html>";

            SMTP server = SMTP.GenerateInstance(new NetworkCredential(username, password, "apphb.com"));
            server.Deliver(email);

            return View();
        }
    }
}
