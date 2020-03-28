using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NimapInfoTechCode.Core.ViewModel;
using NimapInfoTechCode.Infrastructure.Interfaces;

namespace NimapInfoTechCode.Web.Controllers
{
    public class CategoryMasterController : Controller
    {
        private readonly ICategoryMasterRepository _repository;

        public CategoryMasterController(ICategoryMasterRepository repository)
        {
            _repository = repository;
        }
        // GET: CategoryMaster
        [HttpGet]
        public ActionResult Index(int pageNo = 1, int pageSize = 10)
        {
            var result = _repository.GetAll(pageNo, pageSize);
            return View(result);
        }

        [HttpGet]
        public ActionResult AddUpdate(int Id)
        {
            var result = _repository.GetById(Id);
            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddUpdate(CategoryMasterVM category)
        {
            var result = await _repository.AddUpdate(category);
            if (result.IsError == true)
            {
                ViewBag.Message = result.Message;
                return View(result.category);
            }
            else
            {
                TempData["Message"] = result.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var result = _repository.Delete(Id);
            TempData["Message"] = result.Message;
            return RedirectToAction("Index");
        }

    }
}