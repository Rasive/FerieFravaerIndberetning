using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerieFravaerIndberetning.Models
{
    partial class ArbejdsugeTimer
    {
        public float GetArbejdsugeTimerSum()
        {
            float sum = (float)Mandag + (float)Tirsdag + (float)Onsdag + (float)Torsdag + (float)Fredag;

            if (Loerdag != null)
                sum += (float)Loerdag;
            if (Soendag != null)
                sum += (float)Soendag;

            return sum;
        }

        public string WeekToString()
        {
            if (WeekId == 1)
                return "Første";
            if (WeekId == 2)
                return "Anden";
            if (WeekId == 3)
                return "Tredje";
            if (WeekId == 4)
                return "Fjerde";
            if (WeekId == 5)
                return "Femte";
            if (WeekId == 6)
                return "Sjette";

            return WeekId.ToString();
        }

        public override string ToString()
        {
            return "Mandag: " + Mandag + " Tirsdag: " + Tirsdag + " Onsdag: " + Onsdag + " Torsdag: " + Torsdag + " Fredag: " + Fredag + " Lørdag: " + Loerdag + " Søndag: " + Soendag;
        }
    }
}