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
    /// Entity_OfferController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class Entity_OfferController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Entity_Offer ObjEntity_Offer)
        {
            try
            {
                DBContext.Entity_Offers.InsertOnSubmit(ObjEntity_Offer);
                DBContext.SubmitChanges();
                return ObjEntity_Offer.Entity_Offer_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_Entity_OfferSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_Entity_OfferSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, Entity_OfferModel ObjEntity_OfferModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjEntity_OfferModel != null)
                    {
                        Entity_Offer ObjEntity_Offer = DBContext.Entity_Offers.Where(a => a.Entity_Offer_ID == id).FirstOrDefault();
                        if (ObjEntity_Offer != null)
                        {
                            //Entity_OfferModel Edit Properties mapping here. 
                            //ObjEntity_Offer.Profile_Name = ObjEntity_OfferModel.Profile_Name;
                            //ObjEntity_Offer.Password = ObjEntity_OfferModel.Password;
                            //ObjEntity_Offer.First_Name = ObjEntity_OfferModel.First_Name;
                            //ObjEntity_Offer.Middle_Name = ObjEntity_OfferModel.Middle_Name;
                            //ObjEntity_Offer.Last_Name = ObjEntity_OfferModel.Last_Name;
                            //ObjEntity_Offer.Email_Address = ObjEntity_OfferModel.Email_Address;
                            //ObjEntity_Offer.Contact_Number = ObjEntity_OfferModel.Contact_Number;
                            //ObjEntity_Offer.Cell_Number = ObjEntity_OfferModel.Cell_Number;
                            //ObjEntity_Offer.Location_ID = ObjEntity_OfferModel.Location_ID;
                            //ObjEntity_Offer.PickUp_Address = ObjEntity_OfferModel.PickUp_Address;
                            //ObjEntity_Offer.Drop_Address = ObjEntity_OfferModel.Drop_Address;
                            //ObjEntity_Offer.QR_Code = ObjEntity_OfferModel.QR_Code;
                            //ObjEntity_Offer.Rating = ObjEntity_OfferModel.Rating;
                            //ObjEntity_Offer.Created_DateTime = ObjEntity_OfferModel.Created_DateTime;
                            //ObjEntity_Offer.Created_By = ObjEntity_OfferModel.Created_By;
                            //ObjEntity_Offer.Modified_DateTime = ObjEntity_OfferModel.Modified_DateTime;
                            //ObjEntity_Offer.Modified_By = ObjEntity_OfferModel.Modified_By;
                            //ObjEntity_Offer.Deleted = ObjEntity_OfferModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjEntity_Offer.Entity_Offer_ID;
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
        public int Delete(int id, Entity_OfferModel ObjInputEntity_OfferModel)
        {
            try
            {
                //Just keep ObjInputEntity_OfferModel as parameter for Deleted Log.
                Entity_Offer ObjEntity_Offer = DBContext.Entity_Offers.Where(a => a.Entity_Offer_ID == id).FirstOrDefault();
                if (ObjEntity_Offer != null)
                {
                    DBContext.Entity_Offers.DeleteOnSubmit(ObjEntity_Offer);
                    DBContext.SubmitChanges();
                    return ObjEntity_Offer.Entity_Offer_ID;
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