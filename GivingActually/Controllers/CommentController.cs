using GivingActually.Models;
using GivingActually.Models.HelperModels;
using GivingActually.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GivingActually.Controllers
{
    public class CommentController : Controller
    {
        CommonService IService = new CommonService();
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetUsers(string username)
        {
            UserModel user = IService.GetUserDetail();

            if (user != null)
            {
                Session["UserID"] = user.Id;
                return RedirectToAction("GetPosts");
            }

            ViewBag.Msg = "Username does not exist !";
            return View();
        }
    }
}