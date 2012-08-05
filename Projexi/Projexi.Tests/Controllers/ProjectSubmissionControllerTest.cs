using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projexi.Controllers;
using Projexi.Models;

namespace Projexi.Tests.Controllers {
    [TestClass]
    public class ProjectSubmissionControllerTest {
        [TestMethod]
        public void Index_Get_Should_Return_ProjectSubmission_Model() {
            ProjectSubmissionController controller = new ProjectSubmissionController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result.Model);
            Assert.AreEqual(typeof(ProjectSubmission), (result.Model).GetType());
        }

        [TestMethod, Ignore]
        public void Index_Post() {

        }
    }
}
