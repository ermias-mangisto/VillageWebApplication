using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using VillageWebApplication.Models;

namespace VillageWebApplication.Controllers.api
{
    public class ResidentsController : ApiController
    {
        private Village db = new Village();

        // GET: api/Residents
        public IHttpActionResult GetResidents()
        {
            try
            {
           return Ok( db.Residents);
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

        // GET: api/Residents/5
     
        public async Task<IHttpActionResult> GetResident(int id)
        {
            try
            {
             Resident resident = await db.Residents.FindAsync(id);
            if (resident == null)
              {
                return NotFound();
                 }
            return Ok( resident);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           

            
        }

        // PUT: api/Residents/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutResident(int id, [FromBody]Resident resident)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Resident resident1 = await db.Residents.FindAsync(id);
                if (resident1 != null)
                {
                    resident1.Id = resident.Id;
                    resident1.Name = resident.Name;
                    resident1.FatherName = resident.FatherName;
                    resident1.BornInVillage = resident.BornInVillage;
                    resident1.Birth = resident.Birth;
                    await db.SaveChangesAsync();
                    return Ok(resident1);
                };
                return NotFound();
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

        // POST: api/Residents
  
        public async Task<IHttpActionResult> PostResident(Resident resident)
        {
            
            try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }
                    db.Residents.Add(resident);
                    await db.SaveChangesAsync();
                    return Ok(db.Residents);
                }
                catch (SqlException ex) { return BadRequest(ex.Message); }
            
           
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Residents/5

        public async Task<IHttpActionResult> DeleteResident(int id)
        {
            try
            {
       Resident resident = await db.Residents.FindAsync(id);
            if (resident == null)
            {
                return NotFound();
            }

            db.Residents.Remove(resident);
            await db.SaveChangesAsync();

            return Ok(db.Residents);
            }catch (SqlException ex) { return BadRequest(ex.Message); }
            catch(Exception ex) { return BadRequest(ex.Message); }
     
        }

      
    }
}