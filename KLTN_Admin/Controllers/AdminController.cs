using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLTN_Admin.Logic;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using X.PagedList;

namespace KLTN_Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminLogic adminLogic;

        public IActionResult Index()
        {
            return View();
        }
    }
}