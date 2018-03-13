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
    /// TailorRiderController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class TailorRiderController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(TailorRider ObjTailorRider)
        {
            try
            {
                DBContext.TailorRiders.InsertOnSubmit(ObjTailorRider);
                DBContext.SubmitChanges();
                return ObjTailorRider.T_RiderID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_TailorRiderSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_TailorRiderSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, TailorRiderModel ObjTailorRiderModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjTailorRiderModel != null)
                    {
                        TailorRider ObjTailorRider = DBContext.TailorRiders.Where(a => a.T_RiderID == id).FirstOrDefault();
                        if (ObjTailorRider != null)
                        {
                            //TailorRiderModel Edit Properties mapping here. 
                            //ObjTailorRider.Profile_Name = ObjTailorRiderModel.Profile_Name;
                            //ObjTailorRider.Password = ObjTailorRiderModel.Password;
                            //ObjTailorRider.First_Name = ObjTailorRiderModel.First_Name;
                            //ObjTailorRider.Middle_Name = ObjTailorRiderModel.Middle_Name;
                            //ObjTailorRider.Last_Name = ObjTailorRiderModel.Last_Name;
                            //ObjTailorRider.Email_Address = ObjTailorRiderModel.Email_Address;
                            //ObjTailorRider.Contact_Number = ObjTailorRiderModel.Contact_Number;
                            //ObjTailorRider.Cell_Number = ObjTailorRiderModel.Cell_Number;
                            //ObjTailorRider.Location_ID = ObjTailorRiderModel.Location_ID;
                            //ObjTailorRider.PickUp_Address = ObjTailorRiderModel.PickUp_Address;
                            //ObjTailorRider.Drop_Address = ObjTailorRiderModel.Drop_Address;
                            //ObjTailorRider.QR_Code = ObjTailorRiderModel.QR_Code;
                            //ObjTailorRider.Rating = ObjTailorRiderModel.Rating;
                            //ObjTailorRider.Created_DateTime = ObjTailorRiderModel.Created_DateTime;
                            //ObjTailorRider.Created_By = ObjTailorRiderModel.Created_By;
                            //ObjTailorRider.Modified_DateTime = ObjTailorRiderModel.Modified_DateTime;
                            //ObjTailorRider.Modified_By = ObjTailorRiderModel.Modified_By;
                            //ObjTailorRider.Deleted = ObjTailorRiderModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjTailorRider.T_RiderID;
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
        public int Delete(int id, TailorRiderModel ObjInputTailorRiderModel)
        {
            try
            {
                //Just keep ObjInputTailorRiderModel as parameter for Deleted Log.
                TailorRider ObjTailorRider = DBContext.TailorRiders.Where(a => a.T_RiderID == id).FirstOrDefault();
                if (ObjTailorRider != null)
                {
                    DBContext.TailorRiders.DeleteOnSubmit(ObjTailorRider);
                    DBContext.SubmitChanges();
                    return ObjTailorRider.T_RiderID;
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