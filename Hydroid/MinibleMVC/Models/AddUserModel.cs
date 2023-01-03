using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minible5.Models
{
    public class AddUserModel : Controller
    {

        public string selected { get; set; }

        public string ID { get; set; }


        public string Name { get; set; }

        public string type { get; set; }

        public string city { get; set; }

        public string post { get; set; }

        public string country { get; set; }

        public string ContactNumber { get; set; }

        public string website { get; set; }

        public List<AddUserModel> usersinfo { get; set; }
    }   
    
}