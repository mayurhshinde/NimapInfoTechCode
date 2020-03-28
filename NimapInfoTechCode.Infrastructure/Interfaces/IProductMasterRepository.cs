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
    public interface IProductMasterRepository
    {
        Task<ProductMasterDto> AddUpdate(ProductMasterVM categoryMasterVM);
        ProductMasterDto Delete(int id);

        ProductMasterDto GetById(int id);

        Pagination<ProductMaster> GetAll(int page = 1, int PageSize = 10);
    }
}
