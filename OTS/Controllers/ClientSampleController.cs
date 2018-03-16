using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;
namespace OTS.Controllers
{
    public class ClientSampleController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ClientSampleModel ObjClientSampleModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedClientSampleId = 0;
                CreatedClientSampleId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjClientSampleModel, CreatedClientSampleId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
        }
        #endregion
        #region Read / Select
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>List of all records.</returns>
        [HttpGet]
        public ActionResult Index(int? id = null)
        {
            List<ClientSampleModel> ObjClientSampleModel = new List<ClientSampleModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjClientSampleModel = (List<ClientSampleModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjClientSampleModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjClientSampleModel);
        }
        #endregion
        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<ClientSampleModel> ObjClientSampleModel = new List<ClientSampleModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjClientSampleModel = (List<ClientSampleModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjClientSampleModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjClientSampleModel.Count > 0)
                    return View(ObjClientSampleModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, ClientSampleModel ObjInputClientSampleModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedClientSampleId = 0;
                UpdatedClientSampleId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputClientSampleModel, UpdatedClientSampleId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
        }
        #endregion
        #region Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<ClientSampleModel> ObjClientSampleModel = new List<ClientSampleModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjClientSampleModel = (List<ClientSampleModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjClientSampleModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjClientSampleModel.Count > 0)
                    return View(ObjClientSampleModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, ClientSampleModel ObjInputClientSampleModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedClientSampleId = 0;
                DeletedClientSampleId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputClientSampleModel, DeletedClientSampleId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
        }
        #endregion
        #endregion
    }
}
