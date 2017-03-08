using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_System.Models;

namespace Library_System.Controllers
{
    public class UserController : Controller
    {
        private Db db;
        public UserController()
        {
            db = new Db();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel form)
        {
            var UserExist = db.Users.FirstOrDefault(u => form.Email == u.Email);
            if (UserExist != null)
            {
                ViewBag.error = "Ya existe un usuario con ese Email.";
                return View();
            }

            var user = new Users();
            user.Name = form.Name;
            user.LastName = form.LastName;
            user.Email = form.Email;
            user.Password = form.Password;
            user.Role = Convert.ToInt32(Utils.Roles.User);
            user.CreatedAt = DateTime.Now.ToString();

            db.Users.Add(user);
            db.SaveChanges();

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel form)
        {
            var user = db.Users.FirstOrDefault(u => form.Email == u.Email && form.Password == u.Password);
            if (user == null)
            {
                ViewBag.error = "Usuario o Contraseña son incorrectos.";
                return View();
            }

            HttpCookie userId = new HttpCookie("userId", user.Id.ToString());
            HttpCookie userEmail = new HttpCookie("userEmail", user.Email);
            HttpCookie userRole = new HttpCookie("userRole", user.Role.ToString());
            Response.SetCookie(userId);
            Response.SetCookie(userEmail);
            Response.SetCookie(userRole);

            return Redirect("/Home");
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
    }
}