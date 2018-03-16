using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OTS.Model
{
    public class TailorCategoryModel 
    {
        public int TailorCategory_ID { get; set; }
        public string TailorCategory_Name { get; set; }
        public int TailorCategory_Rating { get; set; }
        public int TailorCategory_Days { get; set; }
        public int DressCategory_ID { get; set; }
        public int Tailor_ID { get; set; }
        public System.DateTime Created_DateTime { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Modified_DateTime { get; set; }
        public int Modified_By { get; set; }
        public char Deleted { get; set; }  
	}
}
    