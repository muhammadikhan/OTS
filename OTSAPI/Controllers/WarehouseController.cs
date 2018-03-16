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
    /// WarehouseController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class WarehouseController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Warehouse ObjWarehouse)
        {
            try
            {
                DBContext.Warehouses.InsertOnSubmit(ObjWarehouse);
                DBContext.SubmitChanges();
                return ObjWarehouse.Warehouse_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_WarehouseSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_WarehouseSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, WarehouseModel ObjWarehouseModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjWarehouseModel != null)
                    {
                        Warehouse ObjWarehouse = DBContext.Warehouses.Where(a => a.Warehouse_ID == id).FirstOrDefault();
                        if (ObjWarehouse != null)
                        {
                            //WarehouseModel Edit Properties mapping here. 
                            //ObjWarehouse.Profile_Name = ObjWarehouseModel.Profile_Name;
                            //ObjWarehouse.Password = ObjWarehouseModel.Password;
                            //ObjWarehouse.First_Name = ObjWarehouseModel.First_Name;
                            //ObjWarehouse.Middle_Name = ObjWarehouseModel.Middle_Name;
                            //ObjWarehouse.Last_Name = ObjWarehouseModel.Last_Name;
                            //ObjWarehouse.Email_Address = ObjWarehouseModel.Email_Address;
                            //ObjWarehouse.Contact_Number = ObjWarehouseModel.Contact_Number;
                            //ObjWarehouse.Cell_Number = ObjWarehouseModel.Cell_Number;
                            //ObjWarehouse.Location_ID = ObjWarehouseModel.Location_ID;
                            //ObjWarehouse.PickUp_Address = ObjWarehouseModel.PickUp_Address;
                            //ObjWarehouse.Drop_Address = ObjWarehouseModel.Drop_Address;
                            //ObjWarehouse.QR_Code = ObjWarehouseModel.QR_Code;
                            //ObjWarehouse.Rating = ObjWarehouseModel.Rating;
                            //ObjWarehouse.Created_DateTime = ObjWarehouseModel.Created_DateTime;
                            //ObjWarehouse.Created_By = ObjWarehouseModel.Created_By;
                            //ObjWarehouse.Modified_DateTime = ObjWarehouseModel.Modified_DateTime;
                            //ObjWarehouse.Modified_By = ObjWarehouseModel.Modified_By;
                            //ObjWarehouse.Deleted = ObjWarehouseModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjWarehouse.Warehouse_ID;
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
        public int Delete(int id, WarehouseModel ObjInputWarehouseModel)
        {
            try
            {
                //Just keep ObjInputWarehouseModel as parameter for Deleted Log.
                Warehouse ObjWarehouse = DBContext.Warehouses.Where(a => a.Warehouse_ID == id).FirstOrDefault();
                if (ObjWarehouse != null)
                {
                    DBContext.Warehouses.DeleteOnSubmit(ObjWarehouse);
                    DBContext.SubmitChanges();
                    return ObjWarehouse.Warehouse_ID;
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