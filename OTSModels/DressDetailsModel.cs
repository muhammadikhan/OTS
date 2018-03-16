using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class DressDetailsModel 
    {
        public int DressDetails_ID { get; set; }
        public int DressCategory_ID { get; set; }
        public int DressType_ID { get; set; }
        public int DressStyle_ID { get; set; }
        public int Dimension_ID { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
	}
}
    