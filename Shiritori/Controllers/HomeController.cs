using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Shiritori.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetPossibleWords(string baseLetters)
        {
            
            ShiritoriBusiness biz = new ShiritoriBusiness();

            List<string> words = biz.GetFourLetterList(baseLetters);

            return Json(new { Words = words });
        }
	}
}