using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minible5.Models
{
    public class AddOrganisationModel
    {
		public string Org_Select { get; set; }
		public string Org_ID { get; set; }
		public string Org_Name { get; set; }
		public string Org_Type { get; set; }
		public string Org_Address { get; set; }
		public string Org_City { get; set; }
		public string Org_Post { get; set; }
		public string Org_Country { get; set; }
		public string Org_ContactNumber { get; set; }
		public string Org_Website { get; set; }
		public string Apt_Select { get; set; }
		public string Apt_ID { get; set; }
		public string Apt_Name { get; set; }
		public string SelectOrganisation { get; set; }
		public string Bld_Select { get; set; }
		public string Bld_ID { get; set; }
		public string Bld_Name { get; set; }
		public string SelectAptComplex { get; set; }
		public string Floor_Select { get; set; }
		public string Floor_ID { get; set; }
		public string Floor_Name { get; set; }
		public string Floor_SelectOrganisation { get; set; }
		public string Unit_Select { get; set; }
		public string Unit_ID { get; set; }
		public string Unit_Name { get; set; }
		public string UnitDeviceMapping_Select { get; set; }
		public string SelectDevice { get; set; }
	}
}