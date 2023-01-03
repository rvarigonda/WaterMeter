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
    public class ChartController : Controller
    {
        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        //
        // GET: /Chart/
        [ActionName("apex")]
        public ActionResult apex()
        {
            using (var connection = new SqlConnection(con))
            {
                SyncDatumModel objSyncDatumModel = new SyncDatumModel();
                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand("getSync_datum", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@Device_Id", "ittilademo");
                    // cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@Serial", 1);
                    //cmd.Parameters.AddWithValue("@PayLoad_Base64", "MTFfMTFfMTFfMTFfMTFfMTFfMA==");
                    //cmd.Parameters.AddWithValue("@PayLoad_ASCII", "11_11_11_11_11_11_0");
                    //cmd.Parameters.AddWithValue("@Status", 1);
                    cmd.Parameters.AddWithValue("@Created_By", "Service");
                    //cmd.Parameters.AddWithValue("@Created_Date", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@Modified_By", "1000");
                    //cmd.Parameters.AddWithValue("@Modified_Date", DateTime.Now);
                    //cmd.Parameters.AddWithValue("@Application_Id", "watermeter");

                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    List<SyncDatumModel> data = new List<SyncDatumModel>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        SyncDatumModel uobj = new SyncDatumModel();
                        uobj.Device_Id = ds.Tables[0].Rows[i]["Id"].ToString();
                        uobj.PayLoad_ASCII = ds.Tables[0].Rows[i]["PayLoad_ASCII"].ToString();
                        data.Add(uobj);
                    }
                    objSyncDatumModel.SyncDatumList = data;
                }
                connection.Close();
                return View(objSyncDatumModel);
            }
        }


        [ActionName("chartjs")]
        public ActionResult chartjs()
        {
            return View();
        }

        [ActionName("flot")]
        public ActionResult flot()
        {
            return View();
        }

        [ActionName("knob")]
        public ActionResult knob()
        {
            return View();
        }

        [ActionName("sparkline")]
        public ActionResult sparkline()
        {
            return View();
        }
	}
}