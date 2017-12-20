using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIOTCA3.DataContexts;
using AIOTCA3.Entities;

namespace AIOTCA3.Controllers
{
    public class HomeController : Controller
    {
        private PostsDb db = new PostsDb();

        public ActionResult Index()
        {

            return View(db.Posts.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Post(int? id)
        {
            ViewBag.Message = "Your Post page.";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
    }
}