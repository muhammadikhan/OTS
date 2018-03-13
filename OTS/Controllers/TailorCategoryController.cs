using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;

namespace OTS.Controllers
{
    public class TailorCategoryController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations

        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TailorCategoryModel ObjTailorCategoryModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedTailorCategoryId = 0;
                CreatedTailorCategoryId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorCategoryModel, CreatedTailorCategoryId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<TailorCategoryModel> ObjTailorCategoryModel = new List<TailorCategoryModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjTailorCategoryModel = (List<TailorCategoryModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorCategoryModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjTailorCategoryModel);
        }

        #endregion

        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<TailorCategoryModel> ObjTailorCategoryModel = new List<TailorCategoryModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjTailorCategoryModel = (List<TailorCategoryModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorCategoryModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjTailorCategoryModel.Count > 0)
                    return View(ObjTailorCategoryModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, TailorCategoryModel ObjInputTailorCategoryModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedTailorCategoryId = 0;
                UpdatedTailorCategoryId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputTailorCategoryModel, UpdatedTailorCategoryId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<TailorCategoryModel> ObjTailorCategoryModel = new List<TailorCategoryModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjTailorCategoryModel = (List<TailorCategoryModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorCategoryModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjTailorCategoryModel.Count > 0)
                    return View(ObjTailorCategoryModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, TailorCategoryModel ObjInputTailorCategoryModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedTailorCategoryId = 0;
                DeletedTailorCategoryId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputTailorCategoryModel, DeletedTailorCategoryId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
