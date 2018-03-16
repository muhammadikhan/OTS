using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class ClientModel
    {
        public int Client_ID { get; set; }
        public string Profile_Name { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Address { get; set; }
        public System.Nullable<int> Contact_Number { get; set; }
        public int Cell_Number { get; set; }
        public int Location_ID { get; set; }
        public string PickUp_Address { get; set; }
        public string Drop_Address { get; set; }
        public string QR_Code { get; set; }
        public int Rating { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
    }
}