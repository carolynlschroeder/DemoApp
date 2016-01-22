using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApp.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            var model = new AlbumModel
            {
                Id = Guid.NewGuid(),
                Title = "Jagged Little Pill",
                Artist = "Alanis Morissette",
                Price = Convert.ToDecimal(12.99)
            };
            ViewBag.QuantitySelectList = GetQuantitySelectList();
            return View(model);
        }

        public static SelectList GetQuantitySelectList()
        {
            var quantityDictionary = GetDictionary();
            return
                new SelectList(
                    ((Dictionary<int, int>)quantityDictionary).Select(x => new { value = x.Key, text = x.Value }),
                    "value", "text");
        }

        public static Dictionary<int, int> GetDictionary()
        {
            var quantityDictionary = new Dictionary<int, int>();
            for (int i = 1; i <= 10; i++)
            {
                quantityDictionary.Add(i, i);
            }
            return quantityDictionary;
        }
    }
}
