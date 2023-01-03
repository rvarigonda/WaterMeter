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
    public class AddDeviceController : Controller
    {
        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        // GET: AddUser
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AddDeviceModel device)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                if (AddDeviceBool(device))
                {
                    ViewBag.Message = "Device details added successfully";
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
        public bool AddDeviceBool(AddDeviceModel obj)
        {

            using (var connection = new SqlConnection(con))
            {
                //string commandText = "select * from Users where Name=@name and Password=@Password";

                SqlCommand com = new SqlCommand("AddNewDeviceDetails", connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Selected", obj.Selected);
                com.Parameters.AddWithValue("@DeviceID", obj.DeviceID);
                com.Parameters.AddWithValue("@SerialID", obj.SerialID);
                com.Parameters.AddWithValue("@Type", obj.Type);
                com.Parameters.AddWithValue("@Network", obj.Network);
                com.Parameters.AddWithValue("@PIN", obj.PIN);
                com.Parameters.AddWithValue("@Country", obj.Country);
                com.Parameters.AddWithValue("@LeakageLimit", obj.LeakageLimit);
                com.Parameters.AddWithValue("@DTT", obj.DTT);

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