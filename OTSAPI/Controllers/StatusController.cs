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
    /// StatusController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class StatusController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(Status ObjStatus)
        {
            try
            {
                DBContext.Status.InsertOnSubmit(ObjStatus);
                DBContext.SubmitChanges();
                return ObjStatus.Status_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_StatusSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_StatusSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, StatusModel ObjStatusModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjStatusModel != null)
                    {
                        Status ObjStatus = DBContext.Status.Where(a => a.Status_ID == id).FirstOrDefault();
                        if (ObjStatus != null)
                        {
                            //StatusModel Edit Properties mapping here. 
                            //ObjStatus.Profile_Name = ObjStatusModel.Profile_Name;
                            //ObjStatus.Password = ObjStatusModel.Password;
                            //ObjStatus.First_Name = ObjStatusModel.First_Name;
                            //ObjStatus.Middle_Name = ObjStatusModel.Middle_Name;
                            //ObjStatus.Last_Name = ObjStatusModel.Last_Name;
                            //ObjStatus.Email_Address = ObjStatusModel.Email_Address;
                            //ObjStatus.Contact_Number = ObjStatusModel.Contact_Number;
                            //ObjStatus.Cell_Number = ObjStatusModel.Cell_Number;
                            //ObjStatus.Location_ID = ObjStatusModel.Location_ID;
                            //ObjStatus.PickUp_Address = ObjStatusModel.PickUp_Address;
                            //ObjStatus.Drop_Address = ObjStatusModel.Drop_Address;
                            //ObjStatus.QR_Code = ObjStatusModel.QR_Code;
                            //ObjStatus.Rating = ObjStatusModel.Rating;
                            //ObjStatus.Created_DateTime = ObjStatusModel.Created_DateTime;
                            //ObjStatus.Created_By = ObjStatusModel.Created_By;
                            //ObjStatus.Modified_DateTime = ObjStatusModel.Modified_DateTime;
                            //ObjStatus.Modified_By = ObjStatusModel.Modified_By;
                            //ObjStatus.Deleted = ObjStatusModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjStatus.Status_ID;
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
        public int Delete(int id, StatusModel ObjInputStatusModel)
        {
            try
            {
                //Just keep ObjInputStatusModel as parameter for Deleted Log.
                Status ObjStatus = DBContext.Status.Where(a => a.Status_ID == id).FirstOrDefault();
                if (ObjStatus != null)
                {
                    DBContext.Status.DeleteOnSubmit(ObjStatus);
                    DBContext.SubmitChanges();
                    return ObjStatus.Status_ID;
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