using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnidaysTestAhmedAhmed.Models;

namespace UnidaysTestAhmedAhmed.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult index()
        {

            UserInfoEntities db = new UserInfoEntities();
            //User user = new User();

            //UserViewModel uvm = new UserViewModel();

            return View();
        }
        [HttpPost]
        // SET: /User/
        public ActionResult index(UserViewModel model)
        {

            if (ModelState.IsValid)
            {
                UserInfoEntities db = new UserInfoEntities();

                User user = new User();

                int userId = user.UserId;
                user.EmailAddress = model.EmailAddress;
                user.Password = model.Password;

                db.Users.Add(user);

                db.SaveChanges();

                
                // Submit values to the database
                return RedirectToAction("index");
            }

            return View(model);
            
        }

	}
}