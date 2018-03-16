using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class DimensionModel 
    {
        public int Dimension_ID { get; set; }
        public string Dimension_Name { get; set; }
        public int Dimension_Value { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public bool Deleted { get; set; }  
	}
}
    