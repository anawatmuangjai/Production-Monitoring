using PDR.Web.Core;
using PDR.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PDR.Web.Controllers
{
    public class MonitorController : Controller
    {
        private readonly IMonitorRepository repository;

        public MonitorController(IMonitorRepository repository)
        {
            this.repository = repository;
        }

        // GET: Monitor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Monitor/AllZone
        public async Task<ActionResult> AllLine()
        {
            var monitors = await repository.GetAllAsync(null, c => c.MST_LOSS_GROUP);

            var viewModel = new MonitorViewModel
            {
                Monitors = monitors.ToList()
            };

            return View(viewModel);
        }

        // GET: Monitor/Status
        public async Task<ActionResult> Status()
        {
            var monitors = await repository.GetAllAsync(null, c => c.MST_LOSS_GROUP);

            var viewModel = new MonitorViewModel
            {
                Monitors = monitors.ToList()
            };

            return View(viewModel);
        }

        // GET: Monitor/Zone?group=A1
        public async Task<ActionResult> Zone(string group)
        {
            var monitors = await repository.GetAsync(m => m.DISPLAY_GROUP == group, null, c => c.MST_LOSS_GROUP);

            var viewModel = new MonitorViewModel
            {
                Monitors = monitors.ToList()
            };

            return View(viewModel);
        }
    }
}