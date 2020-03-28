using NimapInfoTechCode.Core.DTO;
using NimapInfoTechCode.Core.Entities;
using NimapInfoTechCode.Core.ViewModel;
using NimapInfoTechCode.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NimapInfoTechCode.Infrastructure.Interfaces
{
    public interface ICategoryMasterRepository
    {
        Task<CategoryMasterDto> AddUpdate(CategoryMasterVM categoryMasterVM);
        CategoryMasterDto Delete(int id);

        CategoryMaster GetById(int id);

        Pagination<CategoryMaster> GetAll(int page = 1, int PageSize = 10);

    }
}
