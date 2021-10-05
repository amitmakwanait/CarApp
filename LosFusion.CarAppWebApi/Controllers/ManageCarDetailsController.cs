using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LosFusion.CarAppWebApi.DataLayer;
using LosFusion.CarAppWebApi.Models;

namespace LosFusion.CarAppWebApi.Controllers
{
    [Authorize]
    public class ManageCarDetailsController : ApiController
    {
       // TestEntities testEntities = new TestEntities();
        private IUnitTestMockingContext testEntities = new UnitTestMockingContext();
        public ManageCarDetailsController()
        { }
        public ManageCarDetailsController(IUnitTestMockingContext context)
        {
            testEntities = context;
        }
        // GET api/values


        [HttpGet]
        //[Route("GetByYear")]
        [Route("api/ManageCarDetails/GetByYear")]

        public IHttpActionResult GetByYear(string Year)
        {
            var obj = testEntities.Items.Where(x => x.YearMade == Year).ToList();
            if (obj.Count <= 0)
            {
                return NotFound();
            }
            return Ok(obj);
        }



        [HttpGet]
        [Route("api/ManageCarDetails/GetByName")]
        public IHttpActionResult GetByName(string Name)
        {
            tbl_CarModel obj = new tbl_CarModel();
            if (!string.IsNullOrEmpty(Name))
            {
                obj = testEntities.Items.Where(x => x.Name.ToLower() == Name.ToLower()).FirstOrDefault();
                if (obj == null)
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPost]
        // POST api/values
        public IHttpActionResult Post([FromBody] CarModel carModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(carModel.Name))
                {
                    var res = testEntities.Items.Where(x => x.Name.ToLower() == carModel.Name.ToLower()).FirstOrDefault();
                    if (res == null)
                    {
                        tbl_CarModel obj = new tbl_CarModel();

                        obj.Name = carModel.Name;
                        obj.Color = carModel.Color;
                        obj.YearMade = carModel.YearMade;

                        testEntities.Items.Add(obj);
                        testEntities.SaveChanges();
                        return Ok("Data Saved Successfully");
                    }
                    else
                    {
                        return BadRequest("Car already exists with same name");
                    }
                }
                else
                {
                    return Ok("Name, Color, Year is required");
                }

            }
            catch (Exception ex)
            {

                throw;
            }

           
        }


    }
}
