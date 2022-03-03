using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;


namespace MvcWebUI.Controllers
{
    public class LandPropertyController : Controller
    {
        ILandPropertyService _landPropertyService;
        public LandPropertyController(ILandPropertyService landPropertyService)
        {
            _landPropertyService = landPropertyService;
        }
        public IActionResult Index()
        {
            return View(_landPropertyService.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(LandProperty landProperty)
        { 
            LandPropertyValidator landPropertyValidator = new LandPropertyValidator();
            ValidationResult results = landPropertyValidator.Validate(landProperty);
            if (results.IsValid)
            {
                landProperty.ListingDate = DateTime.Now;
                _landPropertyService.Add(landProperty);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult Update(int id)
        {        
            return View(_landPropertyService.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(LandProperty landProperty)
        {
            
            _landPropertyService.Update(landProperty);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            var model = _landPropertyService.GetById(id);
            _landPropertyService.Delete(model);
            return RedirectToAction("index");
        }
    }
}
