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
    public class FormsController : Controller
    {
        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //
        // GET: /Forms/
        [ActionName("elements")]
        public ActionResult elements()
        {
            return View();
        }

        [ActionName("validation")]
        public ActionResult validation()
        {
            return View();
        }

        [ActionName("advanced")]
        public ActionResult advanced()
        {
            return View();
        }

        [ActionName("editors")]
        public ActionResult editors()
        {
            return View();
        }

        [ActionName("uploads")]
        public ActionResult uploads()
        {
            return View();
        }

        [ActionName("xeditable")]
        public ActionResult xeditable()
        {
            return View();
        }

        [ActionName("repeater")]
        public ActionResult repeater()
        {
            return View();
        }

        [ActionName("wizard")]
        public ActionResult wizard()
        {
            return View();
        }

        [ActionName("mask")]
        public ActionResult mask()
        {
            return View();
        }


        [HttpPost]
        public ActionResult wizard(AddOrganisationModel LoginViewModel)
        {
            if (AddUserBool(LoginViewModel))
            {
                ViewBag.Message = "Org details added successfully";
                return RedirectToAction("index", "Overview");

            }
            return View("index");
        }

        public bool AddUserBool(AddOrganisationModel obj)
        {
            using (var connection = new SqlConnection(con))
            {




                //string commandText = "select * from Users where Name=@name and Password=@Password";                
                SqlCommand com = new SqlCommand("AddNewOrgDetails", connection);

                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Org_Select", obj.Org_Select);
                com.Parameters.AddWithValue("@Org_ID", obj.Org_ID);
                com.Parameters.AddWithValue("@Org_Name", obj.Org_Name);
                com.Parameters.AddWithValue("@Org_Type", obj.Org_Type);
                com.Parameters.AddWithValue("@Org_Address", obj.Org_Address);
                com.Parameters.AddWithValue("@Org_City", obj.Org_City);
                com.Parameters.AddWithValue("@Org_Post", obj.Org_Post);
                com.Parameters.AddWithValue("@Org_Country", obj.Org_Country);
                com.Parameters.AddWithValue("@Org_ContactNumber", obj.Org_ContactNumber);
                com.Parameters.AddWithValue("@Org_Website", obj.Org_Website);
                com.Parameters.AddWithValue("@Apt_Select", obj.Apt_Select);
                com.Parameters.AddWithValue("@Apt_ID", obj.Apt_ID);
                com.Parameters.AddWithValue("@Apt_Name", obj.Apt_Name);
                com.Parameters.AddWithValue("@SelectOrganisation", obj.SelectOrganisation);
                com.Parameters.AddWithValue("Bld_Select", obj.Bld_Select);
                com.Parameters.AddWithValue("Bld_ID", obj.Bld_ID);
                com.Parameters.AddWithValue("@Bld_Name", obj.Bld_Name);
                com.Parameters.AddWithValue("@SelectAptComplex", obj.SelectAptComplex);
                com.Parameters.AddWithValue("@Floor_Select", obj.Floor_Select);
                com.Parameters.AddWithValue("@Floor_ID", obj.Floor_ID);
                com.Parameters.AddWithValue("@Floor_Name", obj.Floor_Name);
                com.Parameters.AddWithValue("@Floor_SelectOrganisation", obj.Floor_SelectOrganisation);
                com.Parameters.AddWithValue("@Unit_Select", obj.Unit_Select);
                com.Parameters.AddWithValue("@Unit_ID", obj.Unit_ID);
                com.Parameters.AddWithValue("@Unit_Name", obj.Unit_Name);
                com.Parameters.AddWithValue("@UnitDeviceMapping_Select", obj.UnitDeviceMapping_Select);
                com.Parameters.AddWithValue("@SelectDevice", obj.SelectDevice);




           
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