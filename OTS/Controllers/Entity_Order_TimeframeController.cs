using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;

namespace OTS.Controllers
{
    public class Entity_Order_TimeframeController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations

        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Entity_Order_TimeframeModel ObjEntity_Order_TimeframeModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedEntity_Order_TimeframeId = 0;
                CreatedEntity_Order_TimeframeId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjEntity_Order_TimeframeModel, CreatedEntity_Order_TimeframeId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<Entity_Order_TimeframeModel> ObjEntity_Order_TimeframeModel = new List<Entity_Order_TimeframeModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjEntity_Order_TimeframeModel = (List<Entity_Order_TimeframeModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjEntity_Order_TimeframeModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjEntity_Order_TimeframeModel);
        }

        #endregion

        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<Entity_Order_TimeframeModel> ObjEntity_Order_TimeframeModel = new List<Entity_Order_TimeframeModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjEntity_Order_TimeframeModel = (List<Entity_Order_TimeframeModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjEntity_Order_TimeframeModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjEntity_Order_TimeframeModel.Count > 0)
                    return View(ObjEntity_Order_TimeframeModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, Entity_Order_TimeframeModel ObjInputEntity_Order_TimeframeModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedEntity_Order_TimeframeId = 0;
                UpdatedEntity_Order_TimeframeId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputEntity_Order_TimeframeModel, UpdatedEntity_Order_TimeframeId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<Entity_Order_TimeframeModel> ObjEntity_Order_TimeframeModel = new List<Entity_Order_TimeframeModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjEntity_Order_TimeframeModel = (List<Entity_Order_TimeframeModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjEntity_Order_TimeframeModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjEntity_Order_TimeframeModel.Count > 0)
                    return View(ObjEntity_Order_TimeframeModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, Entity_Order_TimeframeModel ObjInputEntity_Order_TimeframeModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedEntity_Order_TimeframeId = 0;
                DeletedEntity_Order_TimeframeId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputEntity_Order_TimeframeModel, DeletedEntity_Order_TimeframeId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
