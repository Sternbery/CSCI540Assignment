using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SurveySays.Models;

namespace SurveySays.Views
{
    public class SurveyQuestionsController : Controller
    {
        private SurveySaysDBEntities db = new SurveySaysDBEntities();

        // GET: SurveyQuestions
        public ActionResult Index()
        {
            var surveyQuestions = db.SurveyQuestions.Include(s => s.Survey).Include(s => s.TypeEnum);
            return View(surveyQuestions.ToList());
        }

        // GET: SurveyQuestions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyQuestion surveyQuestion = db.SurveyQuestions.Find(id);
            if (surveyQuestion == null)
            {
                return HttpNotFound();
            }
            return View(surveyQuestion);
        }

        // GET: SurveyQuestions/Create
        public ActionResult Create()
        {
            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name");
            ViewBag.QuestionTypeID = new SelectList(db.TypeEnums, "QuestionTypeID", "TypeName");
            return View();
        }

        // POST: SurveyQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestionID,SurveyID,Text,QuestionTypeID")] SurveyQuestion surveyQuestion)
        {
            if (ModelState.IsValid)
            {
                db.SurveyQuestions.Add(surveyQuestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name", surveyQuestion.SurveyID);
            ViewBag.QuestionTypeID = new SelectList(db.TypeEnums, "QuestionTypeID", "TypeName", surveyQuestion.QuestionTypeID);
            return View(surveyQuestion);
        }

        // GET: SurveyQuestions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyQuestion surveyQuestion = db.SurveyQuestions.Find(id);
            if (surveyQuestion == null)
            {
                return HttpNotFound();
            }
            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name", surveyQuestion.SurveyID);
            ViewBag.QuestionTypeID = new SelectList(db.TypeEnums, "QuestionTypeID", "TypeName", surveyQuestion.QuestionTypeID);
            return View(surveyQuestion);
        }

        // POST: SurveyQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestionID,SurveyID,Text,QuestionTypeID")] SurveyQuestion surveyQuestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surveyQuestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name", surveyQuestion.SurveyID);
            ViewBag.QuestionTypeID = new SelectList(db.TypeEnums, "QuestionTypeID", "TypeName", surveyQuestion.QuestionTypeID);
            return View(surveyQuestion);
        }

        // GET: SurveyQuestions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyQuestion surveyQuestion = db.SurveyQuestions.Find(id);
            if (surveyQuestion == null)
            {
                return HttpNotFound();
            }
            return View(surveyQuestion);
        }

        // POST: SurveyQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SurveyQuestion surveyQuestion = db.SurveyQuestions.Find(id);
            db.SurveyQuestions.Remove(surveyQuestion);
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
    }
}
