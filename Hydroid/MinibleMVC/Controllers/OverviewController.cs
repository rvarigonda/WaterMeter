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
    public class OverviewController : Controller
    {
        // GET: Overview
        string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public ActionResult Index()
        {
            using (var connection = new SqlConnection(con))
            {
                SyncDatumModel objSyncDatumModel = new SyncDatumModel();
                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand("getSync_datum", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@status", "GET");
                    cmd.Parameters.AddWithValue("@Created_By", "Service");
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    List<SyncDatumModel> data = new List<SyncDatumModel>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        SyncDatumModel uobj = new SyncDatumModel();
                        uobj.Id = ds.Tables[0].Rows[i]["Id"].ToString();
                        uobj.Device_Id = ds.Tables[0].Rows[i]["Device_Id"].ToString();
                        uobj.Time = ds.Tables[0].Rows[i]["Time"].ToString();
                        uobj.Serial = ds.Tables[0].Rows[i]["Serial"].ToString();
                        uobj.PayLoad_Base64 = ds.Tables[0].Rows[i]["PayLoad_Base64"].ToString();
                        
                        uobj.PayLoad_ASCII = ds.Tables[0].Rows[i]["PayLoad_ASCII"].ToString();
                        uobj.Status = ds.Tables[0].Rows[i]["Status"].ToString();
                        
                        uobj.Status = ds.Tables[0].Rows[i]["Status"].ToString();
                        uobj.Created_By = ds.Tables[0].Rows[i]["Created_By"].ToString();
                        uobj.Created_Date = ds.Tables[0].Rows[i]["Created_Date"].ToString();
                        uobj.Modified_By = ds.Tables[0].Rows[i]["Modified_By"].ToString();
                        uobj.Modified_Date = ds.Tables[0].Rows[i]["Modified_Date"].ToString();
                        uobj.Application_Id = ds.Tables[0].Rows[i]["Application_Id"].ToString();
                        data.Add(uobj);
                    }
                    objSyncDatumModel.SyncDatumList = data;
                }
                connection.Close();
                return View(objSyncDatumModel);
            }
        }
    }
}