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
    /// DressDetailsController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class DressDetailsController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(DressDetail ObjDressDetails)
        {
            try
            {
                DBContext.DressDetails.InsertOnSubmit(ObjDressDetails);
                DBContext.SubmitChanges();
                return ObjDressDetails.DressDetails_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_DressDetailsSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_DressDetailsSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, DressDetailsModel ObjDressDetailsModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjDressDetailsModel != null)
                    {
                        DressDetail ObjDressDetails = DBContext.DressDetails.Where(a => a.DressDetails_ID == id).FirstOrDefault();
                        if (ObjDressDetails != null)
                        {
                            //DressDetailsModel Edit Properties mapping here. 
                            //ObjDressDetails.Profile_Name = ObjDressDetailsModel.Profile_Name;
                            //ObjDressDetails.Password = ObjDressDetailsModel.Password;
                            //ObjDressDetails.First_Name = ObjDressDetailsModel.First_Name;
                            //ObjDressDetails.Middle_Name = ObjDressDetailsModel.Middle_Name;
                            //ObjDressDetails.Last_Name = ObjDressDetailsModel.Last_Name;
                            //ObjDressDetails.Email_Address = ObjDressDetailsModel.Email_Address;
                            //ObjDressDetails.Contact_Number = ObjDressDetailsModel.Contact_Number;
                            //ObjDressDetails.Cell_Number = ObjDressDetailsModel.Cell_Number;
                            //ObjDressDetails.Location_ID = ObjDressDetailsModel.Location_ID;
                            //ObjDressDetails.PickUp_Address = ObjDressDetailsModel.PickUp_Address;
                            //ObjDressDetails.Drop_Address = ObjDressDetailsModel.Drop_Address;
                            //ObjDressDetails.QR_Code = ObjDressDetailsModel.QR_Code;
                            //ObjDressDetails.Rating = ObjDressDetailsModel.Rating;
                            //ObjDressDetails.Created_DateTime = ObjDressDetailsModel.Created_DateTime;
                            //ObjDressDetails.Created_By = ObjDressDetailsModel.Created_By;
                            //ObjDressDetails.Modified_DateTime = ObjDressDetailsModel.Modified_DateTime;
                            //ObjDressDetails.Modified_By = ObjDressDetailsModel.Modified_By;
                            //ObjDressDetails.Deleted = ObjDressDetailsModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjDressDetails.DressDetails_ID;
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
        public int Delete(int id, DressDetailsModel ObjInputDressDetailsModel)
        {
            try
            {
                //Just keep ObjInputDressDetailsModel as parameter for Deleted Log.
                DressDetail ObjDressDetails = DBContext.DressDetails.Where(a => a.DressDetails_ID == id).FirstOrDefault();
                if (ObjDressDetails != null)
                {
                    DBContext.DressDetails.DeleteOnSubmit(ObjDressDetails);
                    DBContext.SubmitChanges();
                    return ObjDressDetails.DressDetails_ID;
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