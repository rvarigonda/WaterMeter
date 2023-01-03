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
    public class TableController : Controller
    {
        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //
        // GET: /Table/
        [ActionName("basic")]
        public ActionResult basic()
        {
            return View();
        }


        [ActionName("responsive")]
        public ActionResult responsive()
        {
            return View();
        }

        [ActionName("editable")]
        public ActionResult editable()
        {
            return View();
        }
        // GET: User
        [ActionName("datatable")]
        public ActionResult datatable()
        {
            using (var connection = new SqlConnection(con))
            {
                AddUserModel objuser = new AddUserModel();
                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand("getUserData", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@status", "GET");
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    List<AddUserModel> userlist = new List<AddUserModel>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        AddUserModel uobj = new AddUserModel();
                        uobj.selected = ds.Tables[0].Rows[i]["selected"].ToString();
                        uobj.ID = ds.Tables[0].Rows[i]["ID"].ToString();
                        uobj.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                        uobj.type = ds.Tables[0].Rows[i]["type"].ToString();
                        uobj.city = ds.Tables[0].Rows[i]["city"].ToString();
                        uobj.post = ds.Tables[0].Rows[i]["post"].ToString();
                        uobj.country = ds.Tables[0].Rows[i]["country"].ToString();
                        uobj.ContactNumber = ds.Tables[0].Rows[i]["ContactNumber"].ToString();
                        uobj.website = ds.Tables[0].Rows[i]["website"].ToString();
                        userlist.Add(uobj);
                    }
                    objuser.usersinfo = userlist;
                }
                connection.Close();
                return View(objuser);
            }





        }
    }
}