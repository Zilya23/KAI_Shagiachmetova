using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Labs3;

namespace Labs3.Controllers
{
    [RoutePrefix("api/Subjects")] // Префикс маршрута для контроллера
    public class SubjectsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Subjects
        [HttpGet]
        [Route("")] // Маршрут для метода
        public IHttpActionResult GetSubjects()
        {
            try
            {
                var subjects = db.Subjects
                    .Select(s => new
                    {
                        s.ID_Subjects,
                        s.Title
                    })
                    .ToList();

                return Ok(subjects);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}