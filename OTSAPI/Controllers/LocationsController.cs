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
    /// LocationsController 
    /// <remarks>Handle all CRUD Operations</remarks>
    /// </summary>
    public class LocationsController : ApiController
    {
        #region Database CRUD (Create, Read, Update, Delete) Operations
        DataClasses_DataContext DBContext = new DataClasses_DataContext();
        #region Create / Insert
        [HttpPost]
        public int Create(Location ObjLocations)
        {
            try
            {
                DBContext.Locations.InsertOnSubmit(ObjLocations);
                DBContext.SubmitChanges();
                return ObjLocations.Location_ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Read / Select
        [HttpGet]
        public List<usp_LocationsSelectResult> Index(int? id = null)
        {
            try
            {
                return DBContext.usp_LocationsSelect(id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Update / Edit
        [HttpPost]
        public int Edit(int id, LocationsModel ObjLocationsModel)
        {
            try
            {
                if (id > 0)
                {
                    if (ObjLocationsModel != null)
                    {
                        Location ObjLocations = DBContext.Locations.Where(a => a.Location_ID == id).FirstOrDefault();
                        if (ObjLocations != null)
                        {
                            //LocationsModel Edit Properties mapping here. 
                            //ObjLocations.Profile_Name = ObjLocationsModel.Profile_Name;
                            //ObjLocations.Password = ObjLocationsModel.Password;
                            //ObjLocations.First_Name = ObjLocationsModel.First_Name;
                            //ObjLocations.Middle_Name = ObjLocationsModel.Middle_Name;
                            //ObjLocations.Last_Name = ObjLocationsModel.Last_Name;
                            //ObjLocations.Email_Address = ObjLocationsModel.Email_Address;
                            //ObjLocations.Contact_Number = ObjLocationsModel.Contact_Number;
                            //ObjLocations.Cell_Number = ObjLocationsModel.Cell_Number;
                            //ObjLocations.Location_ID = ObjLocationsModel.Location_ID;
                            //ObjLocations.PickUp_Address = ObjLocationsModel.PickUp_Address;
                            //ObjLocations.Drop_Address = ObjLocationsModel.Drop_Address;
                            //ObjLocations.QR_Code = ObjLocationsModel.QR_Code;
                            //ObjLocations.Rating = ObjLocationsModel.Rating;
                            //ObjLocations.Created_DateTime = ObjLocationsModel.Created_DateTime;
                            //ObjLocations.Created_By = ObjLocationsModel.Created_By;
                            //ObjLocations.Modified_DateTime = ObjLocationsModel.Modified_DateTime;
                            //ObjLocations.Modified_By = ObjLocationsModel.Modified_By;
                            //ObjLocations.Deleted = ObjLocationsModel.Deleted;
                            DBContext.SubmitChanges();
                            return ObjLocations.Location_ID;
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
        public int Delete(int id, LocationsModel ObjInputLocationsModel)
        {
            try
            {
                //Just keep ObjInputLocationsModel as parameter for Deleted Log.
                Location ObjLocations = DBContext.Locations.Where(a => a.Location_ID == id).FirstOrDefault();
                if (ObjLocations != null)
                {
                    DBContext.Locations.DeleteOnSubmit(ObjLocations);
                    DBContext.SubmitChanges();
                    return ObjLocations.Location_ID;
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