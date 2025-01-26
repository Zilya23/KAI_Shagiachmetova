using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Labs2.Models;

namespace Labs2.Controllers
{
    public class StudentsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Students
        public ActionResult Index()
        {
            // Загружаем список специальностей в ViewBag
            ViewBag.Specialties = new SelectList(db.Specialties.ToList(), "ID_Specialties", "Title");
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            ViewBag.ID_Student = new SelectList(db.Evaluations, "ID_Student", "ID_Student");
            ViewBag.ID_Specialties = new SelectList(db.Specialties, "ID_Specialties", "Title");
            return View();
        }

        // POST: Students/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Student,FIO,Gender,Date_Of_Birth,Parents,Address,Phone,Pasport_num,Credit_Card_Number,Date_Of_Receipt,Group,Course,ID_Specialties,Full_Time_Education")] Students students)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(students);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Student = new SelectList(db.Evaluations, "ID_Student", "ID_Student", students.ID_Student);
            ViewBag.ID_Specialties = new SelectList(db.Specialties, "ID_Specialties", "Title", students.ID_Specialties);
            return View(students);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Student = new SelectList(db.Evaluations, "ID_Student", "ID_Student", students.ID_Student);
            ViewBag.ID_Specialties = new SelectList(db.Specialties, "ID_Specialties", "Title", students.ID_Specialties);
            return View(students);
        }

        // POST: Students/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Student,FIO,Gender,Date_Of_Birth,Parents,Address,Phone,Pasport_num,Credit_Card_Number,Date_Of_Receipt,Group,Course,ID_Specialties,Full_Time_Education")] Students students)
        {
            if (ModelState.IsValid)
            {
                db.Entry(students).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Student = new SelectList(db.Evaluations, "ID_Student", "ID_Student", students.ID_Student);
            ViewBag.ID_Specialties = new SelectList(db.Specialties, "ID_Specialties", "Title", students.ID_Specialties);
            return View(students);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Students students = db.Students.Find(id);
            db.Students.Remove(students);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult FilterBySpecialty(int? specialtyId)
        {
            // Загружаем список специальностей в ViewBag
            ViewBag.Specialties = new SelectList(db.Specialties.ToList(), "ID_Specialties", "Title");

            // Фильтруем студентов по выбранной специальности
            var students = db.Students
                .Include(s => s.Specialties)
                .Where(s => specialtyId == null || s.ID_Specialties == specialtyId)
                .ToList();

            return View("Index", students);
        }

        public ActionResult GetStudentGrades(int studentId, int subjectId)
        {
            // Получаем оценки студента по предмету вместе с названием предмета
            var evaluations = db.Evaluations
                .Where(e => e.ID_Student == studentId && (e.ID_Subjects1 == subjectId || e.ID_Subjects2 == subjectId))
                .Select(e => new
                {
                    SubjectTitle = e.ID_Subjects1 == subjectId ? e.Subjects.Title : e.Subjects1.Title,
                    DateExam1 = e.Date_Exam1,
                    Evaluation1 = e.Evaluations1,
                    DateExam2 = e.Date_Exam2,
                    Evaluation2 = e.Evaluations2,
                    AverageScore = e.Average_Score
                })
                .FirstOrDefault();

            // Возвращаем данные в формате JSON
            return Json(evaluations, JsonRequestBehavior.AllowGet);
        }
    }
}
