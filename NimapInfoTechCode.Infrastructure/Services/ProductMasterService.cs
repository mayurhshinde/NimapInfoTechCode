using NimapInfoTechCode.Core.DTO;
using NimapInfoTechCode.Core.Entities;
using NimapInfoTechCode.Core.ViewModel;
using NimapInfoTechCode.Infrastructure.Helper;
using NimapInfoTechCode.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimapInfoTechCode.Infrastructure.Services
{
    public class ProductMasterService : IProductMasterRepository
    {
        private readonly DataContext _context;
        public ProductMasterService(DataContext context)
        {
            _context = context;
        }

        public async Task<ProductMasterDto> AddUpdate(ProductMasterVM productMasterVM)
        {
            ProductMasterDto productMasterDto = new ProductMasterDto();
            productMasterDto.IsError = false;
            ProductMaster productMaster = new ProductMaster();
            productMasterDto.categories = _context.CategoryMaster.Where(a => a.IsActive == true).OrderBy(a => a.Name).ToList();
            if (productMasterVM.Name == null || productMasterVM.Name.Trim() == "")
            {
                productMasterDto.IsError = true;
                productMasterDto.Message = "Enter Product Name";
                return productMasterDto;
            }

            if (productMasterVM.ID > 0)
            {
                productMaster = _context.ProductMaster.SingleOrDefault(a => a.ID == productMasterVM.ID);
                if (productMaster != null)
                {
                    productMaster.Name = productMasterVM.Name.Trim();
                    productMaster.IsActive = productMasterVM.IsActive;
                    productMaster.CategoryId = productMasterVM.CategoryId;
                    productMaster.IsActive = productMasterVM.IsActive;
                    _context.Update(productMaster);
                    productMasterDto.product = productMaster;
                    productMasterDto.Message = "Product Updated!";
                }
                else
                {
                    productMasterDto.IsError = true;
                    productMasterDto.Message = "Id not exists!";
                    productMasterDto.product = null;
                }
            }
            else
            {
                productMaster = _context.ProductMaster.SingleOrDefault(a => a.Name == productMasterVM.Name.Trim() && a.IsActive == true);
                if (productMaster == null)
                {
                    productMaster = new ProductMaster();
                    productMaster.Name = productMasterVM.Name.Trim();
                    productMaster.CategoryId = productMasterVM.CategoryId;
                    productMaster.IsActive = true;
                    await _context.AddAsync(productMaster);

                    productMasterDto.product = productMaster;
                    productMasterDto.Message = "Product Added!";

                }
                else
                {
                    productMasterDto.IsError = true;
                    productMasterDto.Message = "Product Name exists!";
                    productMasterDto.product = null;
                }
            }
            if (productMasterDto != null)
                await _context.SaveChangesAsync();

            
            return productMasterDto;
        }

        public ProductMasterDto Delete(int id)
        {
            ProductMasterDto productMasterDto = new ProductMasterDto();
            productMasterDto.IsError = false;
            ProductMaster product = new ProductMaster();

            product = _context.ProductMaster.SingleOrDefault(a => a.ID == id && a.IsActive == true);
            if (product != null)
            {
                product.IsActive = false;
                _context.Update(product);
                _context.SaveChanges();
                productMasterDto.IsError = false;
                productMasterDto.Message = "Deleted";
            }
            else
            {
                productMasterDto.IsError = true;
                productMasterDto.Message = "Not Exists";
            }
            productMasterDto.product = product;
            productMasterDto.categories = _context.CategoryMaster.Where(a => a.IsActive == true).OrderBy(a => a.Name).ToList();
            return productMasterDto;
        }
        public ProductMasterDto GetById(int id)
        {
            ProductMasterDto productMasterDto = new ProductMasterDto();
            productMasterDto.categories = _context.CategoryMaster.Where(a => a.IsActive == true).OrderBy(a => a.Name).ToList();

            productMasterDto.product = _context.ProductMaster.SingleOrDefault(a => a.ID == id);
            return productMasterDto;
        }

        public Pagination<ProductMaster> GetAll(int PageNo = 1, int PageSize = 10)
        {
            var query = (from p in _context.ProductMaster
                         join c in _context.CategoryMaster on p.CategoryId equals c.ID
                         where p.IsActive==true
                         select new ProductMaster
                         {
                             CategoryId = p.CategoryId,
                             ID = p.ID,
                             IsActive = p.IsActive,
                             Name = p.Name,
                             CategoryMaster = c
                         }).AsQueryable();
            return Pagination<ProductMaster>.ToPagedList(query,
                    PageNo,
                    PageSize);
        }
    }
}
