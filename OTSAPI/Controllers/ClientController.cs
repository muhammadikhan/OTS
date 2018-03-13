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
    /// ClientController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class ClientController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(Client ObjClient)
        {
            try
            {
                DBContext.Clients.InsertOnSubmit(ObjClient);
                DBContext.SubmitChanges();
                return ObjClient.Client_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_ClientSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_ClientSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, ClientModel ObjClientModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjClientModel != null)
                    {
                        Client ObjClient = DBContext.Clients.Where(a => a.Client_ID == id).FirstOrDefault();
                        if (ObjClient != null)
                        {
                            //ClientModel Edit Properties mapping here. 
                            ObjClient.Profile_Name = ObjClientModel.Profile_Name;
                            ObjClient.Password = ObjClientModel.Password;
                            ObjClient.First_Name = ObjClientModel.First_Name;
                            ObjClient.Middle_Name = ObjClientModel.Middle_Name;
                            ObjClient.Last_Name = ObjClientModel.Last_Name;
                            ObjClient.Email_Address = ObjClientModel.Email_Address;
                            ObjClient.Contact_Number = ObjClientModel.Contact_Number;
                            ObjClient.Cell_Number = ObjClientModel.Cell_Number;
                            ObjClient.Location_ID = ObjClientModel.Location_ID;
                            ObjClient.PickUp_Address = ObjClientModel.PickUp_Address;
                            ObjClient.Drop_Address = ObjClientModel.Drop_Address;
                            ObjClient.QR_Code = ObjClientModel.QR_Code;
                            ObjClient.Rating = ObjClientModel.Rating;
                            ObjClient.Created_DateTime = ObjClientModel.Created_DateTime;
                            ObjClient.Created_By = ObjClientModel.Created_By;
                            ObjClient.Modified_DateTime = ObjClientModel.Modified_DateTime;
                            ObjClient.Modified_By = ObjClientModel.Modified_By;
                            ObjClient.Deleted = ObjClientModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjClient.Client_ID;
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
        public int Delete(int id, ClientModel ObjInputClientModel)
        {
            try
            {
                //Just keep ObjInputClientModel as parameter for Deleted Log.
                Client ObjClient = DBContext.Clients.Where(a => a.Client_ID == id).FirstOrDefault();
                if (ObjClient != null)
                {
                    DBContext.Clients.DeleteOnSubmit(ObjClient);
                    DBContext.SubmitChanges();
                    return ObjClient.Client_ID;
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