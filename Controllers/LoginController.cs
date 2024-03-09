using Albergo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Albergo.Controllers
{
    public class LoginController : Controller
    {


        // GET: Login
        public ActionResult Index()
        {

            if (HttpContext.User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();

        }

        [HttpPost]
        public ActionResult Index(Admin user, bool keepLogged)
        {
            try
            {
                Db.conn.Open();
                var command = new SqlCommand(@"
                SELECT *
                FROM Admins
                WHERE Email = @email AND Password = @password
            ", Db.conn);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@password", user.Password);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    FormsAuthentication.SetAuthCookie(reader["Admin_ID"].ToString(), keepLogged);
                    return RedirectToAction("Index", "Home");
                }
            }
            catch
            {

            }
            finally { Db.conn.Close(); }

            TempData["ErrorLogin"] = true;
            return RedirectToAction("Index");

        }

        //Logout
        [Authorize, HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }



    }
}