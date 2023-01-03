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
    public class AddUserController : Controller
    {
        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        // GET: AddUser
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AddUserModel user)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                if (AddUserBool(user))
                {
                    ViewBag.Message = "Employee details added successfully";
                    //}
                }

                return View();
            }
            catch (Exception ex)
            
            {
                throw ex;
            }
        }


        //To Add Employee details
        public bool AddUserBool(AddUserModel obj)
        {

            using (var connection = new SqlConnection(con))
            {
                //string commandText = "select * from Users where Name=@name and Password=@Password";

                SqlCommand com = new SqlCommand("AddNewUsersDetails", connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@selected", obj.selected);
                com.Parameters.AddWithValue("@ID", obj.ID);
                com.Parameters.AddWithValue("@Name", obj.Name);
                com.Parameters.AddWithValue("@type", obj.type);
                com.Parameters.AddWithValue("@city", obj.city);
                com.Parameters.AddWithValue("@post", obj.post);
                com.Parameters.AddWithValue("@country", obj.country);
                com.Parameters.AddWithValue("@ContactNumber", obj.ContactNumber);
                com.Parameters.AddWithValue("@website", obj.website);

                connection.Open();
                int i = com.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {

                    return true;

                }
                else
                {

                    return false;
                }
            }

        }
    }
}