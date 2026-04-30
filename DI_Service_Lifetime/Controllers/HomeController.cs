using DI_Service_Lifetime.Models;
using DI_Service_Lifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DI_Service_Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly _ITransientService? _transientService1;
        private readonly _ITransientService? _transientService2;

        private readonly _IScopedService? _scopedService1;
        private readonly _IScopedService? _scopedService2;

        private readonly _ISingletonService? _singletonService1;
        private readonly _ISingletonService? _singletonService2;

        public HomeController(_ITransientService transientService1, _ITransientService transientService2, 
                              _IScopedService scopedService1, _IScopedService scopedService2, 
                              _ISingletonService singletonService1, _ISingletonService singletonService2
            )
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendLine($"Transient Service 1: {_transientService1?.getGuid()} \n");
            msg.AppendLine($"Transient Service 2: {_transientService2?.getGuid()} \n");

            msg.AppendLine($"Scoped Service 1: {_scopedService1?.getGuid()} \n");
            msg.AppendLine($"Scoped Service 2: {_scopedService2?.getGuid()} \n");

            msg.AppendLine($"Singleton Service 1: {_singletonService1?.getGuid()} \n");
            msg.AppendLine($"Singleton Service 2: {_singletonService2?.getGuid()} \n");

            return Ok(msg.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
