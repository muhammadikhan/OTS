using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;
namespace OTS.Controllers
{
    public class StatusController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StatusModel ObjStatusModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedStatusId = 0;
                CreatedStatusId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjStatusModel, CreatedStatusId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<StatusModel> ObjStatusModel = new List<StatusModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjStatusModel = (List<StatusModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjStatusModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjStatusModel);
        }
        #endregion
        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<StatusModel> ObjStatusModel = new List<StatusModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjStatusModel = (List<StatusModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjStatusModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjStatusModel.Count > 0)
                    return View(ObjStatusModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, StatusModel ObjInputStatusModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedStatusId = 0;
                UpdatedStatusId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputStatusModel, UpdatedStatusId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<StatusModel> ObjStatusModel = new List<StatusModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjStatusModel = (List<StatusModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjStatusModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjStatusModel.Count > 0)
                    return View(ObjStatusModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, StatusModel ObjInputStatusModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedStatusId = 0;
                DeletedStatusId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputStatusModel, DeletedStatusId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
