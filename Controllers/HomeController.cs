using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ATG.DBNet;
using ATGHR.Models;
using ATGHR.Code;
using ATGHR.Code.Enums;
using ATGHR.Models.Database;

namespace ATGHR.Controllers
{
	[Authorize]
	[PermissionsRequired(PermissionType = PermissionType.Authorized)]
	public class HomeController : Controller
	{
		[PermissionsRequired(PermissionType = PermissionType.Any)]
		public IActionResult Index()
		{
			return View();
		}

		[PermissionsRequired(PermissionType = PermissionType.Any)]
		public IActionResult NoAccess()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		[PermissionsRequired(PermissionType = PermissionType.Any)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
