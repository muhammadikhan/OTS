using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;
namespace OTS.Controllers
{
    public class TailorController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(TailorModel ObjTailorModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedTailorId = 0;
                CreatedTailorId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorModel, CreatedTailorId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<TailorModel> ObjTailorModel = new List<TailorModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjTailorModel = (List<TailorModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjTailorModel);
        }
        #endregion
        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<TailorModel> ObjTailorModel = new List<TailorModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjTailorModel = (List<TailorModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjTailorModel.Count > 0)
                    return View(ObjTailorModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, TailorModel ObjInputTailorModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedTailorId = 0;
                UpdatedTailorId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputTailorModel, UpdatedTailorId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<TailorModel> ObjTailorModel = new List<TailorModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjTailorModel = (List<TailorModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjTailorModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjTailorModel.Count > 0)
                    return View(ObjTailorModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, TailorModel ObjInputTailorModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedTailorId = 0;
                DeletedTailorId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputTailorModel, DeletedTailorId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
