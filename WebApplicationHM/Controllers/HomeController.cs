using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHM.Models;
using WebApplicationHM.DAL;

namespace WebApplicationHM.Controllers
{
    public class HomeController : Controller
    {
        HamyDataContext database = new HamyDataContext();
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Family()
        {
            // retrieve all posts from database
            List<Post> posts = database.Posts.ToList();

            return View(posts);
        }
    }
}