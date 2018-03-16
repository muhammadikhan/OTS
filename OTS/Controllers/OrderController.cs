using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTS.Model;
namespace OTS.Controllers
{
    public class OrderController : Controller
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        #region Create / Insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(OrderModel ObjOrderModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name;
                int CreatedOrderId = 0;
                CreatedOrderId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjOrderModel, CreatedOrderId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
            List<OrderModel> ObjOrderModel = new List<OrderModel>();
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                ObjOrderModel = (List<OrderModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjOrderModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View(ObjOrderModel);
        }
        #endregion
        #region Update / Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                List<OrderModel> ObjOrderModel = new List<OrderModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjOrderModel = (List<OrderModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjOrderModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjOrderModel.Count > 0)
                    return View(ObjOrderModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, OrderModel ObjInputOrderModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int UpdatedOrderId = 0;
                UpdatedOrderId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputOrderModel, UpdatedOrderId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
                List<OrderModel> ObjOrderModel = new List<OrderModel>();
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/Index/" + id;
                ObjOrderModel = (List<OrderModel>)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjOrderModel, OTS.GlobalSettings.WebAPITimeout, out JsonString);
                if (ObjOrderModel.Count > 0)
                    return View(ObjOrderModel.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View("Error");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id, OrderModel ObjInputOrderModel)
        {
            //Customized try catch block by Imran Khan. CodeSnippet 
            try
            {
                string JsonString = string.Empty;
                string ApiURL = OTS.GlobalSettings.WebAPIURL + this.GetType().Name.Replace("Controller", string.Empty) + "/" + System.Reflection.MethodBase.GetCurrentMethod().Name + "/" + id;
                int DeletedOrderId = 0;
                DeletedOrderId = (int)iWebServiceConsumer.ConsumeJsonWebService(ApiURL, ObjInputOrderModel, DeletedOrderId, OTS.GlobalSettings.WebAPITimeout, out JsonString);
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
