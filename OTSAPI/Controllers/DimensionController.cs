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
    /// DimensionController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class DimensionController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(Dimension ObjDimension)
        {
            try
            {
                DBContext.Dimensions.InsertOnSubmit(ObjDimension);
                DBContext.SubmitChanges();
                return ObjDimension.Dimension_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_DimensionSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_DimensionSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, DimensionModel ObjDimensionModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjDimensionModel != null)
                    {
                        Dimension ObjDimension = DBContext.Dimensions.Where(a => a.Dimension_ID == id).FirstOrDefault();
                        if (ObjDimension != null)
                        {
                            //DimensionModel Edit Properties mapping here. 
                            //ObjDimension.Profile_Name = ObjDimensionModel.Profile_Name;
                            //ObjDimension.Password = ObjDimensionModel.Password;
                            //ObjDimension.First_Name = ObjDimensionModel.First_Name;
                            //ObjDimension.Middle_Name = ObjDimensionModel.Middle_Name;
                            //ObjDimension.Last_Name = ObjDimensionModel.Last_Name;
                            //ObjDimension.Email_Address = ObjDimensionModel.Email_Address;
                            //ObjDimension.Contact_Number = ObjDimensionModel.Contact_Number;
                            //ObjDimension.Cell_Number = ObjDimensionModel.Cell_Number;
                            //ObjDimension.Location_ID = ObjDimensionModel.Location_ID;
                            //ObjDimension.PickUp_Address = ObjDimensionModel.PickUp_Address;
                            //ObjDimension.Drop_Address = ObjDimensionModel.Drop_Address;
                            //ObjDimension.QR_Code = ObjDimensionModel.QR_Code;
                            //ObjDimension.Rating = ObjDimensionModel.Rating;
                            //ObjDimension.Created_DateTime = ObjDimensionModel.Created_DateTime;
                            //ObjDimension.Created_By = ObjDimensionModel.Created_By;
                            //ObjDimension.Modified_DateTime = ObjDimensionModel.Modified_DateTime;
                            //ObjDimension.Modified_By = ObjDimensionModel.Modified_By;
                            //ObjDimension.Deleted = ObjDimensionModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjDimension.Dimension_ID;
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
        public int Delete(int id, DimensionModel ObjInputDimensionModel)
        {
            try
            {
                //Just keep ObjInputDimensionModel as parameter for Deleted Log.
                Dimension ObjDimension = DBContext.Dimensions.Where(a => a.Dimension_ID == id).FirstOrDefault();
                if (ObjDimension != null)
                {
                    DBContext.Dimensions.DeleteOnSubmit(ObjDimension);
                    DBContext.SubmitChanges();
                    return ObjDimension.Dimension_ID;
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