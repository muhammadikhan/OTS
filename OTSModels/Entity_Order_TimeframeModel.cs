using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class Entity_Order_TimeframeModel 
    {
        public int OrderTimeframe_ID { get; set; }
        public int Order_ID { get; set; }
        public int Entity_ID { get; set; }
        public System.DateTime Estimated_DateTime { get; set; }
        public System.DateTime Actual_DateTime { get; set; }
        public System.DateTime Pick { get; set; }
        public System.DateTime Drop { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }
	}
}
    