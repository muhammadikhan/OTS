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
    /// ClientSampleController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class ClientSampleController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(ClientSample ObjClientSample)
        {
            try
            {
                DBContext.ClientSamples.InsertOnSubmit(ObjClientSample);
                DBContext.SubmitChanges();
                return ObjClientSample.ClientSample_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_ClientSampleSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_ClientSampleSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, ClientSampleModel ObjClientSampleModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjClientSampleModel != null)
                    {
                        ClientSample ObjClientSample = DBContext.ClientSamples.Where(a => a.ClientSample_ID == id).FirstOrDefault();
                        if (ObjClientSample != null)
                        {
                            //ClientSampleModel Edit Properties mapping here. 
                            //ObjClientSample.Profile_Name = ObjClientSampleModel.Profile_Name;
                            //ObjClientSample.Password = ObjClientSampleModel.Password;
                            //ObjClientSample.First_Name = ObjClientSampleModel.First_Name;
                            //ObjClientSample.Middle_Name = ObjClientSampleModel.Middle_Name;
                            //ObjClientSample.Last_Name = ObjClientSampleModel.Last_Name;
                            //ObjClientSample.Email_Address = ObjClientSampleModel.Email_Address;
                            //ObjClientSample.Contact_Number = ObjClientSampleModel.Contact_Number;
                            //ObjClientSample.Cell_Number = ObjClientSampleModel.Cell_Number;
                            //ObjClientSample.Location_ID = ObjClientSampleModel.Location_ID;
                            //ObjClientSample.PickUp_Address = ObjClientSampleModel.PickUp_Address;
                            //ObjClientSample.Drop_Address = ObjClientSampleModel.Drop_Address;
                            //ObjClientSample.QR_Code = ObjClientSampleModel.QR_Code;
                            //ObjClientSample.Rating = ObjClientSampleModel.Rating;
                            //ObjClientSample.Created_DateTime = ObjClientSampleModel.Created_DateTime;
                            //ObjClientSample.Created_By = ObjClientSampleModel.Created_By;
                            //ObjClientSample.Modified_DateTime = ObjClientSampleModel.Modified_DateTime;
                            //ObjClientSample.Modified_By = ObjClientSampleModel.Modified_By;
                            //ObjClientSample.Deleted = ObjClientSampleModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjClientSample.ClientSample_ID;
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
        public int Delete(int id, ClientSampleModel ObjInputClientSampleModel)
        {
            try
            {
                //Just keep ObjInputClientSampleModel as parameter for Deleted Log.
                ClientSample ObjClientSample = DBContext.ClientSamples.Where(a => a.ClientSample_ID == id).FirstOrDefault();
                if (ObjClientSample != null)
                {
                    DBContext.ClientSamples.DeleteOnSubmit(ObjClientSample);
                    DBContext.SubmitChanges();
                    return ObjClientSample.ClientSample_ID;
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