using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ATGHR.Code;
using ATGHR.Code.Enums;
using ATGHR.Models.Database;

namespace ATGHR.Controllers
{
	[Authorize]
	[PermissionsRequired(PermissionType = PermissionType.Self)]
	[PermissionsRequired(PermissionType = PermissionType.Administrator)]
	public class AdminController : Controller
	{
		[Route(template: "/Admin/User/{id?}")]
		public ActionResult UserManagement()
		{
			Int64? userId;
			if (this.RouteData.Values["id"] != null)
			{
				if (this.RouteData.Values["id"]?.ToString() == "new")
				{
					userId = -1;
				}
				else
				{
					userId = Util.Nz<Int64>(this.RouteData.Values["id"]?.ToString(), -1);
					((UserAction)HttpContext.Items["UserAction"]).UserId = userId;
				}

				return View("UserEdit", userId);
			}
			return View("User");
		}

		[Route(template: "/Admin/Reports")]
		public ActionResult AdminSheetList()
		{
			return View("Reports");
		}

		[Route(template: "/Admin/PerformanceFieldExample/{id?}")]
		public ActionResult ExampleManagement()
		{
			Int64? performanceFieldExampleId;
			if (this.RouteData.Values["id"] != null)
			{
				if (this.RouteData.Values["id"]?.ToString() == "new")
				{
					performanceFieldExampleId = -1;
				}
				else
				{
					performanceFieldExampleId = Util.Nz<Int64>(this.RouteData.Values["id"]?.ToString(), -1);
				}
				return View("performanceFieldExampleEdit", performanceFieldExampleId);
			}
			return View("performanceFieldExample");
		}
	}
}
