using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ScecialController : Controller
    {
        private Model1 db = new Model1();

        // GET: Special
        public ActionResult StudentForSpec(int? specID)
        {
            if (specID == null)
            {
                return HttpNotFound("Идентификатор специальности не указан.");
            }

            List<Students> students = db.Students.Where(x => x.ID_Specialties == specID).ToList();

            return View(students);
        }

        public ActionResult StudentEvaluations(int? evalID, int? studID)
        {
            if (evalID == null)
            {
                return HttpNotFound("Идентификатор предмета не указан.");
            }

            Evaluations studentsEval = db.Evaluations.Where(x => x.ID_Student == studID && (x.ID_Subjects1 == evalID || x.ID_Subjects2 == evalID)).FirstOrDefault();

            return View(studentsEval);
        }

    }
}