using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ATGHR.Controllers
{
    public class ATGProcessesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult StrategicPlan()
		{
			return View();
		}

		public IActionResult AnnualBusinessPlan()
		{
			return View();
		}

		public IActionResult BusinessDevelopment()
		{
			return View();
		}

		public IActionResult Contracts()
		{
			return View();
		}

		public IActionResult ProjectExecution()
		{
			return View();
		}

		public IActionResult Resources()
		{
			return View();
		}

		public IActionResult SOPs()
		{
			return View();
		}

		public IActionResult TxDOTContract()
		{
			return View();
		}

		public IActionResult StandardContract()
		{
			return View();
		}

		public IActionResult ProjectCloseout()
		{
			return View();
		}

		public IActionResult RecordsRetention()
		{
			return View();
		}
	}

}
