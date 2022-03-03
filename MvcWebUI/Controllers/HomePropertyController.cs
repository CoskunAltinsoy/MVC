using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System.Diagnostics;

namespace MvcWebUI.Controllers
{
    public class HomePropertyController : Controller
    {
        IHomePropertyService _homePropertyService;
        public HomePropertyController(IHomePropertyService homePropertyService)
        {
            _homePropertyService = homePropertyService;
        }

        public IActionResult Index()
        {          
            return View(_homePropertyService.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(HomeProperty homeProperty)
        {
            homeProperty.ListingDate = DateTime.Now;
            _homePropertyService.Add(homeProperty);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            _homePropertyService.GetById(id);
            return View(_homePropertyService.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(HomeProperty homeProperty)
        {
            _homePropertyService.Update(homeProperty);
            return RedirectToAction("index");
        }

        
        public IActionResult Delete(int id)
        {
            var model = _homePropertyService.GetById(id);
            _homePropertyService.Delete(model);
            return RedirectToAction("index");
        }


    }
}