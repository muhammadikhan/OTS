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
    /// ClientRiderController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class ClientRiderController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();

        #region Create / Insert
        [HttpPost]
        public int Create(ClientRider ObjClientRider)
        {
            try
            {
                DBContext.ClientRiders.InsertOnSubmit(ObjClientRider);
                DBContext.SubmitChanges();
                return ObjClientRider.C_RiderID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Read / Select
        [HttpGet]
        public List<usp_ClientRiderSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_ClientRiderSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update / Edit
        [HttpPost]
        public int Edit(int id, ClientRiderModel ObjClientRiderModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjClientRiderModel != null)
                    {
                        ClientRider ObjClientRider = DBContext.ClientRiders.Where(a => a.C_RiderID == id).FirstOrDefault();
                        if (ObjClientRider != null)
                        {
                            //ClientRiderModel Edit Properties mapping here. 
                            //ObjClientRider.Profile_Name = ObjClientRiderModel.Profile_Name;
                            //ObjClientRider.Password = ObjClientRiderModel.Password;
                            //ObjClientRider.First_Name = ObjClientRiderModel.First_Name;
                            //ObjClientRider.Middle_Name = ObjClientRiderModel.Middle_Name;
                            //ObjClientRider.Last_Name = ObjClientRiderModel.Last_Name;
                            //ObjClientRider.Email_Address = ObjClientRiderModel.Email_Address;
                            //ObjClientRider.Contact_Number = ObjClientRiderModel.Contact_Number;
                            //ObjClientRider.Cell_Number = ObjClientRiderModel.Cell_Number;
                            //ObjClientRider.Location_ID = ObjClientRiderModel.Location_ID;
                            //ObjClientRider.PickUp_Address = ObjClientRiderModel.PickUp_Address;
                            //ObjClientRider.Drop_Address = ObjClientRiderModel.Drop_Address;
                            //ObjClientRider.QR_Code = ObjClientRiderModel.QR_Code;
                            //ObjClientRider.Rating = ObjClientRiderModel.Rating;
                            //ObjClientRider.Created_DateTime = ObjClientRiderModel.Created_DateTime;
                            //ObjClientRider.Created_By = ObjClientRiderModel.Created_By;
                            //ObjClientRider.Modified_DateTime = ObjClientRiderModel.Modified_DateTime;
                            //ObjClientRider.Modified_By = ObjClientRiderModel.Modified_By;
                            //ObjClientRider.Deleted = ObjClientRiderModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjClientRider.C_RiderID;
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
        public int Delete(int id, ClientRiderModel ObjInputClientRiderModel)
        {
            try
            {
                //Just keep ObjInputClientRiderModel as parameter for Deleted Log.
                ClientRider ObjClientRider = DBContext.ClientRiders.Where(a => a.C_RiderID == id).FirstOrDefault();
                if (ObjClientRider != null)
                {
                    DBContext.ClientRiders.DeleteOnSubmit(ObjClientRider);
                    DBContext.SubmitChanges();
                    return ObjClientRider.C_RiderID;
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