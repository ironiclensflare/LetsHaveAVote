using System.Web.Mvc;
using LetsHaveAVote.Controllers;
using NUnit.Framework;

namespace LetsHaveAVote.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            var controller = new HomeController();

            var result = controller.About() as ViewResult;

            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            var controller = new HomeController();

            var result = controller.Contact() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
