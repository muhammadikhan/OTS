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
    /// EntityController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class EntityController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(Entity ObjEntity)
        {
            try
            {
                DBContext.Entities.InsertOnSubmit(ObjEntity);
                DBContext.SubmitChanges();
                return ObjEntity.Entity_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_EntitySelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_EntitySelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, EntityModel ObjEntityModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjEntityModel != null)
                    {
                        Entity ObjEntity = DBContext.Entities.Where(a => a.Entity_ID == id).FirstOrDefault();
                        if (ObjEntity != null)
                        {
                            //EntityModel Edit Properties mapping here. 
                            //ObjEntity.Profile_Name = ObjEntityModel.Profile_Name;
                            //ObjEntity.Password = ObjEntityModel.Password;
                            //ObjEntity.First_Name = ObjEntityModel.First_Name;
                            //ObjEntity.Middle_Name = ObjEntityModel.Middle_Name;
                            //ObjEntity.Last_Name = ObjEntityModel.Last_Name;
                            //ObjEntity.Email_Address = ObjEntityModel.Email_Address;
                            //ObjEntity.Contact_Number = ObjEntityModel.Contact_Number;
                            //ObjEntity.Cell_Number = ObjEntityModel.Cell_Number;
                            //ObjEntity.Location_ID = ObjEntityModel.Location_ID;
                            //ObjEntity.PickUp_Address = ObjEntityModel.PickUp_Address;
                            //ObjEntity.Drop_Address = ObjEntityModel.Drop_Address;
                            //ObjEntity.QR_Code = ObjEntityModel.QR_Code;
                            //ObjEntity.Rating = ObjEntityModel.Rating;
                            //ObjEntity.Created_DateTime = ObjEntityModel.Created_DateTime;
                            //ObjEntity.Created_By = ObjEntityModel.Created_By;
                            //ObjEntity.Modified_DateTime = ObjEntityModel.Modified_DateTime;
                            //ObjEntity.Modified_By = ObjEntityModel.Modified_By;
                            //ObjEntity.Deleted = ObjEntityModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjEntity.Entity_ID;
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
        public int Delete(int id, EntityModel ObjInputEntityModel)
        {
            try
            {
                //Just keep ObjInputEntityModel as parameter for Deleted Log.
                Entity ObjEntity = DBContext.Entities.Where(a => a.Entity_ID == id).FirstOrDefault();
                if (ObjEntity != null)
                {
                    DBContext.Entities.DeleteOnSubmit(ObjEntity);
                    DBContext.SubmitChanges();
                    return ObjEntity.Entity_ID;
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