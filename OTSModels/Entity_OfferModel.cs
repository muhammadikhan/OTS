using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class Entity_OfferModel 
    {
        public int Entity_Offer_ID { get; set; }
        public int Entity_ID { get; set; }
        public int Offer_ID { get; set; }
        public int DressDetails_ID { get; set; }
        public int Rate { get; set; }
        public string Percentage_Discount { get; set; }
        public string Flat_Discount { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
	}
}
    