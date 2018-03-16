using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class OrderModel 
    {
        public int Order_ID { get; set; }
        public int Client_ID { get; set; }
        public int C_Rider_ID { get; set; }
        public int Warehouse_ID { get; set; }
        public int T_Rider_ID { get; set; }
        public int Tailor_ID { get; set; }
        public int DressDetails_ID { get; set; }
        public System.Nullable<int> ClientSample_ID { get; set; }
        public int Status_ID { get; set; }
        public string QR_Code { get; set; }
        public string Remarks { get; set; }
        public int Offer_ID { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
	}
}
    