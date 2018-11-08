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
    public class SurveyResponsesController : Controller
    {
        private SurveySaysDBEntities db = new SurveySaysDBEntities();

        // GET: SurveyResponses
        public ActionResult Index()
        {
            var surveyResponses = db.SurveyResponses.Include(s => s.Survey).Include(s => s.User);
            return View(surveyResponses.ToList());
        }

        // GET: SurveyResponses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyResponse surveyResponse = db.SurveyResponses.Find(id);
            if (surveyResponse == null)
            {
                return HttpNotFound();
            }
            return View(surveyResponse);
        }

        // GET: SurveyResponses/Create
        public ActionResult Create()
        {
            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Email");
            return View();
        }

        // POST: SurveyResponses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResponseID,UserID,SurveyID,DateTaken,TakerCode")] SurveyResponse surveyResponse)
        {
            if (ModelState.IsValid)
            {
                db.SurveyResponses.Add(surveyResponse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name", surveyResponse.SurveyID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Email", surveyResponse.UserID);
            return View(surveyResponse);
        }

        // GET: SurveyResponses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyResponse surveyResponse = db.SurveyResponses.Find(id);
            if (surveyResponse == null)
            {
                return HttpNotFound();
            }
            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name", surveyResponse.SurveyID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Email", surveyResponse.UserID);
            return View(surveyResponse);
        }

        // POST: SurveyResponses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResponseID,UserID,SurveyID,DateTaken,TakerCode")] SurveyResponse surveyResponse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surveyResponse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SurveyID = new SelectList(db.Surveys, "SurveyID", "Name", surveyResponse.SurveyID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Email", surveyResponse.UserID);
            return View(surveyResponse);
        }

        // GET: SurveyResponses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SurveyResponse surveyResponse = db.SurveyResponses.Find(id);
            if (surveyResponse == null)
            {
                return HttpNotFound();
            }
            return View(surveyResponse);
        }

        // POST: SurveyResponses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SurveyResponse surveyResponse = db.SurveyResponses.Find(id);
            db.SurveyResponses.Remove(surveyResponse);
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
