using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minible5.Models
{

    public class AddDeviceModel : Controller
    {

        public string Selected { get; set; }


        public string DeviceID { get; set; }

        public string SerialID { get; set; }

        public string Type { get; set; }

        public string Network { get; set; }

        public string PIN { get; set; }

        public string Country { get; set; }
        
        

        public string LeakageLimit { get; set; }

        public string DTT { get; set; }

    }
}