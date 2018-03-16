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
    /// DressCategoryController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class DressCategoryController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(DressCategory ObjDressCategory)
        {
            try
            {
                DBContext.DressCategories.InsertOnSubmit(ObjDressCategory);
                DBContext.SubmitChanges();
                return ObjDressCategory.DressCategory_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_DressCategorySelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_DressCategorySelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, DressCategoryModel ObjDressCategoryModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjDressCategoryModel != null)
                    {
                        DressCategory ObjDressCategory = DBContext.DressCategories.Where(a => a.DressCategory_ID == id).FirstOrDefault();
                        if (ObjDressCategory != null)
                        {
                            //DressCategoryModel Edit Properties mapping here. 
                            //ObjDressCategory.Profile_Name = ObjDressCategoryModel.Profile_Name;
                            //ObjDressCategory.Password = ObjDressCategoryModel.Password;
                            //ObjDressCategory.First_Name = ObjDressCategoryModel.First_Name;
                            //ObjDressCategory.Middle_Name = ObjDressCategoryModel.Middle_Name;
                            //ObjDressCategory.Last_Name = ObjDressCategoryModel.Last_Name;
                            //ObjDressCategory.Email_Address = ObjDressCategoryModel.Email_Address;
                            //ObjDressCategory.Contact_Number = ObjDressCategoryModel.Contact_Number;
                            //ObjDressCategory.Cell_Number = ObjDressCategoryModel.Cell_Number;
                            //ObjDressCategory.Location_ID = ObjDressCategoryModel.Location_ID;
                            //ObjDressCategory.PickUp_Address = ObjDressCategoryModel.PickUp_Address;
                            //ObjDressCategory.Drop_Address = ObjDressCategoryModel.Drop_Address;
                            //ObjDressCategory.QR_Code = ObjDressCategoryModel.QR_Code;
                            //ObjDressCategory.Rating = ObjDressCategoryModel.Rating;
                            //ObjDressCategory.Created_DateTime = ObjDressCategoryModel.Created_DateTime;
                            //ObjDressCategory.Created_By = ObjDressCategoryModel.Created_By;
                            //ObjDressCategory.Modified_DateTime = ObjDressCategoryModel.Modified_DateTime;
                            //ObjDressCategory.Modified_By = ObjDressCategoryModel.Modified_By;
                            //ObjDressCategory.Deleted = ObjDressCategoryModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjDressCategory.DressCategory_ID;
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
        public int Delete(int id, DressCategoryModel ObjInputDressCategoryModel)
        {
            try
            {
                //Just keep ObjInputDressCategoryModel as parameter for Deleted Log.
                DressCategory ObjDressCategory = DBContext.DressCategories.Where(a => a.DressCategory_ID == id).FirstOrDefault();
                if (ObjDressCategory != null)
                {
                    DBContext.DressCategories.DeleteOnSubmit(ObjDressCategory);
                    DBContext.SubmitChanges();
                    return ObjDressCategory.DressCategory_ID;
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