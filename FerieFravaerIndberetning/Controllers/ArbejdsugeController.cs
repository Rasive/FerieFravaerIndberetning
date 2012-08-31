using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FerieFravaerIndberetning.Models;

namespace FerieFravaerIndberetning.Controllers
{
    public class ArbejdsugeController : Controller
    {
        int profileid = 1; // Fra session
        FerieFravaerDBClassesDataContext db = new FerieFravaerDBClassesDataContext();
        //
        // GET: /Arbejdsuge/

        public ActionResult Index()
        {
            var arbejdsugetimer = from aut in db.ArbejdsugeTimers where aut.Id == profileid select aut;
            if (arbejdsugetimer.Count() > 0)
                return View(arbejdsugetimer);
            else
            {
                arbejdsugetimer = from aut in db.ArbejdsugeTimers where aut.Id == -1 select aut; // Brug template hvis bruger ikke har angivet sin arbejdsuge
                return View(arbejdsugetimer);
            }
        }

        [HttpPost]
        public ActionResult Update(ArbejdsugeTimer arbejdsugetimeredited, int weekId = 1)
        {
            var arbejdsugetimer = from aut in db.ArbejdsugeTimers where aut.Id == profileid && aut.WeekId == weekId select aut;
            if (arbejdsugetimer.Count() == 0)
                return Create(arbejdsugetimeredited, weekId);

            ArbejdsugeTimer singleaut = arbejdsugetimer.Single();
            singleaut.Mandag = arbejdsugetimeredited.Mandag;
            singleaut.Tirsdag = arbejdsugetimeredited.Tirsdag;
            singleaut.Onsdag = arbejdsugetimeredited.Onsdag;
            singleaut.Torsdag = arbejdsugetimeredited.Torsdag;
            singleaut.Fredag = arbejdsugetimeredited.Fredag;
            singleaut.Loerdag = arbejdsugetimeredited.Loerdag;
            singleaut.Soendag = arbejdsugetimeredited.Soendag;

            db.SubmitChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Create(ArbejdsugeTimer arbejdsugetimerinsert, int weekId = 1)
        {
            arbejdsugetimerinsert.WeekId = weekId;
            arbejdsugetimerinsert.Id = profileid;
            db.ArbejdsugeTimers.InsertOnSubmit(arbejdsugetimerinsert);

            db.SubmitChanges();

            return Redirect("Index");
        }
    }
}
