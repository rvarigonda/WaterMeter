using Minible5.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class AuthController : Controller
    {

        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        // GET: /Auth/
        [ActionName("login")]
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult login(LoginViewModel LoginViewModel)
        {

            if (IsValidUser(LoginViewModel.Name, LoginViewModel.Password))
            {
                Session.Clear();
                string role = string.Empty;
                if (Validate_User(LoginViewModel, out role))
                {
                    if (role == "Admin")
                    {
                        Session["AdminLogin"] = true;
                        return RedirectToAction("index", "Overview");

                    }
                    else if (role == "User")
                    {
                        Session["User"] = "User";
                        return RedirectToAction("apex", "chart");
                    }
                    else if(role == "SuperAdmin")
                    {
                        Session["SuperAdmin"] = "SuperAdmin";
                        return RedirectToAction("Index", "Dashboard");
                    }
                }


            }
            else
            {
                TempData["Message"] = "Login failed.User name or password doesn't exist.";
                return View("login");

            }
            return View("login");
        }

        [ActionName("register")]
        public ActionResult register()
        {
            return View();
        }

        [ActionName("recoverpassword")]
        public ActionResult recoverpassword()
        {
            return View();
        }

        [ActionName("lockscreen")]
        public ActionResult lockscreen()
        {
            return View();
        }

        private bool IsValidUser(string name, string password)
        {
            bool IsValid = false;
            using (var connection = new SqlConnection(con))
            {
                string commandText = "select * from Users where Name=@name and Password=@Password";

                using (var cmd = new SqlCommand(commandText, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (dt.Rows.Count > 0)
                    {
                        IsValid = true;
                    }


                }
            }
            return IsValid;

        }
        public bool Validate_User(LoginViewModel lmodel, out string userRole)
        {
            using (var connection = new SqlConnection(con))
            {

                SqlCommand cmd = new SqlCommand("Login");

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", lmodel.Name);
                cmd.Parameters.AddWithValue("@Password", lmodel.Password);
                cmd.Connection = connection;
                connection.Open();
                userRole = cmd.ExecuteScalar().ToString();
                connection.Close();

                return !String.IsNullOrEmpty(userRole);

            }

        }
    }
}