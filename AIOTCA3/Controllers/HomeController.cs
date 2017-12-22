using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIOTCA3.DataContexts;
using AIOTCA3.Entities;
using AIOTCA3.Models;

namespace AIOTCA3.Controllers
{
    public class HomeController : Controller
    {
        private PostsDb pdb = new PostsDb();
        private CommentsDb cdb = new CommentsDb();

        public ActionResult Index()
        {

            return View(pdb.Posts.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        // To get Comments and Blog posts
        public ActionResult Post(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = pdb.Posts.Find(id);
            IQueryable<Comment> IComment = cdb.Comments.Where(i => i.Pid == id);
            Comment comment = new Comment();
            PostViewModels viewmodel = new PostViewModels();
            viewmodel.Post = post;
            viewmodel.IComment = IComment;
            viewmodel.Comment = comment;
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(viewmodel);
        }

        //Submitting a comment. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post([Bind(Include = "Id,Poster,Date,Pid,CommentText")] Comment comment, int id)
        {
            if (ModelState.IsValid)
            {
                comment.Pid = id;
                cdb.Comments.Add(comment);
                cdb.SaveChanges();
                return RedirectToAction("Post", id);
            }

            return RedirectToAction("Post", id);
        }

    }
}