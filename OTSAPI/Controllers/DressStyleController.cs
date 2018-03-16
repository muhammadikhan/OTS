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
    /// DressStyleController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class DressStyleController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(DressStyle ObjDressStyle)
        {
            try
            {
                DBContext.DressStyles.InsertOnSubmit(ObjDressStyle);
                DBContext.SubmitChanges();
                return ObjDressStyle.DressStyle_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_DressStyleSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_DressStyleSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, DressStyleModel ObjDressStyleModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjDressStyleModel != null)
                    {
                        DressStyle ObjDressStyle = DBContext.DressStyles.Where(a => a.DressStyle_ID == id).FirstOrDefault();
                        if (ObjDressStyle != null)
                        {
                            //DressStyleModel Edit Properties mapping here. 
                            //ObjDressStyle.Profile_Name = ObjDressStyleModel.Profile_Name;
                            //ObjDressStyle.Password = ObjDressStyleModel.Password;
                            //ObjDressStyle.First_Name = ObjDressStyleModel.First_Name;
                            //ObjDressStyle.Middle_Name = ObjDressStyleModel.Middle_Name;
                            //ObjDressStyle.Last_Name = ObjDressStyleModel.Last_Name;
                            //ObjDressStyle.Email_Address = ObjDressStyleModel.Email_Address;
                            //ObjDressStyle.Contact_Number = ObjDressStyleModel.Contact_Number;
                            //ObjDressStyle.Cell_Number = ObjDressStyleModel.Cell_Number;
                            //ObjDressStyle.Location_ID = ObjDressStyleModel.Location_ID;
                            //ObjDressStyle.PickUp_Address = ObjDressStyleModel.PickUp_Address;
                            //ObjDressStyle.Drop_Address = ObjDressStyleModel.Drop_Address;
                            //ObjDressStyle.QR_Code = ObjDressStyleModel.QR_Code;
                            //ObjDressStyle.Rating = ObjDressStyleModel.Rating;
                            //ObjDressStyle.Created_DateTime = ObjDressStyleModel.Created_DateTime;
                            //ObjDressStyle.Created_By = ObjDressStyleModel.Created_By;
                            //ObjDressStyle.Modified_DateTime = ObjDressStyleModel.Modified_DateTime;
                            //ObjDressStyle.Modified_By = ObjDressStyleModel.Modified_By;
                            //ObjDressStyle.Deleted = ObjDressStyleModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjDressStyle.DressStyle_ID;
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
        public int Delete(int id, DressStyleModel ObjInputDressStyleModel)
        {
            try
            {
                //Just keep ObjInputDressStyleModel as parameter for Deleted Log.
                DressStyle ObjDressStyle = DBContext.DressStyles.Where(a => a.DressStyle_ID == id).FirstOrDefault();
                if (ObjDressStyle != null)
                {
                    DBContext.DressStyles.DeleteOnSubmit(ObjDressStyle);
                    DBContext.SubmitChanges();
                    return ObjDressStyle.DressStyle_ID;
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