using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDR.Core.Interfaces;
using PDR.WebCore.ViewModels;

namespace PDR.WebCore.Controllers
{
    public class MonitorController : Controller
    {
        private readonly IMonitorService _monitorService;

        public MonitorController(IMonitorService monitorService)
        {
            _monitorService = monitorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllLine()
        {
            var monitorDetails = await _monitorService.GetMonitorDetails();

            var viewModel = new MonitorViewModel
            {
                MonitorDetails = monitorDetails
            };

            return View();
        }

        public async Task<IActionResult> Status()
        {
            var monitorDetails = await _monitorService.GetMonitorDetails();

            var viewModel = new MonitorViewModel
            {
                MonitorDetails = monitorDetails
            };

            return View();
        }

        public async Task<IActionResult> Zone(string zone)
        {
            if (String.IsNullOrEmpty(zone))
                return NotFound();

            var monitorDetails = await _monitorService.GetMonitorDetailByZone(zone);

            var viewModel = new MonitorViewModel
            {
                MonitorDetails = monitorDetails
            };

            return View(viewModel);
        }
    }
}