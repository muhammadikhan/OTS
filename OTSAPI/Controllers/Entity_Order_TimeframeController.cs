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
    /// Entity_Order_TimeframeController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class Entity_Order_TimeframeController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Entity_Order_Timeframe ObjEntity_Order_Timeframe)
        {
            try
            {
                DBContext.Entity_Order_Timeframes.InsertOnSubmit(ObjEntity_Order_Timeframe);
                DBContext.SubmitChanges();
                return ObjEntity_Order_Timeframe.Entity_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_Entity_Order_TimeframeSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_Entity_Order_TimeframeSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, Entity_Order_TimeframeModel ObjEntity_Order_TimeframeModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjEntity_Order_TimeframeModel != null)
                    {
                        Entity_Order_Timeframe ObjEntity_Order_Timeframe = DBContext.Entity_Order_Timeframes.Where(a => a.Entity_ID == id).FirstOrDefault();
                        if (ObjEntity_Order_Timeframe != null)
                        {
                            //Entity_Order_TimeframeModel Edit Properties mapping here. 
                            //ObjEntity_Order_Timeframe.Profile_Name = ObjEntity_Order_TimeframeModel.Profile_Name;
                            //ObjEntity_Order_Timeframe.Password = ObjEntity_Order_TimeframeModel.Password;
                            //ObjEntity_Order_Timeframe.First_Name = ObjEntity_Order_TimeframeModel.First_Name;
                            //ObjEntity_Order_Timeframe.Middle_Name = ObjEntity_Order_TimeframeModel.Middle_Name;
                            //ObjEntity_Order_Timeframe.Last_Name = ObjEntity_Order_TimeframeModel.Last_Name;
                            //ObjEntity_Order_Timeframe.Email_Address = ObjEntity_Order_TimeframeModel.Email_Address;
                            //ObjEntity_Order_Timeframe.Contact_Number = ObjEntity_Order_TimeframeModel.Contact_Number;
                            //ObjEntity_Order_Timeframe.Cell_Number = ObjEntity_Order_TimeframeModel.Cell_Number;
                            //ObjEntity_Order_Timeframe.Location_ID = ObjEntity_Order_TimeframeModel.Location_ID;
                            //ObjEntity_Order_Timeframe.PickUp_Address = ObjEntity_Order_TimeframeModel.PickUp_Address;
                            //ObjEntity_Order_Timeframe.Drop_Address = ObjEntity_Order_TimeframeModel.Drop_Address;
                            //ObjEntity_Order_Timeframe.QR_Code = ObjEntity_Order_TimeframeModel.QR_Code;
                            //ObjEntity_Order_Timeframe.Rating = ObjEntity_Order_TimeframeModel.Rating;
                            //ObjEntity_Order_Timeframe.Created_DateTime = ObjEntity_Order_TimeframeModel.Created_DateTime;
                            //ObjEntity_Order_Timeframe.Created_By = ObjEntity_Order_TimeframeModel.Created_By;
                            //ObjEntity_Order_Timeframe.Modified_DateTime = ObjEntity_Order_TimeframeModel.Modified_DateTime;
                            //ObjEntity_Order_Timeframe.Modified_By = ObjEntity_Order_TimeframeModel.Modified_By;
                            //ObjEntity_Order_Timeframe.Deleted = ObjEntity_Order_TimeframeModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjEntity_Order_Timeframe.Entity_ID;
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
        public int Delete(int id, Entity_Order_TimeframeModel ObjInputEntity_Order_TimeframeModel)
        {
            try
            {
                //Just keep ObjInputEntity_Order_TimeframeModel as parameter for Deleted Log.
                Entity_Order_Timeframe ObjEntity_Order_Timeframe = DBContext.Entity_Order_Timeframes.Where(a => a.Entity_ID == id).FirstOrDefault();
                if (ObjEntity_Order_Timeframe != null)
                {
                    DBContext.Entity_Order_Timeframes.DeleteOnSubmit(ObjEntity_Order_Timeframe);
                    DBContext.SubmitChanges();
                    return ObjEntity_Order_Timeframe.Entity_ID;
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