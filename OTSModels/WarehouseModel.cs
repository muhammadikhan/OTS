using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class WarehouseModel 
    {
        public int Warehouse_ID { get; set; }
        public string Warehouse_Name { get; set; }
        public string Onwer_Name { get; set; }
        public string Onwer_Details { get; set; }
        public int Landline_Number { get; set; }
        public System.Nullable<int> Fax_Number { get; set; }
        public string Email_Address { get; set; }
        public int Contact_Number { get; set; }
        public System.Nullable<int> Cell_Number { get; set; }
        public int Location_ID { get; set; }
        public string QR_Code { get; set; }
        public int Rating { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
	}
}
    