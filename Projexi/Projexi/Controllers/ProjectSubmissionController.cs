using System;
using System.Web.Mvc;
using Projexi.Models;

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
            // TODO Send an email with the project in it
            return View();
        }
    }
}
