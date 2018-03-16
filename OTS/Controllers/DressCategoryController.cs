using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;
namespace OTS.Controllers
{
    public class DressCategoryController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DressCategoryModel ObjDressCategoryModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedDressCategoryId = 0;
                CreatedDressCategoryId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressCategoryModel, CreatedDressCategoryId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<DressCategoryModel> ObjDressCategoryModel = new List<DressCategoryModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjDressCategoryModel = (List<DressCategoryModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressCategoryModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjDressCategoryModel);
        }
        #endregion
        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<DressCategoryModel> ObjDressCategoryModel = new List<DressCategoryModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjDressCategoryModel = (List<DressCategoryModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressCategoryModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjDressCategoryModel.Count > 0)
                    return View(ObjDressCategoryModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, DressCategoryModel ObjInputDressCategoryModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedDressCategoryId = 0;
                UpdatedDressCategoryId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputDressCategoryModel, UpdatedDressCategoryId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<DressCategoryModel> ObjDressCategoryModel = new List<DressCategoryModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjDressCategoryModel = (List<DressCategoryModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjDressCategoryModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjDressCategoryModel.Count > 0)
                    return View(ObjDressCategoryModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, DressCategoryModel ObjInputDressCategoryModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedDressCategoryId = 0;
                DeletedDressCategoryId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputDressCategoryModel, DeletedDressCategoryId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
