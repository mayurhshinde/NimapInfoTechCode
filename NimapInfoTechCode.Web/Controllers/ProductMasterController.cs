using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NimapInfoTechCode.Core.ViewModel;
using NimapInfoTechCode.Infrastructure.Interfaces;

namespace NimapInfoTechCode.Web.Controllers
{
    public class ProductMasterController : Controller
    {
        private readonly IProductMasterRepository _repository;
        public ProductMasterController(IProductMasterRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult Index(int PageNo = 1, int PageSize = 10)
        {
            var result = _repository.GetAll(PageNo, PageSize);
            return View(result);
        }
        [HttpGet]
        public ActionResult AddUpdate(int Id)
        {
            var result = _repository.GetById(Id);
            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddUpdate(ProductMasterVM category)
        { 
            var result = await _repository.AddUpdate(category);
            if (result.IsError == true)
            {
                ViewBag.Message = result.Message;
                return View(result);
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