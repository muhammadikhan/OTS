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
    /// OffersController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class OffersController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Offer ObjOffers)
        {
            try
            {
                DBContext.Offers.InsertOnSubmit(ObjOffers);
                DBContext.SubmitChanges();
                return ObjOffers.Offer_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_OfferselectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_Offerselect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, OffersModel ObjOffersModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjOffersModel != null)
                    {
                        Offer ObjOffers = DBContext.Offers.Where(a => a.Offer_ID == id).FirstOrDefault();
                        if (ObjOffers != null)
                        {
                            //OffersModel Edit Properties mapping here. 
                            //ObjOffers.Profile_Name = ObjOffersModel.Profile_Name;
                            //ObjOffers.Password = ObjOffersModel.Password;
                            //ObjOffers.First_Name = ObjOffersModel.First_Name;
                            //ObjOffers.Middle_Name = ObjOffersModel.Middle_Name;
                            //ObjOffers.Last_Name = ObjOffersModel.Last_Name;
                            //ObjOffers.Email_Address = ObjOffersModel.Email_Address;
                            //ObjOffers.Contact_Number = ObjOffersModel.Contact_Number;
                            //ObjOffers.Cell_Number = ObjOffersModel.Cell_Number;
                            //ObjOffers.Location_ID = ObjOffersModel.Location_ID;
                            //ObjOffers.PickUp_Address = ObjOffersModel.PickUp_Address;
                            //ObjOffers.Drop_Address = ObjOffersModel.Drop_Address;
                            //ObjOffers.QR_Code = ObjOffersModel.QR_Code;
                            //ObjOffers.Rating = ObjOffersModel.Rating;
                            //ObjOffers.Created_DateTime = ObjOffersModel.Created_DateTime;
                            //ObjOffers.Created_By = ObjOffersModel.Created_By;
                            //ObjOffers.Modified_DateTime = ObjOffersModel.Modified_DateTime;
                            //ObjOffers.Modified_By = ObjOffersModel.Modified_By;
                            //ObjOffers.Deleted = ObjOffersModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjOffers.Offer_ID;
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
        public int Delete(int id, OffersModel ObjInputOffersModel)
        {
            try
            {
                //Just keep ObjInputOffersModel as parameter for Deleted Log.
                Offer ObjOffers = DBContext.Offers.Where(a => a.Offer_ID == id).FirstOrDefault();
                if (ObjOffers != null)
                {
                    DBContext.Offers.DeleteOnSubmit(ObjOffers);
                    DBContext.SubmitChanges();
                    return ObjOffers.Offer_ID;
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