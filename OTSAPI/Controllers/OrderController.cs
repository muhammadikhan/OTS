using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web.Http;
// Handle Database Calls.
using DatabaseContext;
using DatabaseEntity;
// User Defined Model to Handle Api Call Models. 
using OTS.Model;
namespace OTSAPI.Controllers
{
    /// <summary>
    /// OrderController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class OrderController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Order ObjOrder)
        {
            try
            {
                DBContext.Orders.InsertOnSubmit(ObjOrder);
                DBContext.SubmitChanges();
                return ObjOrder.Order_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_OrderSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_OrderSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, OrderModel ObjOrderModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjOrderModel != null)
                    {
                        Order ObjOrder = DBContext.Orders.Where(a => a.Order_ID == id).FirstOrDefault();
                        if (ObjOrder != null)
                        {
                            //OrderModel Edit Properties mapping here. 
                            //ObjOrder.Profile_Name = ObjOrderModel.Profile_Name;
                            //ObjOrder.Password = ObjOrderModel.Password;
                            //ObjOrder.First_Name = ObjOrderModel.First_Name;
                            //ObjOrder.Middle_Name = ObjOrderModel.Middle_Name;
                            //ObjOrder.Last_Name = ObjOrderModel.Last_Name;
                            //ObjOrder.Email_Address = ObjOrderModel.Email_Address;
                            //ObjOrder.Contact_Number = ObjOrderModel.Contact_Number;
                            //ObjOrder.Cell_Number = ObjOrderModel.Cell_Number;
                            //ObjOrder.Location_ID = ObjOrderModel.Location_ID;
                            //ObjOrder.PickUp_Address = ObjOrderModel.PickUp_Address;
                            //ObjOrder.Drop_Address = ObjOrderModel.Drop_Address;
                            //ObjOrder.QR_Code = ObjOrderModel.QR_Code;
                            //ObjOrder.Rating = ObjOrderModel.Rating;
                            //ObjOrder.Created_DateTime = ObjOrderModel.Created_DateTime;
                            //ObjOrder.Created_By = ObjOrderModel.Created_By;
                            //ObjOrder.Modified_DateTime = ObjOrderModel.Modified_DateTime;
                            //ObjOrder.Modified_By = ObjOrderModel.Modified_By;
                            //ObjOrder.Deleted = ObjOrderModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjOrder.Order_ID;
                        }
                        else return WebApiResponse.NoRecordFound;
                    }
                    else return WebApiResponse.InputObjectIsNull;
                }
                else return WebApiResponse.InputIdInvalid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Delete
        [HttpPost]
        public int Delete(int id, OrderModel ObjInputOrderModel)
        {
            try
            {
                //Just keep ObjInputOrderModel as parameter for Deleted Log.
                Order ObjOrder = DBContext.Orders.Where(a => a.Order_ID == id).FirstOrDefault();
                if (ObjOrder != null)
                {
                    DBContext.Orders.DeleteOnSubmit(ObjOrder);
                    DBContext.SubmitChanges();
                    return ObjOrder.Order_ID;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #endregion
    }
}