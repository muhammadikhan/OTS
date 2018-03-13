using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;

namespace OTS.Controllers
{
    public class DimensionController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations

        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DimensionModel ObjDimensionModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedDimensionId = 0;
                CreatedDimensionId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDimensionModel, CreatedDimensionId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<DimensionModel> ObjDimensionModel = new List<DimensionModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjDimensionModel = (List<DimensionModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDimensionModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjDimensionModel);
        }

        #endregion

        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<DimensionModel> ObjDimensionModel = new List<DimensionModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjDimensionModel = (List<DimensionModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDimensionModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjDimensionModel.Count > 0)
                    return View(ObjDimensionModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, DimensionModel ObjInputDimensionModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedDimensionId = 0;
                UpdatedDimensionId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputDimensionModel, UpdatedDimensionId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<DimensionModel> ObjDimensionModel = new List<DimensionModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjDimensionModel = (List<DimensionModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDimensionModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjDimensionModel.Count > 0)
                    return View(ObjDimensionModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, DimensionModel ObjInputDimensionModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedDimensionId = 0;
                DeletedDimensionId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputDimensionModel, DeletedDimensionId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
