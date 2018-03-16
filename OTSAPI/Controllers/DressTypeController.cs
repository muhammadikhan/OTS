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
    /// DressTypeController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class DressTypeController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(DressType ObjDressType)
        {
            try
            {
                DBContext.DressTypes.InsertOnSubmit(ObjDressType);
                DBContext.SubmitChanges();
                return ObjDressType.DressType_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_DressTypeSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_DressTypeSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, DressTypeModel ObjDressTypeModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjDressTypeModel != null)
                    {
                        DressType ObjDressType = DBContext.DressTypes.Where(a => a.DressType_ID == id).FirstOrDefault();
                        if (ObjDressType != null)
                        {
                            //DressTypeModel Edit Properties mapping here. 
                            //ObjDressType.Profile_Name = ObjDressTypeModel.Profile_Name;
                            //ObjDressType.Password = ObjDressTypeModel.Password;
                            //ObjDressType.First_Name = ObjDressTypeModel.First_Name;
                            //ObjDressType.Middle_Name = ObjDressTypeModel.Middle_Name;
                            //ObjDressType.Last_Name = ObjDressTypeModel.Last_Name;
                            //ObjDressType.Email_Address = ObjDressTypeModel.Email_Address;
                            //ObjDressType.Contact_Number = ObjDressTypeModel.Contact_Number;
                            //ObjDressType.Cell_Number = ObjDressTypeModel.Cell_Number;
                            //ObjDressType.Location_ID = ObjDressTypeModel.Location_ID;
                            //ObjDressType.PickUp_Address = ObjDressTypeModel.PickUp_Address;
                            //ObjDressType.Drop_Address = ObjDressTypeModel.Drop_Address;
                            //ObjDressType.QR_Code = ObjDressTypeModel.QR_Code;
                            //ObjDressType.Rating = ObjDressTypeModel.Rating;
                            //ObjDressType.Created_DateTime = ObjDressTypeModel.Created_DateTime;
                            //ObjDressType.Created_By = ObjDressTypeModel.Created_By;
                            //ObjDressType.Modified_DateTime = ObjDressTypeModel.Modified_DateTime;
                            //ObjDressType.Modified_By = ObjDressTypeModel.Modified_By;
                            //ObjDressType.Deleted = ObjDressTypeModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjDressType.DressType_ID;
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
        public int Delete(int id, DressTypeModel ObjInputDressTypeModel)
        {
            try
            {
                //Just keep ObjInputDressTypeModel as parameter for Deleted Log.
                DressType ObjDressType = DBContext.DressTypes.Where(a => a.DressType_ID == id).FirstOrDefault();
                if (ObjDressType != null)
                {
                    DBContext.DressTypes.DeleteOnSubmit(ObjDressType);
                    DBContext.SubmitChanges();
                    return ObjDressType.DressType_ID;
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