using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OTSAPI.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string Index(int? id = null)
        {
            if (id != null)
                return id.ToString();
            else
                return "This is a test Api Call. You can also pass it ID as parameter.";
        }
        [HttpGet]
        public string Summary()
        {
            string response = "Start<br>";
            try
            {
                response += "<b>ConnectionString : </b>" + GlobalSettings.GetConnectionString;
            }
            catch (Exception ex)
            {
                response += ex.ToString() + "<br>";
            }

            return response;
        }
        [HttpGet]
        public string DetailLog()
        {
            return "No Detail Log Found at the moment.";
        }

    }

}
