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

            ISendGrid email = SendGrid.GenerateInstance();
            email.AddTo("ryan@ryanadamsdesign.com");
            email.From = new MailAddress("new_submission@projexi.com");
            email.Subject = "New project submitted: " + project.ProjectName;
            email.Html = @"<html>
<body>
    <h1>A new project was submitted! Yay!</h1>
    <table style='border-collapse: collapse;'>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Project name:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.ProjectName + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Requested by:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.RequestedBy + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Details and dimensions:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.DetailsAndDimensions + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Deadline:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.Deadline.ToShortDateString() + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>First proof due:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.FirstProofDate.ToShortDateString() + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Key objective/Call to action:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.KeyObjective + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Key graphics needed:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.KeyGraphicsNeeded + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Target audience:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.TargetAudience + @"</td>
        </tr>
        <tr>
            <td style='border: 1px solid #CCC; padding: 5px;'><b>Additional comments:</b></td>
            <td style='border: 1px solid #CCC; padding: 5px;'>" + project.AdditionalComments + @"</td>
        </tr>
    </table>
</body>
</html>";

            SMTP server = SMTP.GenerateInstance(new NetworkCredential("ba04776e-78bc-479a-a2a0-8035d31e119a@apphb.com", "7tydml1z"));
            server.Deliver(email);

            return View("EmailResult");
        }
    }
}
