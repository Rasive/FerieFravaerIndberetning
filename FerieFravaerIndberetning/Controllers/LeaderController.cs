using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FerieFravaerIndberetning.Models;

namespace FerieFravaerIndberetning.Controllers
{
    public class LeaderController : Controller
    {
        FerieFravaerDBClassesDataContext db = new FerieFravaerDBClassesDataContext();

        //
        // GET: /Leader/

        public ActionResult Index()
        {
            List<Ferie> ferieindberetninger = (from ferie in db.Feries where ferie.Indberettet == false select ferie).ToList<Ferie>();

            List<Fravaer> fravaerindberetninger = (from fravaer in db.Fravaers where fravaer.Indberettet == false select fravaer).ToList<Fravaer>();

            return View(new Tuple<List<Ferie>, List<Fravaer>>(ferieindberetninger, fravaerindberetninger));
        }

        public void Godkend(int id, string type)
        {
            if (type == "ferie")
            {
                Ferie ferie = (from f in db.Feries where f.Id == id select f).SingleOrDefault();
                ferie.Godkendt = true;
                ferie.Afvist = false;
                db.SubmitChanges();
            }
            else if (type == "fravaer")
            {
                Fravaer fravaer = (from f in db.Fravaers where f.Id == id select f).SingleOrDefault();
                fravaer.Godkendt = true;
                fravaer.Afvist = false;
                db.SubmitChanges();
            }
        }

        public void Afvis(int id, string type)
        {
            if (type == "ferie")
            {
                Ferie ferie = (from f in db.Feries where f.Id == id select f).SingleOrDefault();
                ferie.Godkendt = false;
                ferie.Afvist = true;
                db.SubmitChanges();
            }
            else if (type == "fravaer")
            {
                Fravaer fravaer = (from f in db.Fravaers where f.Id == id select f).SingleOrDefault();
                fravaer.Godkendt = false;
                fravaer.Afvist = true;
                db.SubmitChanges();
            }
        }

    }
}
