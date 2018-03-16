using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class LocationsModel 
    {
        public int Location_ID { get; set; }
        public int Area_ID { get; set; }
        public int Map_ID { get; set; }
        public int City_ID { get; set; }
        public int Country_ID { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
	}
}
    