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
    /// TailorController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class TailorController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Tailor ObjTailor)
        {
            try
            {
                DBContext.Tailors.InsertOnSubmit(ObjTailor);
                DBContext.SubmitChanges();
                return ObjTailor.Tailor_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_TailorSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_TailorSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, TailorModel ObjTailorModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjTailorModel != null)
                    {
                        Tailor ObjTailor = DBContext.Tailors.Where(a => a.Tailor_ID == id).FirstOrDefault();
                        if (ObjTailor != null)
                        {
                            //TailorModel Edit Properties mapping here. 
                            //ObjTailor.Profile_Name = ObjTailorModel.Profile_Name;
                            //ObjTailor.Password = ObjTailorModel.Password;
                            //ObjTailor.First_Name = ObjTailorModel.First_Name;
                            //ObjTailor.Middle_Name = ObjTailorModel.Middle_Name;
                            //ObjTailor.Last_Name = ObjTailorModel.Last_Name;
                            //ObjTailor.Email_Address = ObjTailorModel.Email_Address;
                            //ObjTailor.Contact_Number = ObjTailorModel.Contact_Number;
                            //ObjTailor.Cell_Number = ObjTailorModel.Cell_Number;
                            //ObjTailor.Location_ID = ObjTailorModel.Location_ID;
                            //ObjTailor.PickUp_Address = ObjTailorModel.PickUp_Address;
                            //ObjTailor.Drop_Address = ObjTailorModel.Drop_Address;
                            //ObjTailor.QR_Code = ObjTailorModel.QR_Code;
                            //ObjTailor.Rating = ObjTailorModel.Rating;
                            //ObjTailor.Created_DateTime = ObjTailorModel.Created_DateTime;
                            //ObjTailor.Created_By = ObjTailorModel.Created_By;
                            //ObjTailor.Modified_DateTime = ObjTailorModel.Modified_DateTime;
                            //ObjTailor.Modified_By = ObjTailorModel.Modified_By;
                            //ObjTailor.Deleted = ObjTailorModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjTailor.Tailor_ID;
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
        public int Delete(int id, TailorModel ObjInputTailorModel)
        {
            try
            {
                //Just keep ObjInputTailorModel as parameter for Deleted Log.
                Tailor ObjTailor = DBContext.Tailors.Where(a => a.Tailor_ID == id).FirstOrDefault();
                if (ObjTailor != null)
                {
                    DBContext.Tailors.DeleteOnSubmit(ObjTailor);
                    DBContext.SubmitChanges();
                    return ObjTailor.Tailor_ID;
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