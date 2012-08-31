using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FerieFravaerIndberetning.Models
{
    public class FerieFravaer
    {
        public Ferie Ferie { get; set; }
        public Fravaer Fravaer { get; set; }
        public List<SelectListItem> Indberetningstyper { get; set; }
    }
}