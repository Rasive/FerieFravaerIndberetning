using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FerieFravaerIndberetning.Models;

namespace FerieFravaerIndberetning.Controllers
{
    public class FerieFravaerController : Controller
    {
        int profileid = 1; // Fra session
        FerieFravaerDBClassesDataContext db = new FerieFravaerDBClassesDataContext();

        //
        // GET: /FerieFravaer/

        public ActionResult Index()
        {
            var indberetningstypes = from type in db.Indberetningstypes select type;

            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem() { Text = "----------------------", Value = "-----", Selected = true });
            foreach (Indberetningstype type in indberetningstypes)
            {
                items.Add(new SelectListItem() { Text = type.Navn, Value = type.Id, Selected = false });
            }

            FerieFravaer feriefravaer = new FerieFravaer() { Indberetningstyper = items };
            return View(feriefravaer);
        }

        public string CalcFeriedageOgTimer(int fromYear, int fromMonth, int fromDay, int toYear, int toMonth, int toDay)
        {
            DateTime foersteFeriedag = new DateTime(fromYear, fromMonth, fromDay);
            DateTime sidsteFeriedag = new DateTime(toYear, toMonth, toDay);

            Tuple<int, double> ret = CalcFeriedageOgTimer(foersteFeriedag, sidsteFeriedag);

            return ret.Item1 + ";" + ret.Item2;
        }

        private Tuple<int, double> CalcFeriedageOgTimer(DateTime foersteFeriedag, DateTime sidsteFeriedag)
        {
            ArbejdsugeTimer arbejdsuge = (from arbejdsugeTimer in db.ArbejdsugeTimers where arbejdsugeTimer.Id == profileid select arbejdsugeTimer).Single();
            int feriedage = 0;
            double ferietimer = 0f;

            for (DateTime date = foersteFeriedag; date <= sidsteFeriedag; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Monday && arbejdsuge.Mandag > 0)
                {
                    feriedage++;
                    ferietimer += arbejdsuge.Mandag;
                }
                else if (date.DayOfWeek == DayOfWeek.Tuesday && arbejdsuge.Tirsdag > 0)
                {
                    feriedage++;
                    ferietimer += arbejdsuge.Tirsdag;
                }
                else if (date.DayOfWeek == DayOfWeek.Wednesday && arbejdsuge.Onsdag > 0)
                {
                    feriedage++;
                    ferietimer += arbejdsuge.Onsdag;
                }
                else if (date.DayOfWeek == DayOfWeek.Thursday && arbejdsuge.Torsdag > 0)
                {
                    feriedage++;
                    ferietimer += arbejdsuge.Torsdag;
                }
                else if (date.DayOfWeek == DayOfWeek.Friday && arbejdsuge.Fredag > 0)
                {
                    feriedage++;
                    ferietimer += arbejdsuge.Fredag;
                }
                else if (date.DayOfWeek == DayOfWeek.Saturday && arbejdsuge.Loerdag > 0)
                {
                    feriedage++;
                    ferietimer += (double)arbejdsuge.Loerdag;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday && arbejdsuge.Soendag > 0)
                {
                    feriedage++;
                    ferietimer += (double)arbejdsuge.Soendag;
                }
            }

            return new Tuple<int, double>(feriedage, ferietimer);
        }

        [HttpPost]
        public ActionResult Opsummering(FormCollection formCollection, FerieFravaer feriefravaer)
        {
            ViewBag.Indberetningstype = (from type in db.Indberetningstypes where type.Id == formCollection["Indberetningstype"] select type.Navn).Single();

            if (formCollection["Indberetningstype"] == "FERIE")
            {
                // Quick hax for at få .NET til altid at bruge dd-MM-yyyy
                feriefravaer.Ferie.FoersteFeriedag = DateTime.ParseExact(formCollection["Ferie_FoersteFeriedag"], "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                feriefravaer.Ferie.SidsteFeriedag = DateTime.ParseExact(formCollection["Ferie_SidsteFeriedag"], "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                // ---
                Tuple<int, double> feriedagetimer = CalcFeriedageOgTimer(feriefravaer.Ferie.FoersteFeriedag, feriefravaer.Ferie.SidsteFeriedag);
                feriefravaer.Ferie.Feriedage = feriedagetimer.Item1;
                feriefravaer.Ferie.Ferietimer = feriedagetimer.Item2;
            }
            else if(formCollection["Indberetningstype"] == "FOSYG")
            {
                feriefravaer.Fravaer = new Fravaer();
                if (formCollection["Fravaer_FoersteSygedag"] != null)  feriefravaer.Fravaer.FoersteFravaersdag = DateTime.ParseExact(formCollection["Fravaer_FoersteSygedag"], "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                if(formCollection["Fravaer_SidsteSygedag"] != null) feriefravaer.Fravaer.SidsteFravaersdag = DateTime.ParseExact(formCollection["Fravaer_SidsteSygedag"], "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            }
            

            return View(feriefravaer);
        }

        [HttpPost]
        public ActionResult Indberet(FerieFravaer feriefravaer)
        {
            if (feriefravaer.Ferie != null)
            {
                
                db.Feries.InsertOnSubmit(feriefravaer.Ferie);
                db.SubmitChanges();
            }
            else if (feriefravaer.Fravaer != null)
            {
                db.Fravaers.InsertOnSubmit(feriefravaer.Fravaer);
                db.SubmitChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
