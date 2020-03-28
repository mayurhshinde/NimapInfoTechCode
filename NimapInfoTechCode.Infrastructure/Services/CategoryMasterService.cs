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
    public class CategoryMasterService : ICategoryMasterRepository
    {
        private readonly DataContext _context;
        public CategoryMasterService(DataContext context)
        {
            _context = context;
        }

        public async Task<CategoryMasterDto> AddUpdate(CategoryMasterVM categoryMasterVM)
        {
            CategoryMasterDto categoryMasterDto = new CategoryMasterDto();
            categoryMasterDto.IsError = false;
            CategoryMaster categoryMaster = new CategoryMaster();

            if (categoryMasterVM.Name  == null || categoryMasterVM.Name.Trim() =="")
            {
                categoryMasterDto.IsError = true;
                categoryMasterDto.Message = "Enter Category Name!";
                return categoryMasterDto;
            }

                if (categoryMasterVM.ID > 0)
            {
                categoryMaster = _context.CategoryMaster.SingleOrDefault(a => a.ID == categoryMasterVM.ID);
                if (categoryMaster != null)
                {
                    var checkName = _context.CategoryMaster.SingleOrDefault(a => a.ID != categoryMasterVM.ID && a.Name == categoryMasterVM.Name.Trim());
                    if (checkName != null)
                    {
                        categoryMasterDto.IsError = true;
                        categoryMasterDto.Message = categoryMasterVM.Name.Trim() + " Already Exists!";
                        categoryMasterDto.category = null;

                        return categoryMasterDto;
                    }
                    categoryMaster.Name = categoryMasterVM.Name.Trim();
                    categoryMaster.IsActive = categoryMasterVM.IsActive;
                    _context.Update(categoryMaster);
                    categoryMasterDto.category = categoryMaster;
                    categoryMasterDto.Message = "Category Updated!";
                }
                else
                {
                    categoryMasterDto.IsError = true;
                    categoryMasterDto.Message = "Id not exists!";
                    categoryMasterDto.category = null;
                }
            }
            else
            {
                categoryMaster = _context.CategoryMaster.SingleOrDefault(a => a.Name == categoryMasterVM.Name.Trim() && a.IsActive == true);
                if (categoryMaster == null)
                {
                    categoryMaster = new CategoryMaster();
                    categoryMaster.Name = categoryMasterVM.Name.Trim();
                    await _context.AddAsync(categoryMaster);

                    categoryMasterDto.category = categoryMaster;
                    categoryMasterDto.Message = "Category Added!";

                }
                else
                {
                    categoryMasterDto.IsError = true;
                    categoryMasterDto.Message = "Category Name exists!";
                    categoryMasterDto.category = null;
                }
            }
            if (categoryMasterDto != null)
                await _context.SaveChangesAsync();
            return categoryMasterDto;
        }

        public CategoryMasterDto Delete(int id)
        {
            CategoryMasterDto categoryMasterDto = new CategoryMasterDto();
            categoryMasterDto.IsError = false;
            CategoryMaster categoryMaster = new CategoryMaster();

            categoryMaster = _context.CategoryMaster.SingleOrDefault(a => a.ID == id && a.IsActive == true);
            if (categoryMaster != null)
            {
                categoryMaster.IsActive = false;
                _context.Update(categoryMaster);
                _context.SaveChanges();

                categoryMasterDto.IsError = true;
                categoryMasterDto.Message = "Deleted";
            }
            else
            {
                categoryMasterDto.Message = "Not Exists";
            }
            return categoryMasterDto;
        }

        public CategoryMaster GetById(int id)
        {
            CategoryMaster category = _context.CategoryMaster.SingleOrDefault(a => a.ID == id);
            return category;
        }

        public Pagination<CategoryMaster> GetAll(int PageNo = 1, int PageSize = 10)
        {
            return Pagination<CategoryMaster>.ToPagedList(_context.CategoryMaster.Where(a => a.IsActive == true).OrderBy(on => on.ID),
                    PageNo,
                    PageSize);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }

}
