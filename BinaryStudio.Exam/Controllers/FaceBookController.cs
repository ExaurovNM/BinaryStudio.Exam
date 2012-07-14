using System.Web.Mvc;



namespace BinaryStudio.Exam.Controllers
{
    [Authorize]
    public class FaceBookController : Controller
    {
        //
        // GET: /FaceBook/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchPeople()
        {
            return View();
        }

    }
}
