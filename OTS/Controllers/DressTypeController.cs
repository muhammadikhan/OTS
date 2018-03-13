using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;

namespace OTS.Controllers
{
    public class DressTypeController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations

        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DressTypeModel ObjDressTypeModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedDressTypeId = 0;
                CreatedDressTypeId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressTypeModel, CreatedDressTypeId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<DressTypeModel> ObjDressTypeModel = new List<DressTypeModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjDressTypeModel = (List<DressTypeModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressTypeModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjDressTypeModel);
        }

        #endregion

        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<DressTypeModel> ObjDressTypeModel = new List<DressTypeModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjDressTypeModel = (List<DressTypeModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressTypeModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjDressTypeModel.Count > 0)
                    return View(ObjDressTypeModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, DressTypeModel ObjInputDressTypeModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedDressTypeId = 0;
                UpdatedDressTypeId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputDressTypeModel, UpdatedDressTypeId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<DressTypeModel> ObjDressTypeModel = new List<DressTypeModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjDressTypeModel = (List<DressTypeModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressTypeModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjDressTypeModel.Count > 0)
                    return View(ObjDressTypeModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, DressTypeModel ObjInputDressTypeModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedDressTypeId = 0;
                DeletedDressTypeId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputDressTypeModel, DeletedDressTypeId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
