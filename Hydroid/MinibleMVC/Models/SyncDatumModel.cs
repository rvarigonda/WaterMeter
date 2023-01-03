using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minible5.Models
{
    public class SyncDatumModel : Controller
    {
        internal string Payload;
        public string Id { get; set; }
        public string Device_Id { get; set; }
        public string Time { get; set; }
        public string Serial { get; set; }
        public string PayLoad_Base64 { get; set; }
        public string PayLoad_ASCII { get; set; }
        public string Status { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Date { get; set; }
        public string Application_Id { get; set; }


        public List<SyncDatumModel> SyncDatumList { get; set; } = new List<SyncDatumModel>();
        
        
    }   
    
}