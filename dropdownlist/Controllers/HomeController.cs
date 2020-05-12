using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dropdownlist.Models;

namespace dropdownlist.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController( ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            List<Province> ListProvice = _db.provinceTbl.ToList();
            Province model = new Province
            {
                ID = -1,
                ProvinceName = "لطفا یک استان را انتخاب نمایید ..."
            };

            ListProvice.Insert(0, model);


            ViewBag.ListPrv = ListProvice;
            return View();
        }

        [HttpPost]
        public IActionResult getCity(int id)
        {

            var cityList = _db.cityTbl.Where(c => c.ProvinceID == id)
                .Select(c => new { id = c.ID, cname = c.CityName }).ToList();

            return Json(new { status = "success", cityList });
        }

        [HttpPost]
        public IActionResult Register(userInfo model)
        {
            if (ModelState.IsValid)
            {
                //insert
            }
            return View("Index", model);
        }


    }
}
