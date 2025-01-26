using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laba2.Controllers
{
    public class SpecialnoctController : Controller
    {
        public static KAI_ZilyaEntities db = new KAI_ZilyaEntities();

        public ActionResult AllStudents()
        {
            // Получаем всех студентов из базы данных
            List<Students> students = db.Students.ToList();


            // Передаем список студентов в представление
            return View(students);
        }
    }
}