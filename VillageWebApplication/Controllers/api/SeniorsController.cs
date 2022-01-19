using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VillageWebApplication.Models;

namespace VillageWebApplication.Controllers.api
{
    public class SeniorsController : ApiController
    {
        static string ConectionString = "Data Source=CND02744PN;Initial Catalog=Elders;Integrated Security=True;Pooling=False";
        EldersDataContext DataContext = new EldersDataContext(ConectionString);
        // GET: api/Seniors
        public IHttpActionResult Get()
        {
            try { 
            return Ok(DataContext.Seniors.ToList());
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Seniors/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(DataContext.Seniors.First((item) => item.Id == id));
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST: api/Seniors
        public IHttpActionResult Post([FromBody]Senior value)
        {
            try
            {
                DataContext.Seniors.InsertOnSubmit(value);
                DataContext.SubmitChanges();
                return Ok(DataContext.Seniors.ToList());
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Seniors/5
        public IHttpActionResult Put(int id, [FromBody]Senior value)
        {
            try
            {
                Senior senior1 = DataContext.Seniors.First((item) => item.Id == id);
                senior1.Name = value.Name;
                senior1.BirthDate = value.BirthDate;
                senior1.Seniorty = value.Seniorty;
                DataContext.SubmitChanges();
                return Ok(senior1);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Seniors/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                DataContext.Seniors.DeleteOnSubmit(DataContext.Seniors.First((item) => item.Id == id));
                DataContext.SubmitChanges();
                return Ok(DataContext.Seniors);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
  

 

   




   


  
}
