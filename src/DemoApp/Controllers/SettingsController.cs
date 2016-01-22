using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApp.Controllers
{
    public class SettingsController : Controller
    {
        private IOptions<AppSettings> _appSettings;

        public SettingsController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _appSettings.Value.Message;            
            return View();
        }
    }
}
