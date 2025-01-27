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
    [RoutePrefix("api/Students")]
    public class StudentsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Students/FailedStudents?subjectId=1
        [HttpGet]
        [Route("FailedStudents")]
        public IHttpActionResult GetFailedStudents(int subjectId)
        {
            try
            {
                // Находим студентов, не сдавших предмет
                var failedStudents = db.Students
                    .Where(s => s.Evaluations != null &&
                                ((s.Evaluations.ID_Subjects1 == subjectId && s.Evaluations.Evaluations1 < 3) ||
                                 (s.Evaluations.ID_Subjects2 == subjectId && s.Evaluations.Evaluations2 < 3)))
                    .Select(s => new
                    {
                        s.ID_Student,
                        s.FIO,
                        s.Group,
                        s.Course,
                        Specialty = s.Specialties.Title
                    })
                    .ToList();

                return Ok(failedStudents);
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                return InternalServerError(ex);
            }
        }
    }
}