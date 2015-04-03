using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public static List<CalculatedType> Types = new List<CalculatedType>()
        {
             new CalculatedType{Value = "b" , Name = "bit - b" },
             new CalculatedType{Value = "B", Name = "Byte - B" },
             new CalculatedType{Value = "Kb" , Name = "Kilobit - Kb" },
             new CalculatedType{Value = "KB", Name = "Kilobyte - KB" },
             new CalculatedType{Value = "Mb" , Name = "Megabit - Mb" },
             new CalculatedType{Value = "MB", Name = "Megabyte - MB" },
             new CalculatedType{Value = "Gb" , Name = "Gigabit - Gb" },
             new CalculatedType{Value = "GB", Name = "Gigabyte - GB" },
             new CalculatedType{Value = "Tb" , Name = "Terabit - Tb" },
             new CalculatedType{Value = "TB", Name = "Terabyte - TB" },
             new CalculatedType{Value = "Pb" , Name = "Petabit - Pb" },
             new CalculatedType{Value = "PB", Name = "Petabyte - PB" },
             new CalculatedType{Value = "Eb" , Name = "Exabit - Eb" },
             new CalculatedType{Value = "EB", Name = "Exabyte - EB" },
             new CalculatedType{Value = "Zb" , Name = "Zettabit - Zb" },
             new CalculatedType{Value = "ZB", Name = "Zettabyte - ZB" },
             new CalculatedType {Value="Yb", Name= "Yottabit - Yb"},
             new CalculatedType {Value="YB", Name= "Yottabyte - YB"}
        };
        // GET: Calculator
        public ActionResult Index()
        {
            var dropDownItems = Types.Select(t => new SelectListItem { Text = t.Name, Value = t.Value }).ToList();
            return View(dropDownItems);
        }

        public ActionResult Result(CalculatorConfigurationModel query)
        {
            int kilo = query.Kilo;
            double b = 0;

            if (query.Quantity != 0)
            {
                switch(query.Types)
                {
                    case "b": b = query.Quantity / (8 * Math.Pow(kilo, 2));
                        break;
                    default :
                            break;
                }
            }
            return null;
        }
    }
}