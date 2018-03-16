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
    /// TailorCategoryController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class TailorCategoryController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(TailorCategory ObjTailorCategory)
        {
            try
            {
                DBContext.TailorCategories.InsertOnSubmit(ObjTailorCategory);
                DBContext.SubmitChanges();
                return ObjTailorCategory.TailorCategory_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_TailorCategorySelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_TailorCategorySelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, TailorCategoryModel ObjTailorCategoryModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjTailorCategoryModel != null)
                    {
                        TailorCategory ObjTailorCategory = DBContext.TailorCategories.Where(a => a.TailorCategory_ID == id).FirstOrDefault();
                        if (ObjTailorCategory != null)
                        {
                            //TailorCategoryModel Edit Properties mapping here. 
                            //ObjTailorCategory.Profile_Name = ObjTailorCategoryModel.Profile_Name;
                            //ObjTailorCategory.Password = ObjTailorCategoryModel.Password;
                            //ObjTailorCategory.First_Name = ObjTailorCategoryModel.First_Name;
                            //ObjTailorCategory.Middle_Name = ObjTailorCategoryModel.Middle_Name;
                            //ObjTailorCategory.Last_Name = ObjTailorCategoryModel.Last_Name;
                            //ObjTailorCategory.Email_Address = ObjTailorCategoryModel.Email_Address;
                            //ObjTailorCategory.Contact_Number = ObjTailorCategoryModel.Contact_Number;
                            //ObjTailorCategory.Cell_Number = ObjTailorCategoryModel.Cell_Number;
                            //ObjTailorCategory.Location_ID = ObjTailorCategoryModel.Location_ID;
                            //ObjTailorCategory.PickUp_Address = ObjTailorCategoryModel.PickUp_Address;
                            //ObjTailorCategory.Drop_Address = ObjTailorCategoryModel.Drop_Address;
                            //ObjTailorCategory.QR_Code = ObjTailorCategoryModel.QR_Code;
                            //ObjTailorCategory.Rating = ObjTailorCategoryModel.Rating;
                            //ObjTailorCategory.Created_DateTime = ObjTailorCategoryModel.Created_DateTime;
                            //ObjTailorCategory.Created_By = ObjTailorCategoryModel.Created_By;
                            //ObjTailorCategory.Modified_DateTime = ObjTailorCategoryModel.Modified_DateTime;
                            //ObjTailorCategory.Modified_By = ObjTailorCategoryModel.Modified_By;
                            //ObjTailorCategory.Deleted = ObjTailorCategoryModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjTailorCategory.TailorCategory_ID;
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
        public int Delete(int id, TailorCategoryModel ObjInputTailorCategoryModel)
        {
            try
            {
                //Just keep ObjInputTailorCategoryModel as parameter for Deleted Log.
                TailorCategory ObjTailorCategory = DBContext.TailorCategories.Where(a => a.TailorCategory_ID == id).FirstOrDefault();
                if (ObjTailorCategory != null)
                {
                    DBContext.TailorCategories.DeleteOnSubmit(ObjTailorCategory);
                    DBContext.SubmitChanges();
                    return ObjTailorCategory.TailorCategory_ID;
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